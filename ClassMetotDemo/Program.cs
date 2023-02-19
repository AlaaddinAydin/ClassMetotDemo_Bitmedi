namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            

            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();

            musteri1 =  musteriManager.MusteriEkle(0, "Ahmet", "Okur");
            musteri2 =  musteriManager.MusteriEkle(1, "Muhmut", "Okur");

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };



            musteriManager.MusteriListele(musteriler);
        }
    }
}