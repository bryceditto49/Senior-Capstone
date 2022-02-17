
namespace NewOrderDesign
{
    partial class FBIStateDashboard
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationCoveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assaultOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homicideOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humanTraffickingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidnappingAbductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fBIDataSet1 = new NewOrderDesign.FBIDataSet1();
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fBIDataSet = new NewOrderDesign.FBIDataSet();
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter = new NewOrderDesign.FBIDataSetTableAdapters.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter();
            this.fBIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1 = new NewOrderDesign.FBIDataSet1TableAdapters.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Enter a U.S. State";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.Location = new System.Drawing.Point(473, 13);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(69, 38);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "Go";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(951, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "View More";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1033, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "fbi state level data will be presented here, on the view more page, users will ha" +
    "ve the ability to narrow a search as well be presented data in a more meaningful" +
    " way";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateDataGridViewTextBoxColumn,
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn,
            this.populationCoveredDataGridViewTextBoxColumn,
            this.totalOffensesDataGridViewTextBoxColumn,
            this.assaultOffensesDataGridViewTextBoxColumn,
            this.homicideOffensesDataGridViewTextBoxColumn,
            this.humanTraffickingDataGridViewTextBoxColumn,
            this.kidnappingAbductionDataGridViewTextBoxColumn,
            this.sexOffensesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 335);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofParticipatingAgenciesDataGridViewTextBoxColumn
            // 
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Participating_Agencies";
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.HeaderText = "Number_of_Participating_Agencies";
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.Name = "numberofParticipatingAgenciesDataGridViewTextBoxColumn";
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationCoveredDataGridViewTextBoxColumn
            // 
            this.populationCoveredDataGridViewTextBoxColumn.DataPropertyName = "Population_Covered";
            this.populationCoveredDataGridViewTextBoxColumn.HeaderText = "Population_Covered";
            this.populationCoveredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationCoveredDataGridViewTextBoxColumn.Name = "populationCoveredDataGridViewTextBoxColumn";
            this.populationCoveredDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalOffensesDataGridViewTextBoxColumn
            // 
            this.totalOffensesDataGridViewTextBoxColumn.DataPropertyName = "Total_Offenses";
            this.totalOffensesDataGridViewTextBoxColumn.HeaderText = "Total_Offenses";
            this.totalOffensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOffensesDataGridViewTextBoxColumn.Name = "totalOffensesDataGridViewTextBoxColumn";
            this.totalOffensesDataGridViewTextBoxColumn.Width = 125;
            // 
            // assaultOffensesDataGridViewTextBoxColumn
            // 
            this.assaultOffensesDataGridViewTextBoxColumn.DataPropertyName = "Assault_Offenses";
            this.assaultOffensesDataGridViewTextBoxColumn.HeaderText = "Assault_Offenses";
            this.assaultOffensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assaultOffensesDataGridViewTextBoxColumn.Name = "assaultOffensesDataGridViewTextBoxColumn";
            this.assaultOffensesDataGridViewTextBoxColumn.Width = 125;
            // 
            // homicideOffensesDataGridViewTextBoxColumn
            // 
            this.homicideOffensesDataGridViewTextBoxColumn.DataPropertyName = "Homicide_Offenses";
            this.homicideOffensesDataGridViewTextBoxColumn.HeaderText = "Homicide_Offenses";
            this.homicideOffensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homicideOffensesDataGridViewTextBoxColumn.Name = "homicideOffensesDataGridViewTextBoxColumn";
            this.homicideOffensesDataGridViewTextBoxColumn.Width = 125;
            // 
            // humanTraffickingDataGridViewTextBoxColumn
            // 
            this.humanTraffickingDataGridViewTextBoxColumn.DataPropertyName = "Human_Trafficking";
            this.humanTraffickingDataGridViewTextBoxColumn.HeaderText = "Human_Trafficking";
            this.humanTraffickingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.humanTraffickingDataGridViewTextBoxColumn.Name = "humanTraffickingDataGridViewTextBoxColumn";
            this.humanTraffickingDataGridViewTextBoxColumn.Width = 125;
            // 
            // kidnappingAbductionDataGridViewTextBoxColumn
            // 
            this.kidnappingAbductionDataGridViewTextBoxColumn.DataPropertyName = "Kidnapping_Abduction";
            this.kidnappingAbductionDataGridViewTextBoxColumn.HeaderText = "Kidnapping_Abduction";
            this.kidnappingAbductionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kidnappingAbductionDataGridViewTextBoxColumn.Name = "kidnappingAbductionDataGridViewTextBoxColumn";
            this.kidnappingAbductionDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexOffensesDataGridViewTextBoxColumn
            // 
            this.sexOffensesDataGridViewTextBoxColumn.DataPropertyName = "Sex_Offenses";
            this.sexOffensesDataGridViewTextBoxColumn.HeaderText = "Sex_Offenses";
            this.sexOffensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexOffensesDataGridViewTextBoxColumn.Name = "sexOffensesDataGridViewTextBoxColumn";
            this.sexOffensesDataGridViewTextBoxColumn.Width = 125;
            // 
            // crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1
            // 
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1.DataMember = "Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020";
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1.DataSource = this.fBIDataSet1;
            // 
            // fBIDataSet1
            // 
            this.fBIDataSet1.DataSetName = "FBIDataSet1";
            this.fBIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource
            // 
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource.DataMember = "Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020";
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource.DataSource = this.fBIDataSet;
            // 
            // fBIDataSet
            // 
            this.fBIDataSet.DataSetName = "FBIDataSet";
            this.fBIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter
            // 
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter.ClearBeforeFill = true;
            // 
            // fBIDataSetBindingSource
            // 
            this.fBIDataSetBindingSource.DataSource = this.fBIDataSet;
            this.fBIDataSetBindingSource.Position = 0;
            // 
            // crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1
            // 
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NewOrderDesign.Properties.Resources.BackButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 47);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FBIStateDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBIStateDashboard";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FBIDataSet fBIDataSet;
        private System.Windows.Forms.BindingSource crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource;
        private FBIDataSetTableAdapters.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter;
        private System.Windows.Forms.BindingSource fBIDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofParticipatingAgenciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationCoveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assaultOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homicideOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humanTraffickingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidnappingAbductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexOffensesDataGridViewTextBoxColumn;
        private FBIDataSet1 fBIDataSet1;
        private System.Windows.Forms.BindingSource crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource1;
        private FBIDataSet1TableAdapters.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter1;
        private System.Windows.Forms.Button button2;
    }
}