namespace NewOrderDesign
{
    partial class Form6
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
            this.btlogin = new System.Windows.Forms.Button();
            this.btguest = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.btregis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btlogin.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btlogin.Location = new System.Drawing.Point(156, 201);
            this.btlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 28);
            this.btlogin.TabIndex = 0;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = false;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btguest
            // 
            this.btguest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btguest.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btguest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btguest.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btguest.Location = new System.Drawing.Point(260, 201);
            this.btguest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btguest.Name = "btguest";
            this.btguest.Size = new System.Drawing.Size(75, 28);
            this.btguest.TabIndex = 1;
            this.btguest.Text = "Guest ";
            this.btguest.UseVisualStyleBackColor = false;
            this.btguest.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Location = new System.Drawing.Point(156, 55);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(282, 22);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Location = new System.Drawing.Point(156, 132);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(282, 22);
            this.txtpass.TabIndex = 3;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(49, 64);
            this.lbuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(70, 16);
            this.lbuser.TabIndex = 4;
            this.lbuser.Text = "Username";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(52, 140);
            this.lbpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(67, 16);
            this.lbpass.TabIndex = 5;
            this.lbpass.Text = "Password";
            // 
            // btregis
            // 
            this.btregis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btregis.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btregis.Location = new System.Drawing.Point(364, 201);
            this.btregis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btregis.Name = "btregis";
            this.btregis.Size = new System.Drawing.Size(75, 28);
            this.btregis.TabIndex = 6;
            this.btregis.Text = "Register";
            this.btregis.UseVisualStyleBackColor = false;
            this.btregis.Click += new System.EventHandler(this.btregis_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(539, 325);
            this.Controls.Add(this.btregis);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btguest);
            this.Controls.Add(this.btlogin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "CrimeSight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btguest;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Button btregis;
    }
}