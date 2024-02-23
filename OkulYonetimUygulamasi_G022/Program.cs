using System;

namespace OkulYonetimUygulamasi_G022
{
    class Program
    {
        static Okul Okul = new Okul();
        //1) Kullanıcı ile iletişim kurulan,
        //bilgi alış verişi yapılan tüm kodlar bu sayfada yazılacak

        //2) Bu sayfa Öğrenci classını bilmeyecek, Okul classı ara katman olacak.
        //Öğrenci eklemek istediğimizde kullanıcıdan veriler buradan alacağız,
        //okul classındaki bir metoda göndereceğiz, Ogrenci oluşturma ve listeye ekleme işini Okul classındaki metot yapacak.



        static void Main(string[] args)
        {

            Menu();

            while (true)
            {
                Console.WriteLine();
                string secim = SecimAl();

                switch (secim)
                {
                    case "1":

                        OgrenciEkle();
                        break;

                    case "2":
                        NotEkle();
                        break;

                    case "3":

                        Ortalamagör();
                        break;

                    case "4":
                        AdresGir();
                        break;

                    case "5":

                        OgrencileriListele();
                        break;

                    case "6":

                        SubeyeGoreListele();
                        break;

                    case "7":

                        OgrenciNotu();
                        break;

                    case "8":
                        SınıfNotOrtlama();
                        break;

                    case "9":
                        CinsiyeteGöreSırala(); // Erkek problem var
                        break;

                    case "10":
                        DogumTarihineGoreSırala();
                        break;

                        // 11 semte göre yazdır metodu yok
                    case "12":
                        OkulBaşarıSırala();
                        break;
                    case "13":
                        OkulBaşarısızSırala();

                        break;

                    case "14":
                        ŞubeBaşarıSırala();
                        break;

                    case "15":
                        ŞubeBaşarızSırala();
                        break;

                    case "16":
                        OgrenciAcıklama();
                        break;

                    case "17":
                        OgrenciAcıklamaGör();
                        break;

                    case "18":
                        KitapGir();
                        break;

                    case "19":
                        KitapGör();
                        break;

                    case "20":
                        SonKitapGör();
                        break;
                }


            }



        }


        static void Menu()
        {
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine("1-Öğrenci Ekle");
            Console.WriteLine("2-Not Gir");
            Console.WriteLine("3-Öğrencinin ortalamasını gör");
            Console.WriteLine("4-Öğrencinin adresini gir");
            Console.WriteLine("5-Bütün Öğrencileri Listele");
            Console.WriteLine("6-Şubeye Göre Öğrencileri Listele");
            Console.WriteLine("7-Öğrencinin notlarını görüntüle");
            Console.WriteLine("8-Sınıfın Not Ortalamasını Gör");
            Console.WriteLine("9-Cinsiyetine göre öğrenci listele");
            Console.WriteLine("10-Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("11-Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine("12-Okuldaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("13-Okuldaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("14-Sınıftaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("15-Sınıftaki  En başarısız 3 öğrenciyi listele");
            Console.WriteLine("16-Öğrenci için açıklama gir");
            Console.WriteLine("17-Öğrencinin açıklamasını gör");
            Console.WriteLine("18-Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("19-Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("20-Öğrencinin okuduğu son kitabı görüntüle");
            Console.WriteLine("21-Öğrenci sil");
            Console.WriteLine("22-Öğrenci güncelle");

            Console.WriteLine();






        }

        static public string SecimAl()
        {


            Console.Write("Yapmak istediğiniz işlemi seçiniz:");
            return Console.ReadLine().ToUpper();

            Console.WriteLine();

        }

        static public void OgrenciEkle()
        {

            Console.WriteLine("1-Öğrenci Ekle ---------------------------------------------");

            int no;
            bool x = true;



            int numara = Araçgerçeler.SayiAl("Öğrenci numarası: ");

            no = numara;






            if (Okul.OgrenciKontrol(numara))
            {

                x = true;
            }
            else
            {

                while (true)
                {

                    numara++;

                    x = false;


                    if (Okul.OgrenciKontrol(numara))
                    {


                        break;

                    }
                    else
                    {

                        x = false;

                        continue;
                    }

                    break;

                }

            }

            Console.Write("Öğrencinin adı:");
            string ad = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(ad))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Öğrencinin adı:");
                    ad = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }



            Console.Write("Öğrencinin soyadı: ");
            string soyad = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(soyad))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Öğrencinin soyadı: ");
                    soyad = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }


            DateTime dg = Araçgerçeler.DogumTarihiAl("Öğrencinin doğum tarihi:");



            CINSIYET cinsiyet = Araçgerçeler.CınsıyetAl();

            SUBE sube = Araçgerçeler.SubeAl();


            Okul.OgrenciEkle(numara, ad, soyad, dg, cinsiyet, sube);

            if (x == true)
            {

                Console.WriteLine(numara + " numaralı öğrenci sisteme başarılı bir şekilde eklenmiştir.");
            }
            else
            {

                Console.WriteLine("Sistemde " + no + " numaralı öğrenci olduğu için verdiğiniz öğrenci no " + numara + " olarak değiştirildi.");
            }











        }

