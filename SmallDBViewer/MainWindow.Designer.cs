namespace SmallDBViewer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            tabControlMain = new TabControl();
            tabPageTablesAndViews = new TabPage();
            dataGridViewTablesAndViews = new DataGridView();
            columnForTABLE_SCHEMA = new DataGridViewTextBoxColumn();
            columnForTABLE_NAME = new DataGridViewTextBoxColumn();
            columnForTABLE_TYPE = new DataGridViewTextBoxColumn();
            panelTablesAndViews = new Panel();
            buttonShowColumns = new Button();
            labelTablesAndViews = new Label();
            tabPageColumns = new TabPage();
            dataGridViewColumns = new DataGridView();
            panelColumns = new Panel();
            buttonShowTablesAndViews = new Button();
            labelColums = new Label();
            columnForCOLUMN_NAME = new DataGridViewTextBoxColumn();
            columnForCOLUMN_DEFAULT = new DataGridViewTextBoxColumn();
            columnForIS_NULLABLE = new DataGridViewTextBoxColumn();
            columnForDATA_TYPE = new DataGridViewTextBoxColumn();
            columnForCHARACTER_MAXIMUM_LENGTH = new DataGridViewTextBoxColumn();
            columnForCHARACTER_OCTET_LENGTH = new DataGridViewTextBoxColumn();
            columnForNUMERIC_PRECISION = new DataGridViewTextBoxColumn();
            columnForNUMERIC_PRECISION_RADIX = new DataGridViewTextBoxColumn();
            columnForNUMERIC_SCALE = new DataGridViewTextBoxColumn();
            columnForDATETIME_PRECISION = new DataGridViewTextBoxColumn();
            columnForCHARACTER_SET_CATALOG = new DataGridViewTextBoxColumn();
            columnForCHARACTER_SET_NAME = new DataGridViewTextBoxColumn();
            columnForCOLLATION_NAME = new DataGridViewTextBoxColumn();
            tabControlMain.SuspendLayout();
            tabPageTablesAndViews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablesAndViews).BeginInit();
            panelTablesAndViews.SuspendLayout();
            tabPageColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewColumns).BeginInit();
            panelColumns.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.Controls.Add(tabPageTablesAndViews);
            tabControlMain.Controls.Add(tabPageColumns);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(847, 475);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabPageTablesAndViews
            // 
            tabPageTablesAndViews.BackColor = Color.WhiteSmoke;
            tabPageTablesAndViews.Controls.Add(dataGridViewTablesAndViews);
            tabPageTablesAndViews.Controls.Add(panelTablesAndViews);
            tabPageTablesAndViews.Controls.Add(labelTablesAndViews);
            tabPageTablesAndViews.Location = new Point(4, 27);
            tabPageTablesAndViews.Margin = new Padding(0);
            tabPageTablesAndViews.Name = "tabPageTablesAndViews";
            tabPageTablesAndViews.Size = new Size(792, 419);
            tabPageTablesAndViews.TabIndex = 0;
            tabPageTablesAndViews.Text = "Page 1";
            // 
            // dataGridViewTablesAndViews
            // 
            dataGridViewTablesAndViews.AllowUserToAddRows = false;
            dataGridViewTablesAndViews.AllowUserToDeleteRows = false;
            dataGridViewTablesAndViews.BackgroundColor = Color.Gainsboro;
            dataGridViewTablesAndViews.ColumnHeadersHeight = 40;
            dataGridViewTablesAndViews.Columns.AddRange(new DataGridViewColumn[] { columnForTABLE_SCHEMA, columnForTABLE_NAME, columnForTABLE_TYPE });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTablesAndViews.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTablesAndViews.Dock = DockStyle.Fill;
            dataGridViewTablesAndViews.Location = new Point(0, 30);
            dataGridViewTablesAndViews.Name = "dataGridViewTablesAndViews";
            dataGridViewTablesAndViews.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewTablesAndViews.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTablesAndViews.RowHeadersVisible = false;
            dataGridViewTablesAndViews.RowHeadersWidth = 22;
            dataGridViewTablesAndViews.Size = new Size(792, 359);
            dataGridViewTablesAndViews.TabIndex = 1;
            // 
            // columnForTABLE_SCHEMA
            // 
            columnForTABLE_SCHEMA.DataPropertyName = "TABLE_SCHEMA";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForTABLE_SCHEMA.DefaultCellStyle = dataGridViewCellStyle1;
            columnForTABLE_SCHEMA.HeaderText = "Schema";
            columnForTABLE_SCHEMA.Name = "columnForTABLE_SCHEMA";
            columnForTABLE_SCHEMA.ReadOnly = true;
            columnForTABLE_SCHEMA.Width = 150;
            // 
            // columnForTABLE_NAME
            // 
            columnForTABLE_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columnForTABLE_NAME.DataPropertyName = "TABLE_NAME";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForTABLE_NAME.DefaultCellStyle = dataGridViewCellStyle2;
            columnForTABLE_NAME.HeaderText = "Nazwa";
            columnForTABLE_NAME.Name = "columnForTABLE_NAME";
            columnForTABLE_NAME.ReadOnly = true;
            // 
            // columnForTABLE_TYPE
            // 
            columnForTABLE_TYPE.DataPropertyName = "TABLE_TYPE";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForTABLE_TYPE.DefaultCellStyle = dataGridViewCellStyle3;
            columnForTABLE_TYPE.HeaderText = "Widok czy tabela";
            columnForTABLE_TYPE.Name = "columnForTABLE_TYPE";
            columnForTABLE_TYPE.ReadOnly = true;
            columnForTABLE_TYPE.Width = 150;
            // 
            // panelTablesAndViews
            // 
            panelTablesAndViews.Controls.Add(buttonShowColumns);
            panelTablesAndViews.Dock = DockStyle.Bottom;
            panelTablesAndViews.Location = new Point(0, 389);
            panelTablesAndViews.Name = "panelTablesAndViews";
            panelTablesAndViews.Padding = new Padding(0, 3, 100, 3);
            panelTablesAndViews.Size = new Size(792, 30);
            panelTablesAndViews.TabIndex = 1;
            // 
            // buttonShowColumns
            // 
            buttonShowColumns.Dock = DockStyle.Right;
            buttonShowColumns.Location = new Point(492, 3);
            buttonShowColumns.Margin = new Padding(0);
            buttonShowColumns.MaximumSize = new Size(200, 0);
            buttonShowColumns.Name = "buttonShowColumns";
            buttonShowColumns.Size = new Size(200, 24);
            buttonShowColumns.TabIndex = 0;
            buttonShowColumns.Text = "Pokaż kolumny dla tego wiersza";
            buttonShowColumns.UseVisualStyleBackColor = true;
            buttonShowColumns.Click += buttonShowColumns_Click;
            // 
            // labelTablesAndViews
            // 
            labelTablesAndViews.Dock = DockStyle.Top;
            labelTablesAndViews.Font = new Font("Segoe UI", 14F);
            labelTablesAndViews.Location = new Point(0, 0);
            labelTablesAndViews.Name = "labelTablesAndViews";
            labelTablesAndViews.Size = new Size(792, 30);
            labelTablesAndViews.TabIndex = 0;
            labelTablesAndViews.Text = "Lista widoków i tabel";
            labelTablesAndViews.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPageColumns
            // 
            tabPageColumns.BackColor = Color.WhiteSmoke;
            tabPageColumns.Controls.Add(dataGridViewColumns);
            tabPageColumns.Controls.Add(panelColumns);
            tabPageColumns.Controls.Add(labelColums);
            tabPageColumns.Location = new Point(4, 27);
            tabPageColumns.Margin = new Padding(0);
            tabPageColumns.Name = "tabPageColumns";
            tabPageColumns.Size = new Size(839, 444);
            tabPageColumns.TabIndex = 1;
            tabPageColumns.Text = "Page 2";
            // 
            // dataGridViewColumns
            // 
            dataGridViewColumns.AllowUserToAddRows = false;
            dataGridViewColumns.AllowUserToDeleteRows = false;
            dataGridViewColumns.BackgroundColor = Color.Gainsboro;
            dataGridViewColumns.ColumnHeadersHeight = 40;
            dataGridViewColumns.Columns.AddRange(new DataGridViewColumn[] { columnForCOLUMN_NAME, columnForCOLUMN_DEFAULT, columnForIS_NULLABLE, columnForDATA_TYPE, columnForCHARACTER_MAXIMUM_LENGTH, columnForCHARACTER_OCTET_LENGTH, columnForNUMERIC_PRECISION, columnForNUMERIC_PRECISION_RADIX, columnForNUMERIC_SCALE, columnForDATETIME_PRECISION, columnForCHARACTER_SET_CATALOG, columnForCHARACTER_SET_NAME, columnForCOLLATION_NAME });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = SystemColors.Window;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridViewColumns.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewColumns.Dock = DockStyle.Fill;
            dataGridViewColumns.Location = new Point(0, 30);
            dataGridViewColumns.Name = "dataGridViewColumns";
            dataGridViewColumns.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Control;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridViewColumns.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewColumns.RowHeadersVisible = false;
            dataGridViewColumns.RowHeadersWidth = 22;
            dataGridViewColumns.Size = new Size(839, 384);
            dataGridViewColumns.TabIndex = 3;
            // 
            // panelColumns
            // 
            panelColumns.Controls.Add(buttonShowTablesAndViews);
            panelColumns.Dock = DockStyle.Bottom;
            panelColumns.Location = new Point(0, 414);
            panelColumns.Name = "panelColumns";
            panelColumns.Padding = new Padding(0, 3, 100, 3);
            panelColumns.Size = new Size(839, 30);
            panelColumns.TabIndex = 2;
            // 
            // buttonShowTablesAndViews
            // 
            buttonShowTablesAndViews.Dock = DockStyle.Right;
            buttonShowTablesAndViews.Location = new Point(539, 3);
            buttonShowTablesAndViews.Margin = new Padding(0);
            buttonShowTablesAndViews.MaximumSize = new Size(200, 0);
            buttonShowTablesAndViews.Name = "buttonShowTablesAndViews";
            buttonShowTablesAndViews.Size = new Size(200, 24);
            buttonShowTablesAndViews.TabIndex = 0;
            buttonShowTablesAndViews.Text = "Pokaż listę widoków i tabel";
            buttonShowTablesAndViews.UseVisualStyleBackColor = true;
            buttonShowTablesAndViews.Click += buttonShowTablesAndViews_Click;
            // 
            // labelColums
            // 
            labelColums.Dock = DockStyle.Top;
            labelColums.Font = new Font("Segoe UI", 14F);
            labelColums.Location = new Point(0, 0);
            labelColums.Name = "labelColums";
            labelColums.Size = new Size(839, 30);
            labelColums.TabIndex = 1;
            labelColums.Text = "Lista kolumn";
            labelColums.TextAlign = ContentAlignment.TopCenter;
            // 
            // columnForCOLUMN_NAME
            // 
            columnForCOLUMN_NAME.DataPropertyName = "COLUMN_NAME";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCOLUMN_NAME.DefaultCellStyle = dataGridViewCellStyle6;
            columnForCOLUMN_NAME.HeaderText = "Nazwa";
            columnForCOLUMN_NAME.Name = "columnForCOLUMN_NAME";
            columnForCOLUMN_NAME.ReadOnly = true;
            columnForCOLUMN_NAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForCOLUMN_NAME.Width = 135;
            // 
            // columnForCOLUMN_DEFAULT
            // 
            columnForCOLUMN_DEFAULT.DataPropertyName = "COLUMN_DEFAULT";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCOLUMN_DEFAULT.DefaultCellStyle = dataGridViewCellStyle7;
            columnForCOLUMN_DEFAULT.HeaderText = "Wartość domyślna";
            columnForCOLUMN_DEFAULT.Name = "columnForCOLUMN_DEFAULT";
            columnForCOLUMN_DEFAULT.ReadOnly = true;
            columnForCOLUMN_DEFAULT.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForCOLUMN_DEFAULT.Width = 75;
            // 
            // columnForIS_NULLABLE
            // 
            columnForIS_NULLABLE.DataPropertyName = "IS_NULLABLE";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForIS_NULLABLE.DefaultCellStyle = dataGridViewCellStyle8;
            columnForIS_NULLABLE.HeaderText = "Może być pusta?";
            columnForIS_NULLABLE.Name = "columnForIS_NULLABLE";
            columnForIS_NULLABLE.ReadOnly = true;
            columnForIS_NULLABLE.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForIS_NULLABLE.Width = 70;
            // 
            // columnForDATA_TYPE
            // 
            columnForDATA_TYPE.DataPropertyName = "DATA_TYPE";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForDATA_TYPE.DefaultCellStyle = dataGridViewCellStyle9;
            columnForDATA_TYPE.HeaderText = "Typ";
            columnForDATA_TYPE.Name = "columnForDATA_TYPE";
            columnForDATA_TYPE.ReadOnly = true;
            columnForDATA_TYPE.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForDATA_TYPE.Width = 50;
            // 
            // columnForCHARACTER_MAXIMUM_LENGTH
            // 
            columnForCHARACTER_MAXIMUM_LENGTH.DataPropertyName = "CHARACTER_MAXIMUM_LENGTH";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCHARACTER_MAXIMUM_LENGTH.DefaultCellStyle = dataGridViewCellStyle10;
            columnForCHARACTER_MAXIMUM_LENGTH.HeaderText = "Długość w bajtach";
            columnForCHARACTER_MAXIMUM_LENGTH.Name = "columnForCHARACTER_MAXIMUM_LENGTH";
            columnForCHARACTER_MAXIMUM_LENGTH.ReadOnly = true;
            columnForCHARACTER_MAXIMUM_LENGTH.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForCHARACTER_MAXIMUM_LENGTH.Width = 70;
            // 
            // columnForCHARACTER_OCTET_LENGTH
            // 
            columnForCHARACTER_OCTET_LENGTH.DataPropertyName = "CHARACTER_OCTET_LENGTH";
            columnForCHARACTER_OCTET_LENGTH.HeaderText = "Długość w znakach";
            columnForCHARACTER_OCTET_LENGTH.Name = "columnForCHARACTER_OCTET_LENGTH";
            columnForCHARACTER_OCTET_LENGTH.ReadOnly = true;
            columnForCHARACTER_OCTET_LENGTH.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForCHARACTER_OCTET_LENGTH.Width = 70;
            // 
            // columnForNUMERIC_PRECISION
            // 
            columnForNUMERIC_PRECISION.DataPropertyName = "NUMERIC_PRECISION";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForNUMERIC_PRECISION.DefaultCellStyle = dataGridViewCellStyle11;
            columnForNUMERIC_PRECISION.HeaderText = "NUMERIC_PRECISION";
            columnForNUMERIC_PRECISION.Name = "columnForNUMERIC_PRECISION";
            columnForNUMERIC_PRECISION.ReadOnly = true;
            columnForNUMERIC_PRECISION.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForNUMERIC_PRECISION.Visible = false;
            // 
            // columnForNUMERIC_PRECISION_RADIX
            // 
            columnForNUMERIC_PRECISION_RADIX.DataPropertyName = "NUMERIC_PRECISION_RADIX";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForNUMERIC_PRECISION_RADIX.DefaultCellStyle = dataGridViewCellStyle12;
            columnForNUMERIC_PRECISION_RADIX.HeaderText = "NUMERIC_PRECISION_RADIX";
            columnForNUMERIC_PRECISION_RADIX.Name = "columnForNUMERIC_PRECISION_RADIX";
            columnForNUMERIC_PRECISION_RADIX.ReadOnly = true;
            columnForNUMERIC_PRECISION_RADIX.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForNUMERIC_PRECISION_RADIX.Visible = false;
            // 
            // columnForNUMERIC_SCALE
            // 
            columnForNUMERIC_SCALE.DataPropertyName = "NUMERIC_SCALE";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForNUMERIC_SCALE.DefaultCellStyle = dataGridViewCellStyle13;
            columnForNUMERIC_SCALE.HeaderText = "NUMERIC_SCALE";
            columnForNUMERIC_SCALE.Name = "columnForNUMERIC_SCALE";
            columnForNUMERIC_SCALE.ReadOnly = true;
            columnForNUMERIC_SCALE.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForNUMERIC_SCALE.Visible = false;
            // 
            // columnForDATETIME_PRECISION
            // 
            columnForDATETIME_PRECISION.DataPropertyName = "DATETIME_PRECISION";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForDATETIME_PRECISION.DefaultCellStyle = dataGridViewCellStyle14;
            columnForDATETIME_PRECISION.HeaderText = "Precyzja dla DATETIME";
            columnForDATETIME_PRECISION.Name = "columnForDATETIME_PRECISION";
            columnForDATETIME_PRECISION.ReadOnly = true;
            columnForDATETIME_PRECISION.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForDATETIME_PRECISION.Width = 75;
            // 
            // columnForCHARACTER_SET_CATALOG
            // 
            columnForCHARACTER_SET_CATALOG.DataPropertyName = "CHARACTER_SET_NAME";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCHARACTER_SET_CATALOG.DefaultCellStyle = dataGridViewCellStyle15;
            columnForCHARACTER_SET_CATALOG.HeaderText = "Baza z zestawem znaków";
            columnForCHARACTER_SET_CATALOG.Name = "columnForCHARACTER_SET_CATALOG";
            columnForCHARACTER_SET_CATALOG.ReadOnly = true;
            columnForCHARACTER_SET_CATALOG.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // columnForCHARACTER_SET_NAME
            // 
            columnForCHARACTER_SET_NAME.DataPropertyName = "CHARACTER_SET_NAME";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCHARACTER_SET_NAME.DefaultCellStyle = dataGridViewCellStyle16;
            columnForCHARACTER_SET_NAME.HeaderText = "Nazwa zestawu znaków";
            columnForCHARACTER_SET_NAME.Name = "columnForCHARACTER_SET_NAME";
            columnForCHARACTER_SET_NAME.ReadOnly = true;
            columnForCHARACTER_SET_NAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnForCHARACTER_SET_NAME.Width = 95;
            // 
            // columnForCOLLATION_NAME
            // 
            columnForCOLLATION_NAME.DataPropertyName = "COLLATION_NAME";
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnForCOLLATION_NAME.DefaultCellStyle = dataGridViewCellStyle17;
            columnForCOLLATION_NAME.HeaderText = "Rodzaj znaków";
            columnForCOLLATION_NAME.Name = "columnForCOLLATION_NAME";
            columnForCOLLATION_NAME.ReadOnly = true;
            columnForCOLLATION_NAME.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(847, 475);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(500, 300);
            Name = "MainWindow";
            Text = "Hardkorowy Kodsu";
            tabControlMain.ResumeLayout(false);
            tabPageTablesAndViews.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTablesAndViews).EndInit();
            panelTablesAndViews.ResumeLayout(false);
            tabPageColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewColumns).EndInit();
            panelColumns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageTablesAndViews;
        private TabPage tabPageColumns;
        private Label labelTablesAndViews;
        private Panel panelTablesAndViews;
        private DataGridView dataGridViewTablesAndViews;
        private Button buttonShowColumns;
        private Panel panelColumns;
        private Button buttonShowTablesAndViews;
        private Label labelColums;
        private DataGridViewTextBoxColumn columnForTABLE_SCHEMA;
        private DataGridViewTextBoxColumn columnForTABLE_NAME;
        private DataGridViewTextBoxColumn columnForTABLE_TYPE;
        private DataGridView dataGridViewColumns;
        private DataGridViewTextBoxColumn columnForCOLUMN_NAME;
        private DataGridViewTextBoxColumn columnForCOLUMN_DEFAULT;
        private DataGridViewTextBoxColumn columnForIS_NULLABLE;
        private DataGridViewTextBoxColumn columnForDATA_TYPE;
        private DataGridViewTextBoxColumn columnForCHARACTER_MAXIMUM_LENGTH;
        private DataGridViewTextBoxColumn columnForCHARACTER_OCTET_LENGTH;
        private DataGridViewTextBoxColumn columnForNUMERIC_PRECISION;
        private DataGridViewTextBoxColumn columnForNUMERIC_PRECISION_RADIX;
        private DataGridViewTextBoxColumn columnForNUMERIC_SCALE;
        private DataGridViewTextBoxColumn columnForDATETIME_PRECISION;
        private DataGridViewTextBoxColumn columnForCHARACTER_SET_CATALOG;
        private DataGridViewTextBoxColumn columnForCHARACTER_SET_NAME;
        private DataGridViewTextBoxColumn columnForCOLLATION_NAME;
    }
}
