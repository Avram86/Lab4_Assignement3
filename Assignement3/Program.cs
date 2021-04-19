using System;

namespace Assignement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignement3();
        }
        public static void Assignement3()
        {
            Console.WriteLine("Please write a phrase:");
            var phrase = Console.ReadLine();

            Console.WriteLine("Please write a word!");
            var word = Console.ReadLine();

            int nrRepetari = 0;

            bool apareSecventa = phrase.Contains(word);


            if (phrase.Contains(word) == true)
            {
                do
                {
                    nrRepetari++;
                    phrase = phrase.Substring(phrase.IndexOf(word) + word.Length);
                    apareSecventa = phrase.Contains(word);
                } while (apareSecventa == true);
            }

            Console.WriteLine($"Secventa cautata apare de {nrRepetari} ori!");

        }
    }
}
