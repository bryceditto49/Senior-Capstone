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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.btlogin = new System.Windows.Forms.Button();
            this.btguest = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.btregis = new System.Windows.Forms.Button();
            this.chkre = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btlogin.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btlogin.Location = new System.Drawing.Point(322, 265);
            this.btlogin.MinimumSize = new System.Drawing.Size(56, 23);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(56, 23);
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
            this.btguest.Location = new System.Drawing.Point(400, 265);
            this.btguest.MinimumSize = new System.Drawing.Size(56, 23);
            this.btguest.Name = "btguest";
            this.btguest.Size = new System.Drawing.Size(56, 23);
            this.btguest.TabIndex = 1;
            this.btguest.Text = "Guest ";
            this.btguest.UseVisualStyleBackColor = false;
            this.btguest.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Location = new System.Drawing.Point(322, 146);
            this.txtuser.MinimumSize = new System.Drawing.Size(212, 22);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(212, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Location = new System.Drawing.Point(322, 209);
            this.txtpass.MinimumSize = new System.Drawing.Size(212, 22);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(212, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpass_KeyDown);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(242, 154);
            this.lbuser.MinimumSize = new System.Drawing.Size(55, 14);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(55, 14);
            this.lbuser.TabIndex = 4;
            this.lbuser.Text = "Username";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(244, 215);
            this.lbpass.MinimumSize = new System.Drawing.Size(52, 14);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 14);
            this.lbpass.TabIndex = 5;
            this.lbpass.Text = "Password";
            // 
            // btregis
            // 
            this.btregis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.btregis.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.btregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btregis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btregis.Location = new System.Drawing.Point(478, 265);
            this.btregis.MinimumSize = new System.Drawing.Size(56, 23);
            this.btregis.Name = "btregis";
            this.btregis.Size = new System.Drawing.Size(56, 23);
            this.btregis.TabIndex = 6;
            this.btregis.Text = "Register";
            this.btregis.UseVisualStyleBackColor = false;
            this.btregis.Click += new System.EventHandler(this.btregis_Click);
            // 
            // chkre
            // 
            this.chkre.AutoSize = true;
            this.chkre.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.chkre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkre.Location = new System.Drawing.Point(322, 313);
            this.chkre.Name = "chkre";
            this.chkre.Size = new System.Drawing.Size(92, 17);
            this.chkre.TabIndex = 7;
            this.chkre.Text = "RememberMe";
            this.chkre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkre.UseVisualStyleBackColor = true;
            this.chkre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(508, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(508, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::NewOrderDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkre);
            this.Controls.Add(this.btregis);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btguest);
            this.Controls.Add(this.btlogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 496);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelSite";
            this.Load += new System.EventHandler(this.Form6_Load);
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
        private System.Windows.Forms.CheckBox chkre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}