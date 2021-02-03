using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList <string,int> myList = new MyList<string, int>();
            myList.Add("Elma", 5);
            myList.Add("Portakal",4);
            myList.Add("Mandalina", 7);
            myList.Add("Cilek", 20);
            myList.Add("Erik", 15);
            for (int i=0; i < 4; i++)
            {
                Console.WriteLine("Urun adi: " + myList.Names[i] + "   Urun Fiyati: " + myList.Prices[i] + "TL");
            }
        }
    }
}
