using System;

namespace InlämningsUppgift_._nivå1_._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer;

            Console.WriteLine("Skriv ett positivt tal. Om du vill avsluta så behöver du skriva ett negativt tal");

            while (true)
            {
                Console.WriteLine("Ange ett tal: ");
                nummer= int.Parse(Console.ReadLine());

                if (nummer < 0)
                {
                    Console.WriteLine("Du har skrivit ett negativt tal. Programmet har avslutats");
                    break;
                }
            }
        }
    }
}
