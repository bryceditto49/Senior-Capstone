
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
            this.covidbutton = new System.Windows.Forms.Button();
            this.fbibutton = new System.Windows.Forms.Button();
            this.dhsbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // covidbutton
            // 
            this.covidbutton.BackColor = System.Drawing.Color.White;
            this.covidbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.covidbutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidbutton.Image = global::NewOrderDesign.Properties.Resources.medicalcross;
            this.covidbutton.Location = new System.Drawing.Point(281, 15);
            this.covidbutton.Margin = new System.Windows.Forms.Padding(4);
            this.covidbutton.Name = "covidbutton";
            this.covidbutton.Size = new System.Drawing.Size(247, 183);
            this.covidbutton.TabIndex = 0;
            this.covidbutton.Text = "COVID-19";
            this.covidbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.covidbutton.UseVisualStyleBackColor = false;
            this.covidbutton.Click += new System.EventHandler(this.covidbutton_Click);
            // 
            // fbibutton
            // 
            this.fbibutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.fbibutton.BackgroundImage = global::NewOrderDesign.Properties.Resources.handcufficon;
            this.fbibutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbibutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fbibutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbibutton.Location = new System.Drawing.Point(536, 15);
            this.fbibutton.Margin = new System.Windows.Forms.Padding(4);
            this.fbibutton.Name = "fbibutton";
            this.fbibutton.Size = new System.Drawing.Size(255, 183);
            this.fbibutton.TabIndex = 1;
            this.fbibutton.Text = "Violent Crime Data";
            this.fbibutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.fbibutton.UseVisualStyleBackColor = false;
            this.fbibutton.Click += new System.EventHandler(this.fbibutton_Click);
            // 
            // dhsbutton
            // 
            this.dhsbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dhsbutton.BackgroundImage = global::NewOrderDesign.Properties.Resources.terrorismicon;
            this.dhsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dhsbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.dhsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dhsbutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhsbutton.Location = new System.Drawing.Point(799, 15);
            this.dhsbutton.Margin = new System.Windows.Forms.Padding(4);
            this.dhsbutton.Name = "dhsbutton";
            this.dhsbutton.Size = new System.Drawing.Size(252, 183);
            this.dhsbutton.TabIndex = 2;
            this.dhsbutton.Text = "Terrorism";
            this.dhsbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dhsbutton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 71);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Welcome";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(552, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(228, 15);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "previous saved queries saved here";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // DataSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dhsbutton);
            this.Controls.Add(this.fbibutton);
            this.Controls.Add(this.covidbutton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataSelection";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button covidbutton;
        private System.Windows.Forms.Button fbibutton;
        private System.Windows.Forms.Button dhsbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}