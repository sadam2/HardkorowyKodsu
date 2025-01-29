using System.Configuration;
using System.Collections.Specialized;
using System.Data;
using RestSharp;
//using System.Text.Json.Nodes;
//using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SmallDBViewer
{
    public class DataFromApi
    {
        private static RestClient client = new(ConfigurationManager.AppSettings["Url"]);

        public static DataTable tablesAndViews = new DataTable();

        public static Task forTablesAndViews;

        public static DataTable columns = new DataTable();

        public static string currentSchema;
        public static string currentTableOrView;

        public static Task forColumns;

        public static void GetTables()
        {
            forTablesAndViews = Task.Factory.StartNew(() => getTables());
        }
        public static void GetColumns()
        {
            forColumns = Task.Factory.StartNew(() => getColumns());
        }
        private static DataTable Deserialize(string jsonArrayText)
        {
            // deserialize string response to DataTable object
            DataTable table = new();
            //Deserialize to array
            JArray array = JsonConvert.DeserializeObject(jsonArrayText) as JArray;
            if (array.Count > 0)
            {
                StringBuilder columns = new StringBuilder();
                JObject objColumns = array[0] as JObject;
                //Structure header
                foreach (JToken jkon in objColumns.AsEnumerable<JToken>())
                {
                    string name = ((JProperty)(jkon)).Name;
                    columns.Append(name + ",");
                    table.Columns.Add(name);
                }
                //Add data to the table
                for (int i = 0; i < array.Count; i++)
                {
                    DataRow row = table.NewRow();
                    JObject obj = array[i] as JObject;
                    foreach (JToken jkon in obj.AsEnumerable<JToken>())
                    {

                        string name = ((JProperty)jkon).Name;
                        string value = ((JProperty)jkon).Value.ToString();
                        row[name] = value;
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        private static DataTable Tables(string resource)
        {
            // send GET request with RestSharp
            RestRequest request = new RestRequest(resource);
            RestResponse response = client.Execute(request);

            return Deserialize(response.Content);
        }
        private static DataTable Columns(string resource, string schema, string tableOrView)
        {
            // send GET request with RestSharp
            RestRequest request = new RestRequest(resource);
            request.AddParameter("schema", schema);
            request.AddParameter("table", tableOrView);
            RestResponse response = client.Execute(request);
            return Deserialize(response.Content);
        }
        public static void getTables()
        {
            tablesAndViews = Tables("dbtables");
        }
        public static void getColumns()
        {
            columns = Columns("dbcolumns", currentSchema, currentTableOrView);
        }
    }
}
