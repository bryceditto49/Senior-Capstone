
namespace NewOrderDesign
{
    partial class FBIUSView
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
            this.continueFBIUSView = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrimesAgainstPersonTab = new System.Windows.Forms.TabPage();
            this.StatesWithMostOffensesTextBox = new System.Windows.Forms.TextBox();
            this.PercofTotalCrimesTextBox = new System.Windows.Forms.TextBox();
            this.PersonsDefaultTotalNumber = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CrimesAgainstPersonsComboBox = new System.Windows.Forms.ComboBox();
            this.CrimesAgainstPropertyTab = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.CrimesAgainstPropertyComboBox = new System.Windows.Forms.ComboBox();
            this.CrimesAgainstSocietyTab = new System.Windows.Forms.TabPage();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.CrimesAgainstSocietyComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.CrimesAgainstPersonTab.SuspendLayout();
            this.CrimesAgainstPropertyTab.SuspendLayout();
            this.CrimesAgainstSocietyTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // continueFBIUSView
            // 
            this.continueFBIUSView.Location = new System.Drawing.Point(687, 404);
            this.continueFBIUSView.Name = "continueFBIUSView";
            this.continueFBIUSView.Size = new System.Drawing.Size(101, 34);
            this.continueFBIUSView.TabIndex = 0;
            this.continueFBIUSView.Text = "Continue";
            this.continueFBIUSView.UseVisualStyleBackColor = true;
            this.continueFBIUSView.Click += new System.EventHandler(this.continueFBIUSView_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "US Overview";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NewOrderDesign.Properties.Resources.BackButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(9, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 38);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CrimesAgainstPersonTab);
            this.tabControl1.Controls.Add(this.CrimesAgainstPropertyTab);
            this.tabControl1.Controls.Add(this.CrimesAgainstSocietyTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 345);
            this.tabControl1.TabIndex = 12;
            // 
            // CrimesAgainstPersonTab
            // 
            this.CrimesAgainstPersonTab.Controls.Add(this.StatesWithMostOffensesTextBox);
            this.CrimesAgainstPersonTab.Controls.Add(this.PercofTotalCrimesTextBox);
            this.CrimesAgainstPersonTab.Controls.Add(this.PersonsDefaultTotalNumber);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox9);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox8);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox7);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox6);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox5);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox4);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox3);
            this.CrimesAgainstPersonTab.Controls.Add(this.textBox2);
            this.CrimesAgainstPersonTab.Controls.Add(this.CrimesAgainstPersonsComboBox);
            this.CrimesAgainstPersonTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstPersonTab.Name = "CrimesAgainstPersonTab";
            this.CrimesAgainstPersonTab.Padding = new System.Windows.Forms.Padding(3);
            this.CrimesAgainstPersonTab.Size = new System.Drawing.Size(771, 319);
            this.CrimesAgainstPersonTab.TabIndex = 0;
            this.CrimesAgainstPersonTab.Text = "Persons";
            this.CrimesAgainstPersonTab.UseVisualStyleBackColor = true;
            this.CrimesAgainstPersonTab.Click += new System.EventHandler(this.CrimesAgainstPersonTab_Click);
            // 
            // StatesWithMostOffensesTextBox
            // 
            this.StatesWithMostOffensesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatesWithMostOffensesTextBox.Location = new System.Drawing.Point(476, 128);
            this.StatesWithMostOffensesTextBox.Name = "StatesWithMostOffensesTextBox";
            this.StatesWithMostOffensesTextBox.Size = new System.Drawing.Size(100, 13);
            this.StatesWithMostOffensesTextBox.TabIndex = 19;
            this.StatesWithMostOffensesTextBox.TextChanged += new System.EventHandler(this.StatesWithMostOffensesTextBox_TextChanged);
            // 
            // PercofTotalCrimesTextBox
            // 
            this.PercofTotalCrimesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PercofTotalCrimesTextBox.Location = new System.Drawing.Point(665, 47);
            this.PercofTotalCrimesTextBox.Name = "PercofTotalCrimesTextBox";
            this.PercofTotalCrimesTextBox.Size = new System.Drawing.Size(100, 13);
            this.PercofTotalCrimesTextBox.TabIndex = 18;
            this.PercofTotalCrimesTextBox.TextChanged += new System.EventHandler(this.PercofTotalCrimesTextBox_TextChanged);
            // 
            // PersonsDefaultTotalNumber
            // 
            this.PersonsDefaultTotalNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonsDefaultTotalNumber.Location = new System.Drawing.Point(139, 46);
            this.PersonsDefaultTotalNumber.Name = "PersonsDefaultTotalNumber";
            this.PersonsDefaultTotalNumber.Size = new System.Drawing.Size(100, 13);
            this.PersonsDefaultTotalNumber.TabIndex = 17;
            this.PersonsDefaultTotalNumber.TextChanged += new System.EventHandler(this.PersonsDefaultTotalNumber_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(609, 259);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(85, 19);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "North:";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(422, 259);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(85, 19);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "South:";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(257, 259);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(85, 19);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Midwest:";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(76, 259);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(57, 19);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "West:";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(76, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(163, 19);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "Region Breakdown:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(257, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 19);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "State with most Offenses:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(510, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 19);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "% of Total Crimes:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(76, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 19);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Total #:";
            // 
            // CrimesAgainstPersonsComboBox
            // 
            this.CrimesAgainstPersonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrimesAgainstPersonsComboBox.FormattingEnabled = true;
            this.CrimesAgainstPersonsComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CrimesAgainstPersonsComboBox.Items.AddRange(new object[] {
            "Assault",
            "Homicide",
            "Human Trafficking",
            "Kindnapping/Abduction",
            "Sex Offenses"});
            this.CrimesAgainstPersonsComboBox.Location = new System.Drawing.Point(6, 6);
            this.CrimesAgainstPersonsComboBox.Name = "CrimesAgainstPersonsComboBox";
            this.CrimesAgainstPersonsComboBox.Size = new System.Drawing.Size(138, 21);
            this.CrimesAgainstPersonsComboBox.TabIndex = 0;
            this.CrimesAgainstPersonsComboBox.SelectedIndexChanged += new System.EventHandler(this.CrimesAgainstPersonsComboBox_SelectedIndexChanged);
            // 
            // CrimesAgainstPropertyTab
            // 
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox10);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox11);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox12);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox13);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox14);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox15);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox16);
            this.CrimesAgainstPropertyTab.Controls.Add(this.textBox17);
            this.CrimesAgainstPropertyTab.Controls.Add(this.CrimesAgainstPropertyComboBox);
            this.CrimesAgainstPropertyTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstPropertyTab.Name = "CrimesAgainstPropertyTab";
            this.CrimesAgainstPropertyTab.Padding = new System.Windows.Forms.Padding(3);
            this.CrimesAgainstPropertyTab.Size = new System.Drawing.Size(771, 319);
            this.CrimesAgainstPropertyTab.TabIndex = 1;
            this.CrimesAgainstPropertyTab.Text = "Property";
            this.CrimesAgainstPropertyTab.UseVisualStyleBackColor = true;
            this.CrimesAgainstPropertyTab.Click += new System.EventHandler(this.CrimesAgainstPropertyTab_Click);
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(609, 259);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(85, 19);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "North:";
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(422, 259);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(85, 19);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "South:";
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(257, 259);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(85, 19);
            this.textBox12.TabIndex = 14;
            this.textBox12.Text = "Midwest:";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(76, 259);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(57, 19);
            this.textBox13.TabIndex = 13;
            this.textBox13.Text = "West:";
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(76, 220);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(163, 19);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = "Region Breakdown:";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(257, 123);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(213, 19);
            this.textBox15.TabIndex = 11;
            this.textBox15.Text = "State with most Offenses:";
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(510, 41);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(166, 19);
            this.textBox16.TabIndex = 10;
            this.textBox16.Text = "% of Total Crimes:";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(76, 41);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(85, 19);
            this.textBox17.TabIndex = 9;
            this.textBox17.Text = "Total #:";
            // 
            // CrimesAgainstPropertyComboBox
            // 
            this.CrimesAgainstPropertyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrimesAgainstPropertyComboBox.FormattingEnabled = true;
            this.CrimesAgainstPropertyComboBox.Items.AddRange(new object[] {
            "Arson",
            "Bribery",
            "Burglary/Breaking&Entering",
            "Counterfeiting",
            "Destruction/Damage/Vandalism",
            "Embezzlement",
            "Extortion/Blackmail",
            "Fraud",
            "Larceny",
            "Motor Vehicle Theft",
            "Robbery",
            "Stolen Property"});
            this.CrimesAgainstPropertyComboBox.Location = new System.Drawing.Point(6, 6);
            this.CrimesAgainstPropertyComboBox.Name = "CrimesAgainstPropertyComboBox";
            this.CrimesAgainstPropertyComboBox.Size = new System.Drawing.Size(139, 21);
            this.CrimesAgainstPropertyComboBox.TabIndex = 0;
            this.CrimesAgainstPropertyComboBox.SelectedIndexChanged += new System.EventHandler(this.CrimesAgainstPropertyComboBox_SelectedIndexChanged);
            // 
            // CrimesAgainstSocietyTab
            // 
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox18);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox19);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox20);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox21);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox22);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox23);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox24);
            this.CrimesAgainstSocietyTab.Controls.Add(this.textBox25);
            this.CrimesAgainstSocietyTab.Controls.Add(this.CrimesAgainstSocietyComboBox);
            this.CrimesAgainstSocietyTab.Location = new System.Drawing.Point(4, 22);
            this.CrimesAgainstSocietyTab.Name = "CrimesAgainstSocietyTab";
            this.CrimesAgainstSocietyTab.Size = new System.Drawing.Size(771, 319);
            this.CrimesAgainstSocietyTab.TabIndex = 2;
            this.CrimesAgainstSocietyTab.Text = "Society";
            this.CrimesAgainstSocietyTab.UseVisualStyleBackColor = true;
            this.CrimesAgainstSocietyTab.Click += new System.EventHandler(this.CrimesAgainstSocietyTab_Click);
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(609, 259);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(85, 19);
            this.textBox18.TabIndex = 16;
            this.textBox18.Text = "North:";
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(422, 259);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(85, 19);
            this.textBox19.TabIndex = 15;
            this.textBox19.Text = "South:";
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(257, 259);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(85, 19);
            this.textBox20.TabIndex = 14;
            this.textBox20.Text = "Midwest:";
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(76, 259);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(57, 19);
            this.textBox21.TabIndex = 13;
            this.textBox21.Text = "West:";
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(76, 220);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(163, 19);
            this.textBox22.TabIndex = 12;
            this.textBox22.Text = "Region Breakdown:";
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(257, 123);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(213, 19);
            this.textBox23.TabIndex = 11;
            this.textBox23.Text = "State with most Offenses:";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(510, 41);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(166, 19);
            this.textBox24.TabIndex = 10;
            this.textBox24.Text = "% of Total Crimes:";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(76, 41);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(85, 19);
            this.textBox25.TabIndex = 9;
            this.textBox25.Text = "Total #:";
            // 
            // CrimesAgainstSocietyComboBox
            // 
            this.CrimesAgainstSocietyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CrimesAgainstSocietyComboBox.FormattingEnabled = true;
            this.CrimesAgainstSocietyComboBox.Items.AddRange(new object[] {
            "Animal Cruelty",
            "Drug/Narcotic Offenses",
            "Gambling",
            "Pornography/Obscene Material",
            "Prostitution",
            "Weapon Law Violations"});
            this.CrimesAgainstSocietyComboBox.Location = new System.Drawing.Point(3, 3);
            this.CrimesAgainstSocietyComboBox.Name = "CrimesAgainstSocietyComboBox";
            this.CrimesAgainstSocietyComboBox.Size = new System.Drawing.Size(145, 21);
            this.CrimesAgainstSocietyComboBox.TabIndex = 0;
            this.CrimesAgainstSocietyComboBox.SelectedIndexChanged += new System.EventHandler(this.CrimesAgainstSocietyComboBox_SelectedIndexChanged);
            // 
            // FBIUSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.continueFBIUSView);
            this.Name = "FBIUSView";
            this.Text = "Form5";
            this.tabControl1.ResumeLayout(false);
            this.CrimesAgainstPersonTab.ResumeLayout(false);
            this.CrimesAgainstPersonTab.PerformLayout();
            this.CrimesAgainstPropertyTab.ResumeLayout(false);
            this.CrimesAgainstPropertyTab.PerformLayout();
            this.CrimesAgainstSocietyTab.ResumeLayout(false);
            this.CrimesAgainstSocietyTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueFBIUSView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrimesAgainstPropertyTab;
        private System.Windows.Forms.ComboBox CrimesAgainstPropertyComboBox;
        private System.Windows.Forms.TabPage CrimesAgainstSocietyTab;
        private System.Windows.Forms.ComboBox CrimesAgainstSocietyComboBox;
        private System.Windows.Forms.TabPage CrimesAgainstPersonTab;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox CrimesAgainstPersonsComboBox;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox PersonsDefaultTotalNumber;
        private System.Windows.Forms.TextBox StatesWithMostOffensesTextBox;
        private System.Windows.Forms.TextBox PercofTotalCrimesTextBox;
    }
}