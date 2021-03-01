using System;
using System.Collections.Generic;

namespace Homework_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stockroom<string> myStock = new Stockroom<string>();


            myStock.Add("Green Bottle");
            myStock.Add("White Bottle");
            myStock.Add("Brown Bottle");
            

            foreach (var item in myStock)
            {
                Console.WriteLine(item);
            }

            myStock.RemoveAt(1);
            foreach (var item in myStock)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
