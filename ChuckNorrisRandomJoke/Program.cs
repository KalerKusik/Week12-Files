using System;
using System.IO;

namespace ChuckNorrisRandomJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRandomJoke();
            //string filePath = @"C:\Users\admin\samples\chuck.txt";
            //string[] jokesAboutChuck = File.ReadAllLines(filePath);

            //Random rnd = new Random();
            //int randomIndex = rnd.Next(0, jokesAboutChuck.Length);
            //Console.WriteLine(jokesAboutChuck[randomIndex]);
        }
        public static string GetRandomJoke()
        {
            string filePath = @"C:\Users\admin\samples\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokesAboutChuck.Length);

            return jokesAboutChuck[randomIndex];
        }
    }
}

