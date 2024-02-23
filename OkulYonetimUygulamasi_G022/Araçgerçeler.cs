using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class Araçgerçeler
    {

        static public CINSIYET CınsıyetAl()
        {

            while (true)
            {
                Console.Write("Öğrencinin cinsiyeti(K / E): ");
                string cinsiyet = Console.ReadLine().ToUpper();

                switch (cinsiyet)
                {

                    case "K":

                        return CINSIYET.Kiz;

                    case "E":

                        return CINSIYET.Erkek;

                    default:

                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");

                        continue;





                }



            }




        }

        static public DersNotu.DERSLER DersAl()
        {

            while (true)
            {
                Console.Write("Eklemek istediğiniz ders adı: ");
                string dersAdi = Console.ReadLine().ToUpper();




                switch (dersAdi)
                {

                    case "TÜRKÇE":

                        return DersNotu.DERSLER.Türkçe;

                    case "MATEMATİK":

                        return DersNotu.DERSLER.Matematik;
                    case "FİZİK":

                        return DersNotu.DERSLER.Fizik;


                    default:

                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");

                        continue;





                }



            }



        }

        static public SUBE SubeAl()
        {

            while (true)
            {

                Console.Write("Öğrencinin sınıf şubesi: ");
                string sube = Console.ReadLine().ToUpper();

                switch (sube)
                {

                    case "A":

                        return SUBE.A;

                    case "B":

                        return SUBE.B;

                    case "C":

                        return SUBE.C;

                    default:

                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");

                        continue;




                }
            }


        }
        static public string SubeMi()
        {

            while (true)
            {

                Console.Write("Listelemek istediğiniz şubeyi girin(A/B/C): ");
                string sube = Console.ReadLine().ToUpper();

                switch (sube)
                {

                    case "A":

                        return "A";

                    case "B":

                        return "B";

                    case "C":

                        return "C";

                    default:

                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");

                        continue;




                }
            }


        }
        static public string CinsiyetMi()
        {

            while (true)
            {

                Console.Write("Listelemek istediğiniz cinsiyeti girin(K / E):  ");
                string sube = Console.ReadLine().ToUpper();

                switch (sube)
                {

                    case "K":

                        return "K";

                    case "E":

                        return "E";


                    default:

                        Console.WriteLine("Yanlış bir değer girdiniz. Lütfen tekrar deneyin.");

                        continue;




                }
            }


        }

        static public bool SayiMi(string giris)
        {
            foreach (char item in giris)
            {
                if (!Char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }

        static public int SayiAl(string mesaj)
        {
            int sayi;

            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                }

            } while (true);





        }
        static public bool HarfMi(string veri)
        {
            veri = veri.ToUpper();

            for (int i = 0; i < veri.Length; i++)
            {
                int kod = (int)veri[i];
                if ((kod >= 65 && kod <= 90) != true)
                {
                    return false;
                }
            }

            return true;
        }
        static public DateTime DogumTarihiAl(string mesaj)
        {
            DateTime giris;

            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    giris = DateTime.Parse(Console.ReadLine());

                    break;


                }
                catch (Exception e)
                {

                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");

                }

               


            }

            return giris;
               

           



        }
    }
}
