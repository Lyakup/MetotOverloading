using System;

namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Succesful");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("UnSuccesful");
            }

            Metot instance = new Metot();
            instance.Topla(4,5, out int toplamSonucu);
            instance.EkranaYazdir(toplamSonucu);


            int sayi1 = 546; int sayi2 = 765;
            instance.EkranaYazdir(sayi1, sayi2);
        }
    }

    class Metot
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+ b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri.ToString());

        }

        public void EkranaYazdir(int a, int b)
        {
            Console.WriteLine(Convert.ToString(a+b));

        }
    }
}
