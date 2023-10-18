using System;
using System.Diagnostics;

namespace Uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett meddelande");
            string meddelande = Console.ReadLine();

            Console.WriteLine("Skriv in ett heltal");
            int förskjutning = int.Parse(Console.ReadLine());

            for (int i = 0;i < meddelande.Length;i++)
            {
                for (int j = 0; j < förskjutning; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}