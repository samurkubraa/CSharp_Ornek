namespace HastaneOtomasyonu
{
    partial class YoneticiGirisi
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
            this.txtyoneticisifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyoneticikullaniciadi = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtyoneticisifre
            // 
            this.txtyoneticisifre.Location = new System.Drawing.Point(339, 126);
            this.txtyoneticisifre.Name = "txtyoneticisifre";
            this.txtyoneticisifre.Size = new System.Drawing.Size(100, 20);
            this.txtyoneticisifre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yönetici Şifre";
            // 
            // txtyoneticikullaniciadi
            // 
            this.txtyoneticikullaniciadi.Location = new System.Drawing.Point(339, 54);
            this.txtyoneticikullaniciadi.Name = "txtyoneticikullaniciadi";
            this.txtyoneticikullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txtyoneticikullaniciadi.TabIndex = 7;
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(339, 201);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(100, 23);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yönetici Kullanıcı Adı";
            // 
            // YoneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtyoneticisifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtyoneticikullaniciadi);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label1);
            this.Name = "YoneticiGirisi";
            this.Text = "YoneticiGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtyoneticisifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyoneticikullaniciadi;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
    }
}