using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class Hastane
    {
        //ÜYE BİLGİLERİ
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeNumara { get; set; }
        public string UyeTC { get; set; }
        public string UyeBolum { get; set; }
        public string UyeSifre { get; set; }
        public string UyeKullaniciadi { get; set; }

        //YÖNETİCİ BİLGİLERİ
        public string YoneticiTC { get; set; }
        public string YoneticiAd { get; set; }
        public string YoneticiSoyad { get; set; }
        public string YoneticiKullaniciadi { get; set; }
        public string YoneticiSifre { get; set; }
    }
}
