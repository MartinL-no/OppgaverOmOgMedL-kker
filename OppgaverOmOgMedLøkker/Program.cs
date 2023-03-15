using System;

namespace OppgaverOmOgMedLøkker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oppgave1:");
            Oppgave1();

            Console.WriteLine("Oppgave2:");
            Oppgave2("Terje er kul");
        }
        static void Oppgave1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Terje er kul");
            }
        }
        static void Oppgave2(string input)
        {
            foreach (var character in input)
            {
                Console.WriteLine(character);
            }
        }
    }
}

