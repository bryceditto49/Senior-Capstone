
namespace NewOrderDesign
{
    partial class CovidStateData
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedcasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet3 = new NewOrderDesign.CovidDataDataSet3();
            this.statesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet1 = new NewOrderDesign.CovidDataDataSet1();
            this.statesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet = new NewOrderDesign.CovidDataDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataNYTDataSet = new NewOrderDesign.CovidDataNYTDataSet();
            this.statesTableAdapter = new NewOrderDesign.CovidDataNYTDataSetTableAdapters.statesTableAdapter();
            this.statesTableAdapter1 = new NewOrderDesign.CovidDataDataSetTableAdapters.statesTableAdapter();
            this.statesTableAdapter2 = new NewOrderDesign.CovidDataDataSet1TableAdapters.statesTableAdapter();
            this.statesTableAdapter3 = new NewOrderDesign.CovidDataDataSet3TableAdapters.statesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.covidDataDataSet4 = new NewOrderDesign.CovidDataDataSet4();
            this.statesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter4 = new NewOrderDesign.CovidDataDataSet4TableAdapters.statesTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataNYTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(94, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Enter a U.S. State";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitbutton.Location = new System.Drawing.Point(497, 44);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(77, 38);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "Go";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "data will be represented here in table format";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(951, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "View More";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.statenameDataGridViewTextBoxColumn,
            this.confirmedcasesDataGridViewTextBoxColumn,
            this.deathsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statesBindingSource4;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 302);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // statesBindingSource3
            // 
            this.statesBindingSource3.DataMember = "states";
            this.statesBindingSource3.DataSource = this.covidDataDataSet3;
            // 
            // covidDataDataSet3
            // 
            this.covidDataDataSet3.DataSetName = "CovidDataDataSet3";
            this.covidDataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource2
            // 
            this.statesBindingSource2.DataMember = "states";
            this.statesBindingSource2.DataSource = this.covidDataDataSet1;
            // 
            // covidDataDataSet1
            // 
            this.covidDataDataSet1.DataSetName = "CovidDataDataSet1";
            this.covidDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource1
            // 
            this.statesBindingSource1.DataMember = "states";
            this.statesBindingSource1.DataSource = this.covidDataDataSet;
            // 
            // covidDataDataSet
            // 
            this.covidDataDataSet.DataSetName = "CovidDataDataSet";
            this.covidDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "states";
            this.statesBindingSource.DataSource = this.covidDataNYTDataSet;
            // 
            // covidDataNYTDataSet
            // 
            this.covidDataNYTDataSet.DataSetName = "CovidDataNYTDataSet";
            this.covidDataNYTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // statesTableAdapter1
            // 
            this.statesTableAdapter1.ClearBeforeFill = true;
            // 
            // statesTableAdapter2
            // 
            this.statesTableAdapter2.ClearBeforeFill = true;
            // 
            // statesTableAdapter3
            // 
            this.statesTableAdapter3.ClearBeforeFill = true;
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
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // covidDataDataSet4
            // 
            this.covidDataDataSet4.DataSetName = "CovidDataDataSet4";
            this.covidDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource4
            // 
            this.statesBindingSource4.DataMember = "states";
            this.statesBindingSource4.DataSource = this.covidDataDataSet4;
            // 
            // statesTableAdapter4
            // 
            this.statesTableAdapter4.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(603, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "1 Week\r\n";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(716, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "2 Weeks";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(842, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 28);
            this.button5.TabIndex = 13;
            this.button5.Text = "3 Weeks";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // CovidStateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CovidStateData";
            this.Text = "COVID-19 Data";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataNYTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CovidDataNYTDataSet covidDataNYTDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private CovidDataNYTDataSetTableAdapters.statesTableAdapter statesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmedcasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathsDataGridViewTextBoxColumn;
        private CovidDataDataSet covidDataDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource1;
        private CovidDataDataSetTableAdapters.statesTableAdapter statesTableAdapter1;
        private CovidDataDataSet1 covidDataDataSet1;
        private System.Windows.Forms.BindingSource statesBindingSource2;
        private CovidDataDataSet1TableAdapters.statesTableAdapter statesTableAdapter2;
        private CovidDataDataSet3 covidDataDataSet3;
        private System.Windows.Forms.BindingSource statesBindingSource3;
        private CovidDataDataSet3TableAdapters.statesTableAdapter statesTableAdapter3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private CovidDataDataSet4 covidDataDataSet4;
        private System.Windows.Forms.BindingSource statesBindingSource4;
        private CovidDataDataSet4TableAdapters.statesTableAdapter statesTableAdapter4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}