
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CovidStateData));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedcasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet5 = new NewOrderDesign.CovidDataDataSet5();
            this.statesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.covidDataDataSet4 = new NewOrderDesign.CovidDataDataSet4();
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
            this.statesTableAdapter4 = new NewOrderDesign.CovidDataDataSet4TableAdapters.statesTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statesTableAdapter5 = new NewOrderDesign.CovidDataDataSet5TableAdapters.statesTableAdapter();
            this.Export_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataNYTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Enter a U.S. State";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.submitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitbutton.Location = new System.Drawing.Point(441, 39);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(68, 31);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "Go";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "data will be represented here in table format";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.statenameDataGridViewTextBoxColumn,
            this.confirmedcasesDataGridViewTextBoxColumn,
            this.deathsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statesBindingSource5;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 264);
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
            // statesBindingSource5
            // 
            this.statesBindingSource5.DataMember = "states";
            this.statesBindingSource5.DataSource = this.covidDataDataSet5;
            // 
            // covidDataDataSet5
            // 
            this.covidDataDataSet5.DataSetName = "CovidDataDataSet5";
            this.covidDataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource4
            // 
            this.statesBindingSource4.DataMember = "states";
            this.statesBindingSource4.DataSource = this.covidDataDataSet4;
            // 
            // covidDataDataSet4
            // 
            this.covidDataDataSet4.DataSetName = "CovidDataDataSet4";
            this.covidDataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statesTableAdapter4
            // 
            this.statesTableAdapter4.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(9, 438);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "State with most cases\r\n";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(97, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(449, 16);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Leave search bar empty to show all states, correct spelling of state name require" +
    "d";
            // 
            // statesTableAdapter5
            // 
            this.statesTableAdapter5.ClearBeforeFill = true;
            // 
            // Export_button
            // 
            this.Export_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Export_button.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_button.Location = new System.Drawing.Point(811, 438);
            this.Export_button.Margin = new System.Windows.Forms.Padding(4);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(109, 39);
            this.Export_button.TabIndex = 18;
            this.Export_button.Text = "Export";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click_1);
            // 
            // CovidStateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 492);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(952, 531);
            this.Name = "CovidStateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelSite";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.covidDataNYTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private CovidDataDataSet5 covidDataDataSet5;
        private System.Windows.Forms.BindingSource statesBindingSource5;
        private CovidDataDataSet5TableAdapters.statesTableAdapter statesTableAdapter5;
        private System.Windows.Forms.Button Export_button;
    }
}