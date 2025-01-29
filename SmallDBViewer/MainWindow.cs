using System.Data;
using System.Globalization;
using System.Net;
using System.Windows.Forms;

namespace SmallDBViewer
{
    public partial class MainWindow : Form
    {
        private string title;
        private string mess;
        public static DataTable columns = new DataTable();
        public MainWindow()
        {
            DoAction(ShowForm);
        }
        #region Utils
        private void ShowForm()
        {
            CultureInfo ci = new System.Globalization.CultureInfo("pl-PL");
            ci.NumberFormat.NumberDecimalSeparator = ",";
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat.LongDatePattern = "dddd, d MMMM rrrr";
            ci.DateTimeFormat.FullDateTimePattern = "dddd, d MMMM rrrr HH:mm:ss";
            ci.DateTimeFormat.ShortTimePattern = "HH:mm";
            ci.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            ci.DateTimeFormat.DateSeparator = "-";
            ci.DateTimeFormat.TimeSeparator = ":";
            Thread.CurrentThread.CurrentCulture = ci;
            InitializeComponent();
            // for test
            //columns = DataFromApi.getColumns("dbo", "DimProduct");
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            DataFromApi.forTablesAndViews.Wait();
            dataGridViewTablesAndViews.DataSource = DataFromApi.tablesAndViews;
        }
        private void ChangetabControlMainPage()
        {
            tabControlMain.SelectedIndex = (tabControlMain.SelectedIndex + 1) % 2;
        }
        private void doShowColums()
        {
            DataFromApi.currentSchema = dataGridViewTablesAndViews.CurrentRow.Cells[0].Value.ToString();
            DataFromApi.currentTableOrView = dataGridViewTablesAndViews.CurrentRow.Cells[1].Value.ToString();
            DataFromApi.GetColumns();
            DataFromApi.forColumns.Wait();
            dataGridViewColumns.DataSource = DataFromApi.columns;
            ChangetabControlMainPage();
        }
        private void DoAction(Action action)
        {
            Cursor cursor = Cursor;
            Cursor = Cursors.WaitCursor;
            if (tabControlMain != null) tabControlMain.Enabled = false;
            title = "";
            mess = "";
            bool error = false;
            try
            {
                try
                {
                    action();
                }
                catch (TimeoutException ex)
                {
                    title = ex.InnerException == null ? "TimeoutException" : ex.InnerException.Message;
                    mess = ex.Message;
                    error = true;
                }
                catch (WebException ex)
                {
                    title = ex.InnerException == null ? "WebException" : ex.InnerException.Message;
                    mess = ex.Message;
                    error = true;
                }
                catch (InvalidOperationException ex)
                {
                    title = ex.InnerException == null ? "InvalidOperationException" : ex.InnerException.Message;
                    mess = ex.Message;
                    error = true;
                }
                catch (Exception ex)
                {
                    title = ex.InnerException == null ? "Exception" : ex.InnerException.Message;
                    mess = ex.Message;
                    error = true;
                }
                if (error) MessageBox.Show(this, string.IsNullOrWhiteSpace(mess) ? "Wyst¹pi³ nieokreœlony b³¹d" : mess, string.IsNullOrWhiteSpace(title) ? "B³¹d" : title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (tabControlMain != null) tabControlMain.Enabled = true;
                Cursor = cursor;
            }
        }
        #endregion
        #region Actions
        private void buttonShowTablesAndViews_Click(object sender, EventArgs e)
        {
            DoAction(ChangetabControlMainPage);
        }

        private void buttonShowColumns_Click(object sender, EventArgs e)
        {
            DoAction(doShowColums);
        }
        #endregion
    }
}
