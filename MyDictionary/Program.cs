using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> MyCars = new MyDictionary<string, int>();

            MyCars.Add("BMW", 2020);
            MyCars.Add("AUDİ", 2005);
            MyCars.Add("MERCEDES", 2018);

            Console.WriteLine("Car : " + MyCars.Keys[0] + "     Year of construction : " + MyCars.Values[0]);
            Console.WriteLine("Car : " + MyCars.Keys[1] + "     Year of construction : " + MyCars.Values[1]);
            Console.WriteLine("Car : " + MyCars.Keys[2] + "     Year of construction : " + MyCars.Values[2]);
            Console.ReadLine();
        }
    }
}
