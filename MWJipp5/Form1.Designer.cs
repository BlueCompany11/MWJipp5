namespace MWJipp5
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
            this.btnCzlowiek = new MWJipp5.WlasnyPrzycisk();
            this.btnPies = new MWJipp5.WlasnyPrzycisk();
            this.SuspendLayout();
            // 
            // btnCzlowiek
            // 
            this.btnCzlowiek.Location = new System.Drawing.Point(302, 140);
            this.btnCzlowiek.Name = "btnCzlowiek";
            this.btnCzlowiek.Size = new System.Drawing.Size(132, 23);
            this.btnCzlowiek.TabIndex = 0;
            this.btnCzlowiek.Text = "Czlowiek";
            this.btnCzlowiek.UseVisualStyleBackColor = true;
            this.btnCzlowiek.Click += new System.EventHandler(this.btnCzlowiek_Click);
            // 
            // btnPies
            // 
            this.btnPies.Location = new System.Drawing.Point(302, 211);
            this.btnPies.Name = "btnPies";
            this.btnPies.Size = new System.Drawing.Size(132, 23);
            this.btnPies.TabIndex = 1;
            this.btnPies.Text = "Pies";
            this.btnPies.UseVisualStyleBackColor = true;
            this.btnPies.Click += new System.EventHandler(this.btnPies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPies);
            this.Controls.Add(this.btnCzlowiek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WlasnyPrzycisk btnCzlowiek;
        private WlasnyPrzycisk btnPies;
    }
}

