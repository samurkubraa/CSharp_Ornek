﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btngirisuye_Click(object sender, EventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
        }

        private void btngirisyonetici_Click(object sender, EventArgs e)
        {
            YoneticiGirisi yoneticiGirisi = new YoneticiGirisi();
            yoneticiGirisi.Show();
        }
    }
}