        static public void OgrenciAcıklama()
        {

            Console.WriteLine("16 - Öğrenci için açıklama gir--------------------------------");


            int x = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");
                   

            Console.Write("Açıklama: ");

            string mesaj = Console.ReadLine();

            Okul.AcıklamaEkle(x, mesaj);




        }

        static public void OgrenciAcıklamaGör()
        {

            Console.WriteLine("17 - Öğrenci için açıklama gör--------------------------------");


            int x = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");


            string name = Okul.OgrenciGetir(x).Aciklama;

            if (Okul.OgrenciKontrol(x) == true)
            {
                Console.WriteLine("Öğrencinin adı soyadı : " + Okul.OgrenciGetir(x).Ad + " " + Okul.OgrenciGetir(x).Soyad);
                Console.WriteLine("Öğrencinin şubesi : " + Okul.OgrenciGetir(x).Sube);

            }

            Console.Write("Açıklama: ");

            Console.WriteLine(Okul.OgrenciGetir(x).Aciklama);






        }

        static public void KitapGir()
        {

            Console.WriteLine("18 - Öğrencinin okuduğu kitabı gir--------------------------------");


            int x = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");
           

                        Console.Write("Eklenecek Kitap Adı: ");

            string kitap = Console.ReadLine();


            Okul.KitapEkle(x, kitap);

            






        }

        static public void KitapGör()
        {

            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gör--------------------------------");

            int x = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");


                        Okul.OgrenciKitapları(x);
            


            








        }

        static public void SonKitapGör()
        {

            Console.WriteLine("20 - Öğrencinin okuduğu son kitabı gör--------------------------------");

            int x = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");


            Okul.SonKitap(x);












        }
        static void Uygulama()
        {
            //switch ()
            //{
            //    case "2":
            //        NotEkle();
            //        break;
            //}
        }


         

        static void NotEkle()
        {
            Console.WriteLine("2 - Not Gir------------------------------------------------");

            int numara = Araçgerçeler.SayiAl("Öğrenci numarası: ");
            while (true)
            {
                if (Okul.OgrenciKontrol(numara))
                {

                    Console.WriteLine("Bu numarada bir öğrenci yok.Tekrar deneyin");
                    numara = Araçgerçeler.SayiAl("Öğrenci numarası: ");

                }
                else
                {

                    break;

                }


            }



            DersNotu.DERSLER dersAdi = Araçgerçeler.DersAl();



            int adet = Araçgerçeler.SayiAl("Eklemek istediğiniz not adedi: ");

            for (int i = 1; i <= adet; i++)
            {

                int not = Araçgerçeler.SayiAl(i + ". notu girin: ");

                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    i--;
                    continue;
                }

                Okul.NotEkle(numara, dersAdi, not);

            }
            Console.WriteLine("Bilgiler sisteme girilmiştir.");


        }

        static void Ortalamagör()
        {
            Console.WriteLine("3- Öğrencinin not ortalamasını gör--------------------------------");


            int no = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");
            while (true)
            {
                if (Okul.OgrenciKontrol(no))
                {

                    Console.WriteLine("Bu numarada bir öğrenci yok.Tekrar deneyin");
                    no = Araçgerçeler.SayiAl("Öğrenci numarası: ");

                }
                else
                {

                    break;

                }


            }

            float ort = Okul.OrtalamaBul(no);

            Console.Write("Öğrencinin not ortalaması: " + ort);






        }

