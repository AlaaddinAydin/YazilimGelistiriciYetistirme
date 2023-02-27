using System.Data;

namespace DictionaryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int , string> dict = new Dictionary<int , string>();
            //dict.Add(1, "elma");
            //dict.Add(2, "armut");
            //dict.Add(3, "muz");

            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key);
            //}

            MyDictionary<int,string> myDictionary= new MyDictionary<int,string>();

            myDictionary.Add(1, "Ahmet");
            myDictionary.Add(2, "Mahmut");
            myDictionary.Add(3, "Osman");

            

            foreach (var item in myDictionary.ArrayK)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myDictionary.ArrayV)
            {
                Console.WriteLine(item);
            }


        }
    }
}