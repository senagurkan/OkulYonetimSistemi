using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void NotEkle(int ogrenciNo, DersNotu.DERSLER dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(dersAdi, not));


            }


        }

        public void Ogrencinotları(int ogrenciNo)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            List<DersNotu> liste1;

            liste1 = o.Notlar;

            if (o != null)
            {
                Console.WriteLine("Dersin Adı ".PadRight(10) + "Notu".ToString().PadLeft(10));
                Console.WriteLine("".PadRight(25, '-'));


                foreach (DersNotu item in liste1)
                {
                    Console.WriteLine(item.DersAdi.ToString().PadRight(5) + item.Notu.ToString().PadLeft(10));
                }


            }



        }
        public void OgrenciKitapları(int ogrenciNo)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            List<Kitaplar> liste1;


         
            if (this.OgrenciKontrol(ogrenciNo) == true)
            {
                Console.WriteLine("Öğrencinin adı soyadı : " + o.Ad + " " + o.Soyad);
                Console.WriteLine("Öğrencinin şubesi : " + o.Sube);

            }




            liste1 = o.Kitaplar;

            

            if (o != null)
            {
                Console.WriteLine("Okuduğu Kitaplar ");
                Console.WriteLine("".PadRight(25, '-'));


                foreach (Kitaplar item in liste1)
                {
                    Console.WriteLine(item.Kitap);
                }


            }



        }
        public void SonKitap(int ogrenciNo)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            List<Kitaplar> liste1;





            if (this.OgrenciKontrol(ogrenciNo) == true)
            {
                Console.WriteLine("Öğrencinin adı soyadı : " + o.Ad + " " + o.Soyad);
                Console.WriteLine("Öğrencinin şubesi : " + o.Sube);

            }


            

            liste1 = o.Kitaplar;

           



            Kitaplar kitap2 = liste1.LastOrDefault();


          


            if (o != null)
            {
                Console.WriteLine("Okuduğu Son Kitap ");
                Console.WriteLine("".PadRight(25, '-'));

                Console.WriteLine();


                Console.WriteLine(kitap2.Kitap);


            }



        }

        public void AdresEkle(int ogrenciNo, string İL, string İLCE, string MAHALLE)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (o != null)
            {
                o.Adres.Add(new Adres(İL, İLCE, MAHALLE));


            }

        }



        public Okul()
        {

            SahteOgrenciEkle();


        }

        public void SahteOgrenciEkle()
        {
            DateTime tarih = new DateTime(1995, 06, 13);
            DateTime tarih1 = new DateTime(1999, 06, 07);
            DateTime tarih2 = new DateTime(2001, 01, 19);

            this.OgrenciEkle(24, "Emre", "Hasan", tarih, CINSIYET.Erkek, SUBE.A);

            this.OgrenciEkle(35, "Lale", "Devri", tarih1, CINSIYET.Erkek, SUBE.A);
            this.OgrenciEkle(36, "Ekrem", "Kus", tarih2, CINSIYET.Kiz, SUBE.C);

        }


        public void OgrenciEkle(int no, string ad, string soyad, DateTime dg, CINSIYET cinsiyet, SUBE sb)
        {


            int giris = no;

            Ogrenci a = new Ogrenci(no, ad, soyad, dg, cinsiyet, sb);

            this.Ogrenciler.Add(a);








        }


        public void AcıklamaEkle(int ogrenciNo, string mesaj)
        {


            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (this.OgrenciKontrol(ogrenciNo) == true)
            {
                Console.WriteLine("Öğrencinin adı soyadı : " + o.Ad + " " + o.Soyad);
                Console.WriteLine("Öğrencinin şubesi : " + o.Sube);

            }


            if (o != null)
            {
                o.Aciklama = mesaj;

                Console.WriteLine("Bilgiler sisteme girilmiştir.");

            }

        }

        public void KitapEkle(int ogrenciNo, string kitap)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (this.OgrenciKontrol(ogrenciNo) == true)
            {
                Console.WriteLine("Öğrencinin adı soyadı : " + o.Ad + " " + o.Soyad);
                Console.WriteLine("Öğrencinin şubesi : " + o.Sube);

            }

            if (o != null)
            {
                o.Kitaplar.Add(new Kitaplar (kitap));

                Console.WriteLine("Bilgiler sisteme girilmiştir.");
            }

        }


        public bool OgrenciKontrol(int ogrenciNo)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (o != null)
            {

                return false;

            }
            else
            {
                return true;

            }





        }

        public float OrtalamaBul(float No)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == No).FirstOrDefault();

            return o.Ortalama;


        }

        public void ListeYazdir(List<Ogrenci> liste)
        {

            if (liste.Count == 0)
            {
                Console.WriteLine("Listelenecek öğrenci yok");
                return;
            }
            Console.WriteLine("Şube".PadRight(5) + "No".ToString().PadRight(10) + "Adı Soyadı".PadRight(10) + "Not Ort.".ToString().PadRight(10)
                + "Okuduğu Kitap Sayısı".ToString().PadRight(5));
            Console.WriteLine("".PadRight(52, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.Sube.ToString().PadRight(5) + item.No.ToString().PadRight(10) + item.Ad + " " + item.Soyad.PadRight(10) + item.Ortalama.ToString().PadRight(10)
                    + item.Kitaplar.Count.ToString().PadRight(5));
            }
        }
        public Ogrenci OgrenciGetir(int no)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();
            return o;
        }


        public float OrtalamaGor(int OgrenciNo)
        {

            Ogrenci o = this.Ogrenciler.Where(a => a.No == OgrenciNo).FirstOrDefault();

            float ort = o.Ortalama;
            return ort;

        }



        public List<Ogrenci> SubeyeGore(string sinif)


        {
            List<Ogrenci> liste1;


            if (sinif.ToUpper() == "A")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.A).ToList();

                ListeYazdir(liste1);
                return liste1;
            }
            else if (sinif.ToUpper() == "B")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.B).ToList();
                ListeYazdir(liste1);
                return liste1;
            }
            else
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.C).ToList();
                ListeYazdir(liste1);
                return liste1;
            }




        }
        public void SubeyOrtalama(string sinif)


        {

            if (sinif.ToUpper() == "A")
            {
                double liste1 = Ogrenciler.Where(a => a.Sube == SUBE.A).Average(a => a.Ortalama);

                Console.WriteLine(sinif + " şubesinin not ortalaması :" + liste1);
            }
            else if (sinif.ToUpper() == "B")
            {
                double liste1 = Ogrenciler.Where(a => a.Sube == SUBE.B).Average(a => a.Ortalama);

                Console.WriteLine(sinif + " şubesinin not ortalaması :" + liste1);
            }
            else
            {
                double liste1 = Ogrenciler.Where(a => a.Sube == SUBE.C).Average(a => a.Ortalama);

                Console.WriteLine(sinif + " şubesinin not ortalaması :" + liste1);
            }




        }
        public List<Ogrenci> CinsiyeteeGore(string sinif)


        {
            List<Ogrenci> liste1;




            if (sinif.ToUpper() == "K")
            {
                liste1 = this.Ogrenciler.Where(a => a.Cinsiyet == CINSIYET.Kiz).ToList();

                ListeYazdir(liste1);
                return liste1;
            }
            else if (sinif.ToUpper() == "E")
            {
                liste1 = this.Ogrenciler.Where(a => a.Cinsiyet == CINSIYET.Erkek).ToList();

                ListeYazdir(liste1);
                return liste1;
            }
            else
            {
                liste1 = this.Ogrenciler.Where(a => a.Cinsiyet == CINSIYET.Empty).ToList();

                ListeYazdir(liste1);
                return liste1;
            }






        }

        public List<Ogrenci> DoğumTarihi(DateTime sinif)


        {
            List<Ogrenci> liste1;



            liste1 = this.Ogrenciler.Where(a => a.DogumTarihi > sinif).ToList();

            ListeYazdir(liste1);
            return liste1;






        }

        public List<Ogrenci> EnList(string sinif)


        {
            List<Ogrenci> liste1;


            if (sinif.ToUpper() == "5")
            {

                liste1 = this.Ogrenciler.Where(a => a.Sube != SUBE.Empty).OrderByDescending(a => a.Ortalama).Take(5).ToList();

                ListeYazdir(liste1);
                return liste1;


            }
            else
            {

                liste1 = this.Ogrenciler.Where(a => a.Sube != SUBE.Empty).OrderBy(a => a.Ortalama).Take(3).ToList();

                ListeYazdir(liste1);
                return liste1;

            }








        }



        public List<Ogrenci> EnListSube(string sinif)


        {
            List<Ogrenci> liste1;


            if (sinif.ToUpper() == "A")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.A).OrderByDescending(a => a.Ortalama).Take(5).ToList();

                ListeYazdir(liste1);
                return liste1;
            }
            else if (sinif.ToUpper() == "B")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.B).OrderByDescending(a => a.Ortalama).Take(5).ToList();
                ListeYazdir(liste1);
                return liste1;
            }
            else
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.C).OrderByDescending(a => a.Ortalama).Take(5).ToList();
                ListeYazdir(liste1);
                return liste1;
            }




        }

        public List<Ogrenci> EnBsrzListSube(string sinif)


        {
            List<Ogrenci> liste1;


            if (sinif.ToUpper() == "A")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.A).OrderBy(a => a.Ortalama).Take(3).ToList();

                ListeYazdir(liste1);
                return liste1;
            }
            else if (sinif.ToUpper() == "B")
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.B).OrderBy(a => a.Ortalama).Take(3).ToList();
                ListeYazdir(liste1);
                return liste1;
            }
            else
            {
                liste1 = this.Ogrenciler.Where(a => a.Sube == SUBE.C).OrderBy(a => a.Ortalama).Take(3).ToList();
                ListeYazdir(liste1);
                return liste1;
            }




        }

    }
}
