using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class Ogrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public SUBE Sube { get; set; }
        public float Ortalama
        {
            
            get
            {

                float x= this.Notlar.Sum(a => a.Notu) / 3;


                return x;

                
            }


        }

        public List<Adres> Adres = new List <Adres>();

        public List<Kitaplar> Kitaplar = new List<Kitaplar>();

        public List<DersNotu> Notlar = new List<DersNotu>();

        public string Aciklama { get; set; }

        public Ogrenci(int no, string ad, string soyad, DateTime dg, CINSIYET cinsiyet, SUBE sb)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumTarihi = dg;
            this.Cinsiyet = cinsiyet;
            this.Sube = sb;


        }

        

    }



    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }

    public enum SUBE
    {
        Empty,A, B, C
    }

}
