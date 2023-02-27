namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]); // stack bizim için iyi bir veri türü değil
            //Console.WriteLine(isimler[2]); // o yüzden kolleksiyon kullanıyoruz
            //isimler = new string[4];
            //isimler[3] = "Ahmet";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

                //generic yapı         List<Tipi> ismi = Heap içine atma işlemi
            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            



        }
    }
}