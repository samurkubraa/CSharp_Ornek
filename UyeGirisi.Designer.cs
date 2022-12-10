namespace HastaneOtomasyonu
{
    partial class UyeGirisi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.txtuyekullaniciadi = new System.Windows.Forms.TextBox();
            this.txtuyesifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Kullanıcı Adı";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(309, 218);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(100, 23);
            this.btngiris.TabIndex = 1;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtuyekullaniciadi
            // 
            this.txtuyekullaniciadi.Location = new System.Drawing.Point(309, 71);
            this.txtuyekullaniciadi.Name = "txtuyekullaniciadi";
            this.txtuyekullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtuyekullaniciadi.TabIndex = 2;
            // 
            // txtuyesifre
            // 
            this.txtuyesifre.Location = new System.Drawing.Point(309, 143);
            this.txtuyesifre.Name = "txtuyesifre";
            this.txtuyesifre.Size = new System.Drawing.Size(100, 20);
            this.txtuyesifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üye Şifre";
            // 
            // UyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtuyesifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtuyekullaniciadi);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label1);
            this.Name = "UyeGirisi";
            this.Text = "UyeGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtuyekullaniciadi;
        private System.Windows.Forms.TextBox txtuyesifre;
        private System.Windows.Forms.Label label2;
    }
}