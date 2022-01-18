
namespace SeniorDesign
{
    partial class DataSelectionFrm
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
            this.Exportbutton = new System.Windows.Forms.Button();
            this.covidbutton = new System.Windows.Forms.Button();
            this.crimedatabutton = new System.Windows.Forms.Button();
            this.terrordatabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(713, 415);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(75, 23);
            this.Exportbutton.TabIndex = 0;
            this.Exportbutton.Text = "Export All";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // covidbutton
            // 
            this.covidbutton.Location = new System.Drawing.Point(69, 126);
            this.covidbutton.Name = "covidbutton";
            this.covidbutton.Size = new System.Drawing.Size(215, 162);
            this.covidbutton.TabIndex = 1;
            this.covidbutton.Text = "COVID 19";
            this.covidbutton.UseVisualStyleBackColor = true;
            this.covidbutton.Click += new System.EventHandler(this.covidbutton_Click);
            // 
            // crimedatabutton
            // 
            this.crimedatabutton.Location = new System.Drawing.Point(290, 126);
            this.crimedatabutton.Name = "crimedatabutton";
            this.crimedatabutton.Size = new System.Drawing.Size(215, 162);
            this.crimedatabutton.TabIndex = 2;
            this.crimedatabutton.Text = "Violent Crime Data";
            this.crimedatabutton.UseVisualStyleBackColor = true;
            this.crimedatabutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // terrordatabutton
            // 
            this.terrordatabutton.Location = new System.Drawing.Point(511, 126);
            this.terrordatabutton.Name = "terrordatabutton";
            this.terrordatabutton.Size = new System.Drawing.Size(215, 162);
            this.terrordatabutton.TabIndex = 3;
            this.terrordatabutton.Text = "Terrorism Data";
            this.terrordatabutton.UseVisualStyleBackColor = true;
            this.terrordatabutton.Click += new System.EventHandler(this.terrordatabutton_Click);
            // 
            // DataSelectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.terrordatabutton);
            this.Controls.Add(this.crimedatabutton);
            this.Controls.Add(this.covidbutton);
            this.Controls.Add(this.Exportbutton);
            this.Name = "DataSelectionFrm";
            this.Text = "Data Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exportbutton;
        private System.Windows.Forms.Button covidbutton;
        private System.Windows.Forms.Button crimedatabutton;
        private System.Windows.Forms.Button terrordatabutton;
    }
}