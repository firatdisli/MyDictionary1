using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            Console.WriteLine("Oluşturulan Dictionary de " + myDictionary.Lenght + " elaman vardır");
            myDictionary.Add("Play", "Oynamak");
            myDictionary.Add("Read", "Okumak");
            Console.WriteLine("Oluşturulan Dictionary de " + myDictionary.Lenght + " elaman vardır");
            myDictionary.Add("Software", "Yazılım");
            Console.WriteLine("-------Kelimeler----------");
           
        }
    }
}
