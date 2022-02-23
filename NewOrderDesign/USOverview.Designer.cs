
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OverviewTab = new System.Windows.Forms.TabPage();
            this.CrimesAgainstPersonsTab = new System.Windows.Forms.TabPage();
            this.FormHeading = new System.Windows.Forms.Label();
            this.CrimesAgainstPropertyTab = new System.Windows.Forms.TabPage();
            this.CrimesAgainstSocietyTab = new System.Windows.Forms.TabPage();
            this.PersonsComboBox = new System.Windows.Forms.ComboBox();
            this.PropertyComboBox = new System.Windows.Forms.ComboBox();
            this.SocietyComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(13, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // OverviewTab
            // 
            this.OverviewTab.Location = new System.Drawing.Point(4, 22);
            this.OverviewTab.Name = "OverviewTab";
            this.OverviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.OverviewTab.Size = new System.Drawing.Size(767, 365);
            this.OverviewTab.TabIndex = 0;
            this.OverviewTab.Text = "Overview";
            this.OverviewTab.UseVisualStyleBackColor = true;
            // 
            // CrimesAgainstPersonsTab
            // 
            this.CrimesAgainstPersonsTab.Controls.Add(this.PersonsComboBox);
            this.CrimesAgainstPersonsTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstPersonsTab.Name = "CrimesAgainstPersonsTab";
            this.CrimesAgainstPersonsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CrimesAgainstPersonsTab.Size = new System.Drawing.Size(767, 365);
            this.CrimesAgainstPersonsTab.TabIndex = 1;
            this.CrimesAgainstPersonsTab.Text = "Crimes Against Persons";
            this.CrimesAgainstPersonsTab.UseVisualStyleBackColor = true;
            // 
            // FormHeading
            // 
            this.FormHeading.AutoSize = true;
            this.FormHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormHeading.Location = new System.Drawing.Point(278, -2);
            this.FormHeading.Name = "FormHeading";
            this.FormHeading.Size = new System.Drawing.Size(251, 46);
            this.FormHeading.TabIndex = 1;
            this.FormHeading.Text = "US Overview";
            // 
            // CrimesAgainstPropertyTab
            // 
            this.CrimesAgainstPropertyTab.Controls.Add(this.PropertyComboBox);
            this.CrimesAgainstPropertyTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstPropertyTab.Name = "CrimesAgainstPropertyTab";
            this.CrimesAgainstPropertyTab.Size = new System.Drawing.Size(767, 365);
            this.CrimesAgainstPropertyTab.TabIndex = 2;
            this.CrimesAgainstPropertyTab.Text = "Crimes Against Property";
            this.CrimesAgainstPropertyTab.UseVisualStyleBackColor = true;
            // 
            // CrimesAgainstSocietyTab
            // 
            this.CrimesAgainstSocietyTab.Controls.Add(this.SocietyComboBox);
            this.CrimesAgainstSocietyTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstSocietyTab.Name = "CrimesAgainstSocietyTab";
            this.CrimesAgainstSocietyTab.Size = new System.Drawing.Size(767, 365);
            this.CrimesAgainstSocietyTab.TabIndex = 3;
            this.CrimesAgainstSocietyTab.Text = "Crimes Against Society";
            this.CrimesAgainstSocietyTab.UseVisualStyleBackColor = true;
            // 
            // PersonsComboBox
            // 
            this.PersonsComboBox.FormattingEnabled = true;
            this.PersonsComboBox.Items.AddRange(new object[] {
            "Assault",
            "Homicide",
            "Human Trafficking",
            "Kidnapping / Abduction",
            "Sex Offenses"});
            this.PersonsComboBox.Location = new System.Drawing.Point(7, 7);
            this.PersonsComboBox.Name = "PersonsComboBox";
            this.PersonsComboBox.Size = new System.Drawing.Size(121, 21);
            this.PersonsComboBox.TabIndex = 0;
            // 
            // PropertyComboBox
            // 
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
            this.PropertyComboBox.Location = new System.Drawing.Point(3, 3);
            this.PropertyComboBox.Name = "PropertyComboBox";
            this.PropertyComboBox.Size = new System.Drawing.Size(121, 21);
            this.PropertyComboBox.TabIndex = 0;
            // 
            // SocietyComboBox
            // 
            this.SocietyComboBox.FormattingEnabled = true;
            this.SocietyComboBox.Items.AddRange(new object[] {
            "Animal Cruelty",
            "Drug / Narcotics",
            "Gambling",
            "Pornography / Obscene Material",
            "Prostitution",
            "Weapon Law Violations"});
            this.SocietyComboBox.Location = new System.Drawing.Point(4, 4);
            this.SocietyComboBox.Name = "SocietyComboBox";
            this.SocietyComboBox.Size = new System.Drawing.Size(121, 21);
            this.SocietyComboBox.TabIndex = 0;
            // 
            // USOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FormHeading);
            this.Controls.Add(this.tabControl1);
            this.Name = "USOverview";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.CrimesAgainstPersonsTab.ResumeLayout(false);
            this.CrimesAgainstPropertyTab.ResumeLayout(false);
            this.CrimesAgainstSocietyTab.ResumeLayout(false);
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
    }
}