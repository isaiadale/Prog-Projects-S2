using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int input = Convert.ToInt16(Console.ReadLine());

            sw.Start();
            long output = Fibonacci(input);
            sw.Stop();

            Console.WriteLine(output);
            Console.WriteLine(sw.ToString());
        }
        int[] sortedArray = new int[] {2, 5, 8, 12, 16, 23, 38, 45};

        static string laengstesWort(string satz)
        {
            if (satz == null) 
            {
                throw new ArgumentException();
            }

            string[] woerter = satz.Split(' ');
            string laenstesWort = string.Empty;

            foreach (string wort in woerter)
            {
                if (wort.Length > laenstesWort.Length)
                {
                    laenstesWort = wort;
                }
            }
            return laenstesWort;
        }

        static int Sum(int[] zahlen)
        {
            int sum = 0;

            for (int i = 0; i < zahlen.Length; i++)
            {
                sum += zahlen[i];
            }

            return sum;
        }

        static int Max(int[] zahlen)
        {
            if (zahlen.Length == 0)
            {
                throw new ArgumentException("Leeres Array nicht erlaubt!");
            }

            int max = 0;

            foreach(int zahl in zahlen)
            {
                if (zahl > max)
                {
                    max = zahl;
                }
            }

            return max;
        }

        static long Fibonacci(long glieder)
        {
            if (glieder == 1 || glieder == 2) return 1;

            return Fibonacci(glieder - 1) + Fibonacci(glieder - 2);
        }

       
    }
}
