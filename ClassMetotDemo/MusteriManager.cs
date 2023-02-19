using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public Musteri MusteriEkle(int ID,string ad , string soyad)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = ad;
            musteri.Soyadi = soyad;
            musteri.Id = ID;
       

            return musteri;

        }

        public void MusteriListele(Musteri[] musterliler)
        {
            foreach(Musteri musteri in musterliler)
            {
                Console.WriteLine(musteri.Adi);
            }
        }

        
       
       
    }
}
