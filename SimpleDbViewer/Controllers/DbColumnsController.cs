using SimpleDbViewer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using SimpleDbViewer.Areas.HelpPage.Models;

namespace SimpleDbViewer.Controllers
{
    public class DbColumnsController : ApiController
    {
        // GET api/dbcolumns
        public IEnumerable<Columns> Get(string schema, string table)
        {
            string mess;
            List<Columns> list = new List<Columns>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader sdr = null;
            string connStr = ConfigurationManager.ConnectionStrings["AdventureWorksDW2022Entities"].ConnectionString;
            string sqlText = "SELECT COLUMN_NAME," +
                             "       COLUMN_DEFAULT," +
                             "       IS_NULLABLE," +
                             "       DATA_TYPE," +
                             "       CHARACTER_MAXIMUM_LENGTH," +
                             "       CHARACTER_OCTET_LENGTH," +
                             "       NUMERIC_PRECISION," +
                             "       NUMERIC_PRECISION_RADIX," +
                             "       NUMERIC_SCALE," +
                             "       DATETIME_PRECISION," +
                             "       CHARACTER_SET_CATALOG," +
                             "       CHARACTER_SET_NAME," +
                             "       COLLATION_NAME" +
                             "  FROM INFORMATION_SCHEMA.COLUMNS" +
                             "  WHERE TABLE_SCHEMA = '" + schema + "' AND" +
                             "        TABLE_NAME = '" + table + "'";
            try {
                using (conn = new SqlConnection(connStr)) {
                    conn.Open();
                    using (cmd = new SqlCommand(sqlText, conn)) {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 99999;
                        using (sdr = cmd.ExecuteReader()) {
                            if (sdr.HasRows) {
                                try {
                                    while (sdr.Read()) {
                                        list.Add(new Columns {
                                            COLUMN_NAME = SafeGet.ForString(sdr, 0),
                                            COLUMN_DEFAULT = SafeGet.ForString(sdr, 1),
                                            IS_NULLABLE = SafeGet.ForString(sdr, 2),
                                            DATA_TYPE = SafeGet.ForString(sdr, 3),
                                            CHARACTER_MAXIMUM_LENGTH = SafeGet.ForInt(sdr, 4),
                                            CHARACTER_OCTET_LENGTH = SafeGet.ForInt(sdr, 5),
                                            NUMERIC_PRECISION = SafeGet.ForByte(sdr, 6),
                                            NUMERIC_PRECISION_RADIX = SafeGet.ForSmallInt(sdr, 7),
                                            NUMERIC_SCALE = SafeGet.ForInt(sdr, 8),
                                            DATETIME_PRECISION = SafeGet.ForSmallInt(sdr, 9),
                                            CHARACTER_SET_CATALOG = SafeGet.ForString(sdr, 10),
                                            CHARACTER_SET_NAME = SafeGet.ForString(sdr, 11),
                                            COLLATION_NAME = SafeGet.ForString(sdr, 12)
                                        });
                                    }
                                }
                                catch (Exception) {}
                            }
                        }
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (Exception) {}
            finally {
                if (conn.State != ConnectionState.Closed) {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return list;
        }
    }
}
