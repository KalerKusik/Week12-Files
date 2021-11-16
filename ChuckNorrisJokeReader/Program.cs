using System;
using System.IO;

namespace ChuckNorrisJokeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of jokes:");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(userNumber);
        }

        private static void GetJokes(int jokesNumber)
        {
            string filePath = @"C:\Users\admin\samples\chuck.txt";
            string[] jokesAboutChuck = File.ReadAllLines(filePath);

            if (jokesNumber > jokesAboutChuck.Length)
            {
                jokesNumber = jokesAboutChuck.Length;
            }
            else if (jokesNumber < 0)
            {
                jokesNumber = 1;
            }

            for (int i = 0; i < jokesNumber; i++)
            {
                Console.WriteLine(jokesAboutChuck[i]);
            }
        }
    }
}