namespace ConsoleApp1
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            const int MAXLINES = 22;

            Console.Write("Bis zu welcher Zahl wollen Sie Primzahlen ausgeben? ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            while ((maxNumber <= 0))
            {
                Console.WriteLine("Die größte Zahl muss größer als 1 sein!");
                Console.Write("Bis zu welcher Zahl wollen Sie Primzahlen ausgeben:");
                maxNumber = int.Parse(Console.ReadLine());
            }

            var isPrime = CalcIsPrime(maxNumber);

            Console.WriteLine("Primzahlen von 1 - " + maxNumber + ":");
            int lineCounter = 0;
            for (int i = 2; i <= maxNumber; i++)
            {
                if (isPrime[i])
                {
                    Console.WriteLine(i);
                    lineCounter++;
                    if (lineCounter >= MAXLINES)
                    {
                        Console.WriteLine("<Eingabetaste für weiter>");
                        Console.ReadLine();
                        lineCounter = 0;
                    }
                }
            }
        }

        private static bool[] CalcIsPrime(int maxNumber)
        {
            var isPrime = new bool[maxNumber + 1];

            isPrime[0] = false; //0 ist keine Primzahl
            isPrime[1] = false; //1 ist keine Primzahl
            for (int i = 2; i <= maxNumber; i++)
            {
                isPrime[i] = true;
            }

            int maxCheck = (int)(Math.Sqrt(maxNumber));
            for (int i = 2; i <= maxCheck; i++)
            {
                if (isPrime[i])
                {
                    for (int multiplicator = 2; (multiplicator * i) <= maxNumber; multiplicator++)
                    {
                        isPrime[multiplicator * i] = false;
                    }
                }
            }

            return isPrime;
        }
    }
}
