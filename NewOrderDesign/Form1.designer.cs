
namespace NewOrderDesign
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btsubmit = new System.Windows.Forms.Button();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbfirst = new System.Windows.Forms.Label();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.btback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Location = new System.Drawing.Point(201, 39);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(286, 22);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Location = new System.Drawing.Point(201, 96);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(286, 22);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsubmit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btsubmit.Location = new System.Drawing.Point(201, 226);
            this.btsubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(100, 28);
            this.btsubmit.TabIndex = 2;
            this.btsubmit.Text = "Register";
            this.btsubmit.UseVisualStyleBackColor = false;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lbuser.Location = new System.Drawing.Point(47, 42);
            this.lbuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(104, 16);
            this.lbuser.TabIndex = 4;
            this.lbuser.Text = "Enter Username";
            this.lbuser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lbpass.Location = new System.Drawing.Point(47, 98);
            this.lbpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(101, 16);
            this.lbpass.TabIndex = 8;
            this.lbpass.Text = "Enter Password";
            // 
            // lbfirst
            // 
            this.lbfirst.AutoSize = true;
            this.lbfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.lbfirst.Location = new System.Drawing.Point(47, 156);
            this.lbfirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfirst.Name = "lbfirst";
            this.lbfirst.Size = new System.Drawing.Size(115, 16);
            this.lbfirst.TabIndex = 9;
            this.lbfirst.Text = "Confirm Password";
            // 
            // txtcon
            // 
            this.txtcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcon.Location = new System.Drawing.Point(201, 154);
            this.txtcon.Margin = new System.Windows.Forms.Padding(4);
            this.txtcon.Name = "txtcon";
            this.txtcon.PasswordChar = '*';
            this.txtcon.Size = new System.Drawing.Size(286, 22);
            this.txtcon.TabIndex = 5;
            this.txtcon.TextChanged += new System.EventHandler(this.txtcon_TextChanged);
            this.txtcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcon_KeyDown);
            // 
            // btback
            // 
            this.btback.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btback.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btback.Location = new System.Drawing.Point(388, 226);
            this.btback.Margin = new System.Windows.Forms.Padding(4);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(100, 28);
            this.btback.TabIndex = 10;
            this.btback.Text = "Back";
            this.btback.UseVisualStyleBackColor = true;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 385);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.lbfirst);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CrimeSight";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbfirst;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.Button btback;
    }
}

