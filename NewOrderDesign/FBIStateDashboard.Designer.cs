
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
            this.fBIDataSet = new NewOrderDesign.FBIDataSet();
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter = new NewOrderDesign.FBIDataSetTableAdapters.Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationCoveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assaultOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homicideOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humanTraffickingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kidnappingAbductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexOffensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Enter a U.S. State";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.Location = new System.Drawing.Point(287, 12);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(52, 31);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "Go";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(713, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View More";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 13);
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
            this.dataGridView1.DataSource = this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 272);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fBIDataSet
            // 
            this.fBIDataSet.DataSetName = "FBIDataSet";
            this.fBIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource
            // 
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource.DataMember = "Crimes_Against_Persons_Offenses_Offense_Category_by_State_2020";
            this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource.DataSource = this.fBIDataSet;
            // 
            // crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter
            // 
            this.crimes_Against_Persons_Offenses_Offense_Category_by_State_2020TableAdapter.ClearBeforeFill = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // numberofParticipatingAgenciesDataGridViewTextBoxColumn
            // 
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Participating_Agencies";
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.HeaderText = "Number_of_Participating_Agencies";
            this.numberofParticipatingAgenciesDataGridViewTextBoxColumn.Name = "numberofParticipatingAgenciesDataGridViewTextBoxColumn";
            // 
            // populationCoveredDataGridViewTextBoxColumn
            // 
            this.populationCoveredDataGridViewTextBoxColumn.DataPropertyName = "Population_Covered";
            this.populationCoveredDataGridViewTextBoxColumn.HeaderText = "Population_Covered";
            this.populationCoveredDataGridViewTextBoxColumn.Name = "populationCoveredDataGridViewTextBoxColumn";
            // 
            // totalOffensesDataGridViewTextBoxColumn
            // 
            this.totalOffensesDataGridViewTextBoxColumn.DataPropertyName = "Total_Offenses";
            this.totalOffensesDataGridViewTextBoxColumn.HeaderText = "Total_Offenses";
            this.totalOffensesDataGridViewTextBoxColumn.Name = "totalOffensesDataGridViewTextBoxColumn";
            // 
            // assaultOffensesDataGridViewTextBoxColumn
            // 
            this.assaultOffensesDataGridViewTextBoxColumn.DataPropertyName = "Assault_Offenses";
            this.assaultOffensesDataGridViewTextBoxColumn.HeaderText = "Assault_Offenses";
            this.assaultOffensesDataGridViewTextBoxColumn.Name = "assaultOffensesDataGridViewTextBoxColumn";
            // 
            // homicideOffensesDataGridViewTextBoxColumn
            // 
            this.homicideOffensesDataGridViewTextBoxColumn.DataPropertyName = "Homicide_Offenses";
            this.homicideOffensesDataGridViewTextBoxColumn.HeaderText = "Homicide_Offenses";
            this.homicideOffensesDataGridViewTextBoxColumn.Name = "homicideOffensesDataGridViewTextBoxColumn";
            // 
            // humanTraffickingDataGridViewTextBoxColumn
            // 
            this.humanTraffickingDataGridViewTextBoxColumn.DataPropertyName = "Human_Trafficking";
            this.humanTraffickingDataGridViewTextBoxColumn.HeaderText = "Human_Trafficking";
            this.humanTraffickingDataGridViewTextBoxColumn.Name = "humanTraffickingDataGridViewTextBoxColumn";
            // 
            // kidnappingAbductionDataGridViewTextBoxColumn
            // 
            this.kidnappingAbductionDataGridViewTextBoxColumn.DataPropertyName = "Kidnapping_Abduction";
            this.kidnappingAbductionDataGridViewTextBoxColumn.HeaderText = "Kidnapping_Abduction";
            this.kidnappingAbductionDataGridViewTextBoxColumn.Name = "kidnappingAbductionDataGridViewTextBoxColumn";
            // 
            // sexOffensesDataGridViewTextBoxColumn
            // 
            this.sexOffensesDataGridViewTextBoxColumn.DataPropertyName = "Sex_Offenses";
            this.sexOffensesDataGridViewTextBoxColumn.HeaderText = "Sex_Offenses";
            this.sexOffensesDataGridViewTextBoxColumn.Name = "sexOffensesDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fBIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crimesAgainstPersonsOffensesOffenseCategorybyState2020BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofParticipatingAgenciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationCoveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assaultOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homicideOffensesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humanTraffickingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kidnappingAbductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexOffensesDataGridViewTextBoxColumn;
    }
}