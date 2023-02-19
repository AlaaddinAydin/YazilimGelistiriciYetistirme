namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            Console.WriteLine(sayı1);

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            Console.WriteLine(sayılar1[0]);
            // 999 

            // sayıasl veri tipleri = deger tiler sayısal görüntü

            // arrta class iterface = referans tip
            // stack  sayı1 = 10 sayı2 = 30  DEĞER AKTARILIR VE İRTİBAT KOPAR
            // heap   new dediğinde heapte bir yer açılır ve değer buraya yazılır
            //[10,20,30]   [100,200,300]  referans numarası eşitliyo değer değil
            //değer tip de değeri atarsın referans tipde adresi atarsın
            //C de pointer demek gibi bişi
        }
    }
}