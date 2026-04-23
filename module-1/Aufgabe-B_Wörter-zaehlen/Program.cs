namespace Aufgabe_B_Wörter_zaehlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drücken Sie eine beliebige Taste, um einen Satz einzugeben.");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Programm wird beendet...");
                    break;
                }

                Console.Write("Bitte geben Sie einen Satz ein: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Kein Satz eingegeben.\n");
                    continue;
                }

                Sentence sentence = new Sentence(input);

                Console.WriteLine($"Anzahl Wörter: {sentence.NumberOfWords}");
                Console.WriteLine($"Längstes Wort: {sentence.LongestWord}");
                Console.WriteLine($"Anzahl Vokale: {sentence.NumberOfVowels}");
                Console.WriteLine();

                Console.WriteLine("Mit ESC können Sie das Programm beenden.\n");
            }
        }
    }
}