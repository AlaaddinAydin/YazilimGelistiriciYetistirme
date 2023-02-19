using System;
using YazıilimGelistiriciYetistirme;

internal class Program
{
    private static void Main(string[] args)
    {
        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyat = 15;
        urun1.Aciklama = "Amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyat = 70;
        urun2.Aciklama = "Diyarbakır karpuzu";

        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine(urun.Fiyat);
            Console.WriteLine("-----------");
        }

        Console.WriteLine("------Metotolar-----");

        //encapsulation
        SepetManager septeManager = new SepetManager();
        septeManager.Ekle(urun1);
        septeManager.Ekle(urun2);

        septeManager.Ekle2("Armut", "yeşil armut", 123,10);   
        septeManager.Ekle2("elma", "yeşil elma", 12,9);   
        septeManager.Ekle2("karpuz", "diyarbakır karpuzu", 13,8);
    }
}
