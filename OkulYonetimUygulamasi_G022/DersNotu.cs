using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class DersNotu
    {
        public DERSLER DersAdi;
        public int Notu;

        public DersNotu(DERSLER dersAdi, int notu)
        {
            this.DersAdi = dersAdi;
            this.Notu = notu;
        }

       public enum DERSLER
        {
            Türkçe,
            Matematik,
            Fizik,
            

        }

       
    }
}
