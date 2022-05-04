
namespace NewOrderDesign
{
    partial class DataSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSelection));
            this.covidbutton = new System.Windows.Forms.Button();
            this.fbibutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // covidbutton
            // 
            this.covidbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.covidbutton.AutoSize = true;
            this.covidbutton.BackColor = System.Drawing.Color.White;
            this.covidbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.covidbutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidbutton.Image = global::NewOrderDesign.Properties.Resources.medicalcross;
            this.covidbutton.Location = new System.Drawing.Point(44, 119);
            this.covidbutton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.covidbutton.MaximumSize = new System.Drawing.Size(375, 406);
            this.covidbutton.MinimumSize = new System.Drawing.Size(293, 241);
            this.covidbutton.Name = "covidbutton";
            this.covidbutton.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.covidbutton.Size = new System.Drawing.Size(293, 241);
            this.covidbutton.TabIndex = 0;
            this.covidbutton.Text = "COVID-19";
            this.covidbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.covidbutton.UseVisualStyleBackColor = false;
            this.covidbutton.Click += new System.EventHandler(this.covidbutton_Click);
            // 
            // fbibutton
            // 
            this.fbibutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbibutton.AutoSize = true;
            this.fbibutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.fbibutton.BackgroundImage = global::NewOrderDesign.Properties.Resources.handcufficon;
            this.fbibutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbibutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fbibutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbibutton.Location = new System.Drawing.Point(419, 119);
            this.fbibutton.MaximumSize = new System.Drawing.Size(375, 406);
            this.fbibutton.MinimumSize = new System.Drawing.Size(292, 241);
            this.fbibutton.Name = "fbibutton";
            this.fbibutton.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.fbibutton.Size = new System.Drawing.Size(292, 241);
            this.fbibutton.TabIndex = 1;
            this.fbibutton.Text = "Violent Crime Data";
            this.fbibutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fbibutton.UseVisualStyleBackColor = false;
            this.fbibutton.Click += new System.EventHandler(this.fbibutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(192, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 91);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Welcome";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(266, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // DataSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fbibutton);
            this.Controls.Add(this.covidbutton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 496);
            this.Name = "DataSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelSite";
            this.Load += new System.EventHandler(this.DataSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button covidbutton;
        private System.Windows.Forms.Button fbibutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}