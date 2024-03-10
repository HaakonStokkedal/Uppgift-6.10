namespace Uppgift_6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en sträng:");
            string text = Console.ReadLine();
            string[] ord = text.Split(' ');

            Console.WriteLine($"Det finns {AntalTalIText(ord)} tal i din string.");
            Console.ReadKey();
        }

        static int AntalTalIText(string[] strings)
        {
            int räknare = 0;
            foreach(string ord in strings)
            {
                if (double.TryParse(ord, out double value) == true)
                {
                    räknare++;
                }
            }
            return räknare;
        }
    }
}