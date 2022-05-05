namespace NewOrderDesign
{
    partial class CovidUSOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidUSOverview));
            this.button2 = new System.Windows.Forms.Button();
            this.FormHeading = new System.Windows.Forms.Label();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.Covid19_State_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CovidUSTotalLabel2 = new System.Windows.Forms.Label();
            this.CovidUSTotalLabel = new System.Windows.Forms.Label();
            this.TotalConfirmedDeaths = new System.Windows.Forms.Label();
            this.TotalConfirmedCases = new System.Windows.Forms.Label();
            this.Covid19Table = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedcasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet6 = new NewOrderDesign.CovidDataDataSet6();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TotalStateCovidResultsLabel2 = new System.Windows.Forms.Label();
            this.TotalStateCovidResultsLabel1 = new System.Windows.Forms.Label();
            this.TotalStateCovidLabel1 = new System.Windows.Forms.Label();
            this.PersonsComboBox = new System.Windows.Forms.ComboBox();
            this.RawDataButton = new System.Windows.Forms.Button();
            this.statesTableAdapter = new NewOrderDesign.CovidDataDataSet6TableAdapters.statesTableAdapter();
            this.covidDataDataSet7 = new NewOrderDesign.CovidDataDataSet7();
            this.statesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter1 = new NewOrderDesign.CovidDataDataSet7TableAdapters.statesTableAdapter();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedcasesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Covid19_State_Selection_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Covid19_State_Death_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Covid19_State_Selection_Death_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OverviewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet6)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Selection_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Death_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Selection_Death_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NewOrderDesign.Properties.Resources.BackButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(21, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHeading
            // 
            this.FormHeading.AutoSize = true;
            this.FormHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.FormHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormHeading.Location = new System.Drawing.Point(285, 1);
            this.FormHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormHeading.Name = "FormHeading";
            this.FormHeading.Size = new System.Drawing.Size(530, 58);
            this.FormHeading.TabIndex = 14;
            this.FormHeading.Text = "Covid-19 US Overview\r\n";
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.OverviewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OverviewTab.Controls.Add(this.Covid19_State_Death_Chart);
            this.OverviewTab.Controls.Add(this.Covid19_State_Chart);
            this.OverviewTab.Controls.Add(this.CovidUSTotalLabel2);
            this.OverviewTab.Controls.Add(this.CovidUSTotalLabel);
            this.OverviewTab.Controls.Add(this.TotalConfirmedDeaths);
            this.OverviewTab.Controls.Add(this.TotalConfirmedCases);
            this.OverviewTab.Controls.Add(this.Covid19Table);
            this.OverviewTab.Location = new System.Drawing.Point(4, 25);
            this.OverviewTab.Margin = new System.Windows.Forms.Padding(4);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(4);
            this.OverviewTab.Size = new System.Drawing.Size(1025, 409);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            this.OverviewTab.Click += new System.EventHandler(this.OverviewTab_Click);
            // 
            // Covid19_State_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Covid19_State_Chart.ChartAreas.Add(chartArea2);
            legend2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.Covid19_State_Chart.Legends.Add(legend2);
            this.Covid19_State_Chart.Location = new System.Drawing.Point(7, 7);
            this.Covid19_State_Chart.Name = "Covid19_State_Chart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Cases over Time";
            series2.Name = "Series1";
            this.Covid19_State_Chart.Series.Add(series2);
            this.Covid19_State_Chart.Size = new System.Drawing.Size(1015, 189);
            this.Covid19_State_Chart.TabIndex = 7;
            this.Covid19_State_Chart.Text = "chart1";
            // 
            // CovidUSTotalLabel2
            // 
            this.CovidUSTotalLabel2.AutoSize = true;
            this.CovidUSTotalLabel2.Location = new System.Drawing.Point(386, 180);
            this.CovidUSTotalLabel2.Name = "CovidUSTotalLabel2";
            this.CovidUSTotalLabel2.Size = new System.Drawing.Size(0, 16);
            this.CovidUSTotalLabel2.TabIndex = 5;
            // 
            // CovidUSTotalLabel
            // 
            this.CovidUSTotalLabel.AutoSize = true;
            this.CovidUSTotalLabel.Location = new System.Drawing.Point(386, 68);
            this.CovidUSTotalLabel.Name = "CovidUSTotalLabel";
            this.CovidUSTotalLabel.Size = new System.Drawing.Size(0, 16);
            this.CovidUSTotalLabel.TabIndex = 4;
            // 
            // TotalConfirmedDeaths
            // 
            this.TotalConfirmedDeaths.AutoSize = true;
            this.TotalConfirmedDeaths.Location = new System.Drawing.Point(55, 180);
            this.TotalConfirmedDeaths.Name = "TotalConfirmedDeaths";
            this.TotalConfirmedDeaths.Size = new System.Drawing.Size(299, 16);
            this.TotalConfirmedDeaths.TabIndex = 1;
            this.TotalConfirmedDeaths.Text = "Total Reports for Covid-19 confirmed deaths (US)\r\n";
            // 
            // TotalConfirmedCases
            // 
            this.TotalConfirmedCases.AutoSize = true;
            this.TotalConfirmedCases.Location = new System.Drawing.Point(55, 68);
            this.TotalConfirmedCases.Name = "TotalConfirmedCases";
            this.TotalConfirmedCases.Size = new System.Drawing.Size(298, 32);
            this.TotalConfirmedCases.TabIndex = 0;
            this.TotalConfirmedCases.Text = "Total Reports for Covid-19 confirmed cases (US):\r\n\r\n";
            // 
            // Covid19Table
            // 
            this.Covid19Table.AutoGenerateColumns = false;
            this.Covid19Table.ColumnHeadersHeight = 29;
            this.Covid19Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn1,
            this.statenameDataGridViewTextBoxColumn1,
            this.confirmedcasesDataGridViewTextBoxColumn1,
            this.deathsDataGridViewTextBoxColumn1});
            this.Covid19Table.DataSource = this.statesBindingSource1;
            this.Covid19Table.Location = new System.Drawing.Point(778, 26);
            this.Covid19Table.Name = "Covid19Table";
            this.Covid19Table.RowHeadersWidth = 51;
            this.Covid19Table.Size = new System.Drawing.Size(240, 150);
            this.Covid19Table.TabIndex = 8;
            this.Covid19Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetData_CellContentClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // statenameDataGridViewTextBoxColumn
            // 
            this.statenameDataGridViewTextBoxColumn.DataPropertyName = "state_name";
            this.statenameDataGridViewTextBoxColumn.HeaderText = "state_name";
            this.statenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statenameDataGridViewTextBoxColumn.Name = "statenameDataGridViewTextBoxColumn";
            this.statenameDataGridViewTextBoxColumn.Width = 125;
            // 
            // confirmedcasesDataGridViewTextBoxColumn
            // 
            this.confirmedcasesDataGridViewTextBoxColumn.DataPropertyName = "confirmed_cases";
            this.confirmedcasesDataGridViewTextBoxColumn.HeaderText = "confirmed_cases";
            this.confirmedcasesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.confirmedcasesDataGridViewTextBoxColumn.Name = "confirmedcasesDataGridViewTextBoxColumn";
            this.confirmedcasesDataGridViewTextBoxColumn.Width = 125;
            // 
            // deathsDataGridViewTextBoxColumn
            // 
            this.deathsDataGridViewTextBoxColumn.DataPropertyName = "deaths";
            this.deathsDataGridViewTextBoxColumn.HeaderText = "deaths";
            this.deathsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deathsDataGridViewTextBoxColumn.Name = "deathsDataGridViewTextBoxColumn";
            this.deathsDataGridViewTextBoxColumn.Width = 125;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.covidDataDataSet6;
            // 
            // covidDataDataSet6
            // 
            this.covidDataDataSet6.DataSetName = "CovidDataDataSet6";
            this.covidDataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.OverviewTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(17, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 438);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Covid19_State_Selection_Death_Chart);
            this.tabPage1.Controls.Add(this.Covid19_State_Selection_Chart);
            this.tabPage1.Controls.Add(this.TotalStateCovidResultsLabel2);
            this.tabPage1.Controls.Add(this.TotalStateCovidResultsLabel1);
            this.tabPage1.Controls.Add(this.TotalStateCovidLabel1);
            this.tabPage1.Controls.Add(this.PersonsComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1025, 409);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "StateSelector";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TotalStateCovidResultsLabel2
            // 
            this.TotalStateCovidResultsLabel2.AutoSize = true;
            this.TotalStateCovidResultsLabel2.Location = new System.Drawing.Point(476, 206);
            this.TotalStateCovidResultsLabel2.Name = "TotalStateCovidResultsLabel2";
            this.TotalStateCovidResultsLabel2.Size = new System.Drawing.Size(0, 16);
            this.TotalStateCovidResultsLabel2.TabIndex = 8;
            // 
            // TotalStateCovidResultsLabel1
            // 
            this.TotalStateCovidResultsLabel1.AutoSize = true;
            this.TotalStateCovidResultsLabel1.Location = new System.Drawing.Point(476, 94);
            this.TotalStateCovidResultsLabel1.Name = "TotalStateCovidResultsLabel1";
            this.TotalStateCovidResultsLabel1.Size = new System.Drawing.Size(0, 16);
            this.TotalStateCovidResultsLabel1.TabIndex = 7;
            // 
            // TotalStateCovidLabel1
            // 
            this.TotalStateCovidLabel1.AutoSize = true;
            this.TotalStateCovidLabel1.Location = new System.Drawing.Point(216, 94);
            this.TotalStateCovidLabel1.Name = "TotalStateCovidLabel1";
            this.TotalStateCovidLabel1.Size = new System.Drawing.Size(199, 32);
            this.TotalStateCovidLabel1.TabIndex = 5;
            this.TotalStateCovidLabel1.Text = "Total Covid-19 confirmed cases:\r\n\r\n";
            // 
            // PersonsComboBox
            // 
            this.PersonsComboBox.AllowDrop = true;
            this.PersonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonsComboBox.FormattingEnabled = true;
            this.PersonsComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.PersonsComboBox.Location = new System.Drawing.Point(4, 4);
            this.PersonsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PersonsComboBox.Name = "PersonsComboBox";
            this.PersonsComboBox.Size = new System.Drawing.Size(160, 24);
            this.PersonsComboBox.TabIndex = 1;
            this.PersonsComboBox.SelectedIndexChanged += new System.EventHandler(this.PersonsComboBox_SelectedIndexChanged);
            // 
            // RawDataButton
            // 
            this.RawDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RawDataButton.AutoSize = true;
            this.RawDataButton.Location = new System.Drawing.Point(930, 509);
            this.RawDataButton.Name = "RawDataButton";
            this.RawDataButton.Size = new System.Drawing.Size(116, 33);
            this.RawDataButton.TabIndex = 9;
            this.RawDataButton.Text = "View Raw Data";
            this.RawDataButton.UseVisualStyleBackColor = true;
            this.RawDataButton.Click += new System.EventHandler(this.RawDataButton_Click);
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // covidDataDataSet7
            // 
            this.covidDataDataSet7.DataSetName = "CovidDataDataSet7";
            this.covidDataDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource1
            // 
            this.statesBindingSource1.DataMember = "states";
            this.statesBindingSource1.DataSource = this.covidDataDataSet7;
            // 
            // statesTableAdapter1
            // 
            this.statesTableAdapter1.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // statenameDataGridViewTextBoxColumn1
            // 
            this.statenameDataGridViewTextBoxColumn1.DataPropertyName = "state_name";
            this.statenameDataGridViewTextBoxColumn1.HeaderText = "state_name";
            this.statenameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statenameDataGridViewTextBoxColumn1.Name = "statenameDataGridViewTextBoxColumn1";
            this.statenameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // confirmedcasesDataGridViewTextBoxColumn1
            // 
            this.confirmedcasesDataGridViewTextBoxColumn1.DataPropertyName = "confirmed_cases";
            this.confirmedcasesDataGridViewTextBoxColumn1.HeaderText = "confirmed_cases";
            this.confirmedcasesDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.confirmedcasesDataGridViewTextBoxColumn1.Name = "confirmedcasesDataGridViewTextBoxColumn1";
            this.confirmedcasesDataGridViewTextBoxColumn1.Width = 125;
            // 
            // deathsDataGridViewTextBoxColumn1
            // 
            this.deathsDataGridViewTextBoxColumn1.DataPropertyName = "deaths";
            this.deathsDataGridViewTextBoxColumn1.HeaderText = "deaths";
            this.deathsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.deathsDataGridViewTextBoxColumn1.Name = "deathsDataGridViewTextBoxColumn1";
            this.deathsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Covid19_State_Selection_Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.Covid19_State_Selection_Chart.ChartAreas.Add(chartArea4);
            legend4.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold);
            legend4.Name = "Legend1";
            this.Covid19_State_Selection_Chart.Legends.Add(legend4);
            this.Covid19_State_Selection_Chart.Location = new System.Drawing.Point(171, 4);
            this.Covid19_State_Selection_Chart.Name = "Covid19_State_Selection_Chart";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Cases over Time";
            series4.Name = "Series1";
            this.Covid19_State_Selection_Chart.Series.Add(series4);
            this.Covid19_State_Selection_Chart.Size = new System.Drawing.Size(851, 199);
            this.Covid19_State_Selection_Chart.TabIndex = 9;
            this.Covid19_State_Selection_Chart.Text = "chart1";
            // 
            // Covid19_State_Death_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Covid19_State_Death_Chart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Covid19_State_Death_Chart.Legends.Add(legend1);
            this.Covid19_State_Death_Chart.Location = new System.Drawing.Point(7, 202);
            this.Covid19_State_Death_Chart.Name = "Covid19_State_Death_Chart";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "Deaths over Time";
            series1.Name = "Series1";
            this.Covid19_State_Death_Chart.Series.Add(series1);
            this.Covid19_State_Death_Chart.Size = new System.Drawing.Size(1011, 200);
            this.Covid19_State_Death_Chart.TabIndex = 9;
            this.Covid19_State_Death_Chart.Text = "chart1";
            // 
            // Covid19_State_Selection_Death_Chart
            // 
            this.Covid19_State_Selection_Death_Chart.BorderlineColor = System.Drawing.Color.Red;
            chartArea3.BorderColor = System.Drawing.Color.Red;
            chartArea3.Name = "ChartArea1";
            this.Covid19_State_Selection_Death_Chart.ChartAreas.Add(chartArea3);
            legend3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.Covid19_State_Selection_Death_Chart.Legends.Add(legend3);
            this.Covid19_State_Selection_Death_Chart.Location = new System.Drawing.Point(171, 209);
            this.Covid19_State_Selection_Death_Chart.Name = "Covid19_State_Selection_Death_Chart";
            series3.BorderColor = System.Drawing.Color.Red;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Deaths over Time";
            series3.Name = "Series1";
            this.Covid19_State_Selection_Death_Chart.Series.Add(series3);
            this.Covid19_State_Selection_Death_Chart.Size = new System.Drawing.Size(851, 197);
            this.Covid19_State_Selection_Death_Chart.TabIndex = 10;
            this.Covid19_State_Selection_Death_Chart.Text = "chart1";
            // 
            // CovidUSOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RawDataButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.FormHeading);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "CovidUSOverview";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelSite";
            this.Load += new System.EventHandler(this.CovidUSOverview_Load);
            this.OverviewTab.ResumeLayout(false);
            this.OverviewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet6)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Selection_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Death_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Covid19_State_Selection_Death_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label FormHeading;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.Label TotalConfirmedDeaths;
        private System.Windows.Forms.Label TotalConfirmedCases;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox PersonsComboBox;
        private System.Windows.Forms.Label TotalStateCovidResultsLabel2;
        private System.Windows.Forms.Label TotalStateCovidResultsLabel1;
        private System.Windows.Forms.Label TotalStateCovidLabel1;
        private System.Windows.Forms.Button RawDataButton;
        private System.Windows.Forms.Label CovidUSTotalLabel2;
        private System.Windows.Forms.Label CovidUSTotalLabel;
        private System.Windows.Forms.DataGridView Covid19Table;
        private CovidDataDataSet6 covidDataDataSet6;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private CovidDataDataSet6TableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmedcasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart Covid19_State_Chart;
        private CovidDataDataSet7 covidDataDataSet7;
        private System.Windows.Forms.BindingSource statesBindingSource1;
        private CovidDataDataSet7TableAdapters.statesTableAdapter statesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmedcasesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Covid19_State_Selection_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Covid19_State_Death_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Covid19_State_Selection_Death_Chart;
    }
}