using System;
using System.IO;

namespace FruitAndVeggies
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitPath = @"C:\Users\admin\samples\fruit.txt";
            string[] veggieData = File.ReadAllLines(fruitPath);

            string veggiePath = @"C:\Users\admin\samples\veggie.txt";
            string[] fruitData = File.ReadAllLines(veggiePath);

            File.WriteAllLines(fruitPath, fruitData);
            File.WriteAllLines(veggiePath, veggieData);
        }
    }
}