        static void AdresGir()
        {
            Console.WriteLine("3- Öğrencinin not ortalamasını gör--------------------------------");

            int numara = Araçgerçeler.SayiAl("Öğrenci numarası: ");
            while (true)
            {
                if (Okul.OgrenciKontrol(numara))
                {

                    Console.WriteLine("Bu numarada bir öğrenci yok.Tekrar deneyin");
                    numara = Araçgerçeler.SayiAl("Öğrenci numarası: ");

                }
                else
                {

                    break;

                }


            }

            Console.Write("İl: ");
            string ad = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(ad))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("İl: ");
                    ad = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }

            Console.Write("İlçe: ");
            string ilce = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(ilce))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("İlce: ");
                    ilce = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }
            Console.Write("Mahalle: ");
            string mahalle = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(mahalle))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Mahalle: ");
                    mahalle = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }


            Okul.AdresEkle(numara, ad, ilce, mahalle);

            Console.WriteLine("Bilgiler sisteme girilmiştir.");

        }

        static void OgrencileriListele()
        {
            Console.WriteLine("5- Bütün Öğrencileri Listele -------------------------------");

            Okul.ListeYazdir(Okul.Ogrenciler);


        }
        static void SubeyeGoreListele()
        {

            Console.WriteLine("5- Bütün Öğrencileri Listele -------------------------------");



            string sube = Araçgerçeler.SubeMi();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(sube))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Listelemek istediğiniz şubeyi girin(A/B/C): ");
                    sube = Console.ReadLine().ToUpper();
                }

                else
                {

                    break;
                }



            }



            Console.WriteLine();


            if (sube == "A")
            {

                Okul.SubeyeGore(sube);


            }
            else if (sube == "B")
            {
                Okul.SubeyeGore(sube);


            }
            else if (sube == "C")
            {
                Okul.SubeyeGore(sube);


            }



















        }

        static void CinsiyeteGöreSırala()
        {

            Console.WriteLine("9- Cinsiyete Göre Öğrencileri Listele -------------------------------");



            string cins = Araçgerçeler.CinsiyetMi();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(cins))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Listelemek istediğiniz cinsiyeti girin(K / E):  ");
                    cins = Console.ReadLine().ToUpper();
                }

                else
                {

                    break;
                }



            }



            Console.WriteLine();


            if (cins == "K")
            {

                Okul.CinsiyeteeGore(cins);


            }
            else if (cins == "E")
            {
                Okul.SubeyeGore(cins);


            }




















        }

        static void DogumTarihineGoreSırala()
        {

            Console.WriteLine("10- Doğum Tarihine Göre Öğrencileri Listele -------------------------------");

            DateTime dg = Araçgerçeler.DogumTarihiAl("Hangi tarihten sonraki öğrencileri listelemek istersiniz: ");

            Okul.DoğumTarihi(dg);

        }

        static void OkulBaşarıSırala()
        {

            Console.WriteLine("12- Okuldaki En Başarılı 5 öğrenciyi listele-------------------------------");



            Okul.EnList("5");




        }

        static void OkulBaşarısızSırala()
        {

            Console.WriteLine("13- Okuldaki En Başarısız 3 öğrenciyi listele-------------------------------");



            Okul.EnList("3");




        }

        static void ŞubeBaşarıSırala()
        {

            Console.WriteLine("14-Sınıftaki en başarılı 5 öğrenciyi listele --------------------------");

            string sube = Araçgerçeler.SubeMi();

            Okul.EnListSube(sube);






        }
        static void ŞubeBaşarızSırala()
        {

            Console.WriteLine("15-Sınıftaki en başarısız 3 öğrenciyi listele --------------------------");

            string sube = Araçgerçeler.SubeMi();

            Okul.EnListSube(sube);






        }

        static void OrtalamaGor()
        {
            while (true)
            {
                int no = Araçgerçeler.SayiAl("Öğrenci no giriniz: ");
                Ogrenci o = Okul.OgrenciGetir(no);

                if (Okul.OgrenciKontrol(no) == true)
                {
                    Console.WriteLine("Öğrencinin adı soyadı : " + o.Ad + " " + o.Soyad);
                    Console.WriteLine("Öğrencinin şubesi : " + o.Sube);

                    Console.WriteLine("Öğrencinin not ortalaması :" + Okul.OrtalamaGor(no));
                    break;
                }


            }
        }

        static void OgrenciNotu()
        {

            Console.WriteLine("7-Öğrencinin notlarını görüntüle ------------------------------------");

            int no = Araçgerçeler.SayiAl("Öğrencinin numarası: ");


            Okul.Ogrencinotları(no);

        }


        static void SınıfNotOrtlama()
        {

            Console.WriteLine("8-Sınıfın Not Ortalamasını Gör --------------------------------------");

            Console.Write("Ortalamasını görmek istediğiniz snıfı girin(A/B/C): ");

            string sube = Console.ReadLine().ToUpper();
            while (true)
            {


                if (!Araçgerçeler.HarfMi(sube))
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    Console.Write("Ortalamasını görmek istediğiniz snıfı girin(A/B/C): ");
                    sube = Console.ReadLine().ToUpper();
                }
                else
                {

                    break;
                }


            }

            Okul.SubeyOrtalama(sube);








        }
    }
}
