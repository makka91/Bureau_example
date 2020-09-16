using System;

class Program
{
    static void Main(string[] args)
    {
        string contents = "";
        int counter = 1;

        System.Console.WriteLine("Öppnar byrålådan...");

        while (true)
        {
            System.Console.Write("Vad vill du lägga i lådan: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q" || input.ToLower() == "inget")
            {
                Console.WriteLine("Stänger byrån...");
                Environment.Exit(0);
            }
            else if (input.ToLower() == "t" || input.ToLower() == "töm")
            {
                System.Console.WriteLine("Tömmer byrån på " + contents);
                contents = "";
                counter = 1;
            }
            else
            {
                if (contents.Length == 0)
                {
                    contents = input.Trim();
                }
                else if (counter >= 3)
                {
                    Console.WriteLine("Nu är det fullt i lådan som innehåller " + counter + " saker");
                }
                else
                {
                    contents = contents + " och " + input.Trim();
                    counter++;
                }
            }

            Console.WriteLine($"Byrån innehåller nu {contents}");
        }
    }
}