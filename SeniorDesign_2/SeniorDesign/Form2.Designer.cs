
namespace SeniorDesign
{
    partial class CitySelectionFrm
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
            this.backbutton = new System.Windows.Forms.Button();
            this.cityselection = new System.Windows.Forms.TextBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.AutoSize = true;
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backbutton.ForeColor = System.Drawing.Color.Transparent;
            this.backbutton.Image = global::SeniorDesign.Properties.Resources.backbutton;
            this.backbutton.Location = new System.Drawing.Point(16, 15);
            this.backbutton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(53, 47);
            this.backbutton.TabIndex = 1;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // cityselection
            // 
            this.cityselection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cityselection.Location = new System.Drawing.Point(463, 244);
            this.cityselection.Margin = new System.Windows.Forms.Padding(4);
            this.cityselection.Name = "cityselection";
            this.cityselection.Size = new System.Drawing.Size(132, 22);
            this.cityselection.TabIndex = 2;
            this.cityselection.Text = "Please Enter A City";
            // 
            // submitbutton
            // 
            this.submitbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitbutton.Location = new System.Drawing.Point(483, 276);
            this.submitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(100, 28);
            this.submitbutton.TabIndex = 3;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // CitySelectionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::SeniorDesign.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.cityselection);
            this.Controls.Add(this.backbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CitySelectionFrm";
            this.Text = "City Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox cityselection;
        private System.Windows.Forms.Button submitbutton;
    }
}