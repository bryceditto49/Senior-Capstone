
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
            this.SuspendLayout();
            // 
            // covidbutton
            // 
            this.covidbutton.BackColor = System.Drawing.Color.White;
            this.covidbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.covidbutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.covidbutton.Image = global::NewOrderDesign.Properties.Resources.medicalcross;
            this.covidbutton.Location = new System.Drawing.Point(211, 12);
            this.covidbutton.Name = "covidbutton";
            this.covidbutton.Size = new System.Drawing.Size(185, 149);
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
            this.fbibutton.Location = new System.Drawing.Point(402, 12);
            this.fbibutton.Name = "fbibutton";
            this.fbibutton.Size = new System.Drawing.Size(191, 149);
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
            this.dhsbutton.Location = new System.Drawing.Point(599, 12);
            this.dhsbutton.Name = "dhsbutton";
            this.dhsbutton.Size = new System.Drawing.Size(189, 149);
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
            this.textBox1.Location = new System.Drawing.Point(24, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 58);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Welcome User";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "previous saved queries saved here";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dhsbutton);
            this.Controls.Add(this.fbibutton);
            this.Controls.Add(this.covidbutton);
            this.Name = "Form2";
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
    }
}