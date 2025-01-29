using SimpleDbViewer.Areas.HelpPage.Models;
using SimpleDbViewer.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleDbViewer.Controllers
{
    public class DbTablesController : ApiController
    {
        // GET api/dbtables
        public IEnumerable<TablesAndViews> Get()
        {
            List<TablesAndViews> list = new List<TablesAndViews>();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader sdr = null;
            string connStr = ConfigurationManager.ConnectionStrings["AdventureWorksDW2022Entities"].ConnectionString;
            string sqlText = "SELECT TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE FROM INFORMATION_SCHEMA.TABLES";
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
                                        list.Add(new TablesAndViews {
                                            TABLE_SCHEMA = SafeGet.ForString(sdr, 0),
                                            TABLE_NAME = SafeGet.ForString(sdr, 1),
                                            TABLE_TYPE = SafeGet.ForString(sdr, 2)
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
