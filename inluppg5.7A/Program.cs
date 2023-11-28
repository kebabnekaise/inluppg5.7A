using System;

namespace inluppg5_7A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lander = new string[] { "1. Kina", "2. Indien", "3. USA", "4. Indonesien", "5. Pakistan" };    

            foreach (string land in lander)
            {
                Console.WriteLine(land);
            }

            Console.WriteLine("Skriv in siffran för landet som ska skrivas ut");
            string indecesInput = Console.ReadLine();

            string[] indeces = indecesInput.Split(' ');

            Console.WriteLine();
            for (int i = 0;  i < indeces.Length; i++)
            {
                Console.WriteLine(lander[int.Parse(indeces[i]) - 1]);
            }
        }
    }
}