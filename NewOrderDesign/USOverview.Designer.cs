
namespace NewOrderDesign
{
    partial class USOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USOverview));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.TotalCrimesAgainstSocietyLabel = new System.Windows.Forms.Label();
            this.TotalCrimesAgainstPropertyLabel = new System.Windows.Forms.Label();
            this.TotalCrimesAgainstPersonsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CrimesAgainstPersonsTab = new System.Windows.Forms.TabPage();
            this.TotalCrimesAgainstPersonsTabLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonsComboBox = new System.Windows.Forms.ComboBox();
            this.CrimesAgainstPropertyTab = new System.Windows.Forms.TabPage();
            this.TotalCrimesAgainstPropertyTabLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PropertyComboBox = new System.Windows.Forms.ComboBox();
            this.CrimesAgainstSocietyTab = new System.Windows.Forms.TabPage();
            this.TotalCrimesAgainstSocietyTabLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SocietyComboBox = new System.Windows.Forms.ComboBox();
            this.FormHeading = new System.Windows.Forms.Label();
            this.continueFBIUSView = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.OverviewTab.SuspendLayout();
            this.CrimesAgainstPersonsTab.SuspendLayout();
            this.CrimesAgainstPropertyTab.SuspendLayout();
            this.CrimesAgainstSocietyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OverviewTab);
            this.tabControl1.Controls.Add(this.CrimesAgainstPersonsTab);
            this.tabControl1.Controls.Add(this.CrimesAgainstPropertyTab);
            this.tabControl1.Controls.Add(this.CrimesAgainstSocietyTab);
            this.tabControl1.Location = new System.Drawing.Point(17, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 438);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // OverviewTab
            // 
            this.OverviewTab.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.OverviewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OverviewTab.Controls.Add(this.TotalCrimesAgainstSocietyLabel);
            this.OverviewTab.Controls.Add(this.TotalCrimesAgainstPropertyLabel);
            this.OverviewTab.Controls.Add(this.TotalCrimesAgainstPersonsLabel);
            this.OverviewTab.Controls.Add(this.label3);
            this.OverviewTab.Controls.Add(this.label2);
            this.OverviewTab.Controls.Add(this.label1);
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
            // TotalCrimesAgainstSocietyLabel
            // 
            this.TotalCrimesAgainstSocietyLabel.AutoSize = true;
            this.TotalCrimesAgainstSocietyLabel.Location = new System.Drawing.Point(360, 300);
            this.TotalCrimesAgainstSocietyLabel.Name = "TotalCrimesAgainstSocietyLabel";
            this.TotalCrimesAgainstSocietyLabel.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstSocietyLabel.TabIndex = 5;
            // 
            // TotalCrimesAgainstPropertyLabel
            // 
            this.TotalCrimesAgainstPropertyLabel.AutoSize = true;
            this.TotalCrimesAgainstPropertyLabel.Location = new System.Drawing.Point(363, 180);
            this.TotalCrimesAgainstPropertyLabel.Name = "TotalCrimesAgainstPropertyLabel";
            this.TotalCrimesAgainstPropertyLabel.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstPropertyLabel.TabIndex = 4;
            // 
            // TotalCrimesAgainstPersonsLabel
            // 
            this.TotalCrimesAgainstPersonsLabel.AutoSize = true;
            this.TotalCrimesAgainstPersonsLabel.Location = new System.Drawing.Point(360, 67);
            this.TotalCrimesAgainstPersonsLabel.Name = "TotalCrimesAgainstPersonsLabel";
            this.TotalCrimesAgainstPersonsLabel.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstPersonsLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Reports for Crimes Against Society:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Reports for Crimes Against Property\r\n:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Reports for Crimes Against Persons:\r\n";
            // 
            // CrimesAgainstPersonsTab
            // 
            this.CrimesAgainstPersonsTab.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.CrimesAgainstPersonsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrimesAgainstPersonsTab.Controls.Add(this.TotalCrimesAgainstPersonsTabLabel1);
            this.CrimesAgainstPersonsTab.Controls.Add(this.label4);
            this.CrimesAgainstPersonsTab.Controls.Add(this.PersonsComboBox);
            this.CrimesAgainstPersonsTab.Location = new System.Drawing.Point(4, 25);
            this.CrimesAgainstPersonsTab.Margin = new System.Windows.Forms.Padding(4);
            this.CrimesAgainstPersonsTab.Name = "CrimesAgainstPersonsTab";
            this.CrimesAgainstPersonsTab.Padding = new System.Windows.Forms.Padding(4);
            this.CrimesAgainstPersonsTab.Size = new System.Drawing.Size(1025, 409);
            this.CrimesAgainstPersonsTab.TabIndex = 1;
            this.CrimesAgainstPersonsTab.Text = "Crimes Against Persons";
            this.CrimesAgainstPersonsTab.UseVisualStyleBackColor = true;
            // 
            // TotalCrimesAgainstPersonsTabLabel1
            // 
            this.TotalCrimesAgainstPersonsTabLabel1.AutoSize = true;
            this.TotalCrimesAgainstPersonsTabLabel1.Location = new System.Drawing.Point(185, 92);
            this.TotalCrimesAgainstPersonsTabLabel1.Name = "TotalCrimesAgainstPersonsTabLabel1";
            this.TotalCrimesAgainstPersonsTabLabel1.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstPersonsTabLabel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Number: ";
            // 
            // PersonsComboBox
            // 
            this.PersonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonsComboBox.FormattingEnabled = true;
            this.PersonsComboBox.Items.AddRange(new object[] {
            "Assault",
            "Homicide",
            "Human Trafficking",
            "Kidnapping / Abduction",
            "Sex Offenses"});
            this.PersonsComboBox.Location = new System.Drawing.Point(9, 9);
            this.PersonsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PersonsComboBox.Name = "PersonsComboBox";
            this.PersonsComboBox.Size = new System.Drawing.Size(160, 24);
            this.PersonsComboBox.TabIndex = 0;
            this.PersonsComboBox.SelectedIndexChanged += new System.EventHandler(this.PersonsComboBox_SelectedIndexChanged);
            // 
            // CrimesAgainstPropertyTab
            // 
            this.CrimesAgainstPropertyTab.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.CrimesAgainstPropertyTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrimesAgainstPropertyTab.Controls.Add(this.TotalCrimesAgainstPropertyTabLabel1);
            this.CrimesAgainstPropertyTab.Controls.Add(this.label5);
            this.CrimesAgainstPropertyTab.Controls.Add(this.PropertyComboBox);
            this.CrimesAgainstPropertyTab.Location = new System.Drawing.Point(4, 25);
            this.CrimesAgainstPropertyTab.Margin = new System.Windows.Forms.Padding(4);
            this.CrimesAgainstPropertyTab.Name = "CrimesAgainstPropertyTab";
            this.CrimesAgainstPropertyTab.Size = new System.Drawing.Size(1025, 409);
            this.CrimesAgainstPropertyTab.TabIndex = 2;
            this.CrimesAgainstPropertyTab.Text = "Crimes Against Property";
            this.CrimesAgainstPropertyTab.UseVisualStyleBackColor = true;
            // 
            // TotalCrimesAgainstPropertyTabLabel1
            // 
            this.TotalCrimesAgainstPropertyTabLabel1.AutoSize = true;
            this.TotalCrimesAgainstPropertyTabLabel1.Location = new System.Drawing.Point(170, 93);
            this.TotalCrimesAgainstPropertyTabLabel1.Name = "TotalCrimesAgainstPropertyTabLabel1";
            this.TotalCrimesAgainstPropertyTabLabel1.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstPropertyTabLabel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Number: ";
            // 
            // PropertyComboBox
            // 
            this.PropertyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropertyComboBox.FormattingEnabled = true;
            this.PropertyComboBox.Items.AddRange(new object[] {
            "Arson",
            "Bribery",
            "Burglary / Breaking & Entering",
            "Counterfeiting / Forgery",
            "Destruction / Damage / Vandalism",
            "Embezzlement",
            "Extortion / Blackmail",
            "Fraud",
            "Larceny / Theft",
            "Motor Vehicle Theft",
            "Robbery",
            "Stolen Property"});
            this.PropertyComboBox.Location = new System.Drawing.Point(4, 4);
            this.PropertyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.PropertyComboBox.Name = "PropertyComboBox";
            this.PropertyComboBox.Size = new System.Drawing.Size(160, 24);
            this.PropertyComboBox.TabIndex = 0;
            this.PropertyComboBox.SelectedIndexChanged += new System.EventHandler(this.PropertyComboBox_SelectedIndexChanged);
            // 
            // CrimesAgainstSocietyTab
            // 
            this.CrimesAgainstSocietyTab.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.CrimesAgainstSocietyTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrimesAgainstSocietyTab.Controls.Add(this.TotalCrimesAgainstSocietyTabLabel1);
            this.CrimesAgainstSocietyTab.Controls.Add(this.label6);
            this.CrimesAgainstSocietyTab.Controls.Add(this.SocietyComboBox);
            this.CrimesAgainstSocietyTab.Location = new System.Drawing.Point(4, 25);
            this.CrimesAgainstSocietyTab.Margin = new System.Windows.Forms.Padding(4);
            this.CrimesAgainstSocietyTab.Name = "CrimesAgainstSocietyTab";
            this.CrimesAgainstSocietyTab.Size = new System.Drawing.Size(1025, 409);
            this.CrimesAgainstSocietyTab.TabIndex = 3;
            this.CrimesAgainstSocietyTab.Text = "Crimes Against Society";
            this.CrimesAgainstSocietyTab.UseVisualStyleBackColor = true;
            // 
            // TotalCrimesAgainstSocietyTabLabel1
            // 
            this.TotalCrimesAgainstSocietyTabLabel1.AutoSize = true;
            this.TotalCrimesAgainstSocietyTabLabel1.Location = new System.Drawing.Point(171, 91);
            this.TotalCrimesAgainstSocietyTabLabel1.Name = "TotalCrimesAgainstSocietyTabLabel1";
            this.TotalCrimesAgainstSocietyTabLabel1.Size = new System.Drawing.Size(0, 17);
            this.TotalCrimesAgainstSocietyTabLabel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Number: ";
            // 
            // SocietyComboBox
            // 
            this.SocietyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SocietyComboBox.FormattingEnabled = true;
            this.SocietyComboBox.Items.AddRange(new object[] {
            "Animal Cruelty",
            "Drug / Narcotics",
            "Gambling",
            "Pornography / Obscene Material",
            "Prostitution",
            "Weapon Law Violations"});
            this.SocietyComboBox.Location = new System.Drawing.Point(5, 5);
            this.SocietyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SocietyComboBox.Name = "SocietyComboBox";
            this.SocietyComboBox.Size = new System.Drawing.Size(160, 24);
            this.SocietyComboBox.TabIndex = 0;
            this.SocietyComboBox.SelectedIndexChanged += new System.EventHandler(this.SocietyComboBox_SelectedIndexChanged);
            // 
            // FormHeading
            // 
            this.FormHeading.AutoSize = true;
            this.FormHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormHeading.Location = new System.Drawing.Point(371, -2);
            this.FormHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormHeading.Name = "FormHeading";
            this.FormHeading.Size = new System.Drawing.Size(316, 58);
            this.FormHeading.TabIndex = 1;
            this.FormHeading.Text = "US Overview";
            // 
            // continueFBIUSView
            // 
            this.continueFBIUSView.Location = new System.Drawing.Point(915, 499);
            this.continueFBIUSView.Margin = new System.Windows.Forms.Padding(4);
            this.continueFBIUSView.Name = "continueFBIUSView";
            this.continueFBIUSView.Size = new System.Drawing.Size(135, 42);
            this.continueFBIUSView.TabIndex = 2;
            this.continueFBIUSView.Text = "Continue";
            this.continueFBIUSView.UseVisualStyleBackColor = true;
            this.continueFBIUSView.Click += new System.EventHandler(this.continueFBIUSView_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NewOrderDesign.Properties.Resources.BackButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(17, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // USOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.continueFBIUSView);
            this.Controls.Add(this.FormHeading);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "USOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrimeSight";
            this.Load += new System.EventHandler(this.USOverview_Load);
            this.tabControl1.ResumeLayout(false);
            this.OverviewTab.ResumeLayout(false);
            this.OverviewTab.PerformLayout();
            this.CrimesAgainstPersonsTab.ResumeLayout(false);
            this.CrimesAgainstPersonsTab.PerformLayout();
            this.CrimesAgainstPropertyTab.ResumeLayout(false);
            this.CrimesAgainstPropertyTab.PerformLayout();
            this.CrimesAgainstSocietyTab.ResumeLayout(false);
            this.CrimesAgainstSocietyTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OverviewTab;
        private System.Windows.Forms.TabPage CrimesAgainstPersonsTab;
        private System.Windows.Forms.TabPage CrimesAgainstPropertyTab;
        private System.Windows.Forms.TabPage CrimesAgainstSocietyTab;
        private System.Windows.Forms.Label FormHeading;
        private System.Windows.Forms.ComboBox PersonsComboBox;
        private System.Windows.Forms.ComboBox PropertyComboBox;
        private System.Windows.Forms.ComboBox SocietyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalCrimesAgainstSocietyLabel;
        private System.Windows.Forms.Label TotalCrimesAgainstPropertyLabel;
        private System.Windows.Forms.Label TotalCrimesAgainstPersonsLabel;
        private System.Windows.Forms.Label TotalCrimesAgainstPersonsTabLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button continueFBIUSView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TotalCrimesAgainstPropertyTabLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalCrimesAgainstSocietyTabLabel1;
        private System.Windows.Forms.Label label6;
    }
}