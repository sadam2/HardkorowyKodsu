using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDbViewer.Models
{
    public class TablesAndViews
    {
        public string TABLE_SCHEMA { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_TYPE { get; set; }
    }
}