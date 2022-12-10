namespace HastaneOtomasyonu
{
    partial class GirisEkrani
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
            this.btngirisyonetici = new System.Windows.Forms.Button();
            this.btngirisuye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btngirisyonetici
            // 
            this.btngirisyonetici.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btngirisyonetici.Location = new System.Drawing.Point(208, 116);
            this.btngirisyonetici.Name = "btngirisyonetici";
            this.btngirisyonetici.Size = new System.Drawing.Size(123, 54);
            this.btngirisyonetici.TabIndex = 0;
            this.btngirisyonetici.Text = "Yönetici Girişi";
            this.btngirisyonetici.UseVisualStyleBackColor = false;
            this.btngirisyonetici.Click += new System.EventHandler(this.btngirisyonetici_Click);
            // 
            // btngirisuye
            // 
            this.btngirisuye.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btngirisuye.Location = new System.Drawing.Point(208, 238);
            this.btngirisuye.Name = "btngirisuye";
            this.btngirisuye.Size = new System.Drawing.Size(123, 54);
            this.btngirisuye.TabIndex = 1;
            this.btngirisuye.Text = "Üye Girişi";
            this.btngirisuye.UseVisualStyleBackColor = false;
            this.btngirisuye.Click += new System.EventHandler(this.btngirisuye_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HastaneOtomasyonu.Properties.Resources.MorRenk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 390);
            this.Controls.Add(this.btngirisuye);
            this.Controls.Add(this.btngirisyonetici);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngirisyonetici;
        private System.Windows.Forms.Button btngirisuye;
    }
}