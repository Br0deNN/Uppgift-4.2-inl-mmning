using System;
namespace inlämming_4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in ett heltal");
            int tal1 = int.Parse(Console.ReadLine());

            int HighTal = 0;
            while(true)
            {
                Console.WriteLine("Vill du skriva in ett heltal, y / n");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }

                Console.WriteLine("Skriv in ett heltal");
                int heltal = int.Parse(Console.ReadLine());
                if (heltal > HighTal || tal1 > HighTal)
                {
                    HighTal = heltal; HighTal = tal1;
                }
            }

            Console.WriteLine("Det högsta heltalet du skrev in är " + HighTal);
        }
    }
}