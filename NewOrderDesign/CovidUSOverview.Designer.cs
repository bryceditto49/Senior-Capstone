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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidUSOverview));
            this.button2 = new System.Windows.Forms.Button();
            this.FormHeading = new System.Windows.Forms.Label();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.CovidUSTotalLabel2 = new System.Windows.Forms.Label();
            this.CovidUSTotalLabel = new System.Windows.Forms.Label();
            this.TotalConfirmedDeaths = new System.Windows.Forms.Label();
            this.TotalConfirmedCases = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TotalStateCovidResultsLabel2 = new System.Windows.Forms.Label();
            this.TotalStateCovidResultsLabel1 = new System.Windows.Forms.Label();
            this.TotalStateCovidLabel2 = new System.Windows.Forms.Label();
            this.TotalStateCovidLabel1 = new System.Windows.Forms.Label();
            this.PersonsComboBox = new System.Windows.Forms.ComboBox();
            this.RawDataButton = new System.Windows.Forms.Button();
            this.OverviewTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.OverviewTab.Controls.Add(this.CovidUSTotalLabel2);
            this.OverviewTab.Controls.Add(this.CovidUSTotalLabel);
            this.OverviewTab.Controls.Add(this.TotalConfirmedDeaths);
            this.OverviewTab.Controls.Add(this.TotalConfirmedCases);
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
            this.tabPage1.Controls.Add(this.TotalStateCovidResultsLabel2);
            this.tabPage1.Controls.Add(this.TotalStateCovidResultsLabel1);
            this.tabPage1.Controls.Add(this.TotalStateCovidLabel2);
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
            // TotalStateCovidLabel2
            // 
            this.TotalStateCovidLabel2.AutoSize = true;
            this.TotalStateCovidLabel2.Location = new System.Drawing.Point(216, 206);
            this.TotalStateCovidLabel2.Name = "TotalStateCovidLabel2";
            this.TotalStateCovidLabel2.Size = new System.Drawing.Size(203, 16);
            this.TotalStateCovidLabel2.TabIndex = 6;
            this.TotalStateCovidLabel2.Text = "Total Covid-19 confirmed deaths:";
            this.TotalStateCovidLabel2.Click += new System.EventHandler(this.label5_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Label TotalStateCovidLabel2;
        private System.Windows.Forms.Label TotalStateCovidLabel1;
        private System.Windows.Forms.Button RawDataButton;
        private System.Windows.Forms.Label CovidUSTotalLabel2;
        private System.Windows.Forms.Label CovidUSTotalLabel;
    }
}