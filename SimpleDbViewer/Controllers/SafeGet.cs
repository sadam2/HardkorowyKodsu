using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SimpleDbViewer.Areas.HelpPage.Models
{
    public static class SafeGet
    {
        public static string ForString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }
        public static string ForInt(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetSqlInt32(colIndex).ToString();
            return "NULL";
        }
        public static string ForByte(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetByte(colIndex).ToString();
            return "NULL";
        }
        public static string ForSmallInt(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetSqlInt16(colIndex).ToString();
            return "NULL";
        }
    }
}