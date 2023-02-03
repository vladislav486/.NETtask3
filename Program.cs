using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Hello! Please insert any symbols");
            string? userInput = Console.ReadLine();
            if (userInput == "")
            {
                Console.WriteLine("Please be careful and be sure you're inserting something. Let's try it again. Please insert symbols.");
                userInput = Console.ReadLine();
            }
            char[] splitSymbols = userInput.ToCharArray();
            List<int> numberOfSymbols = new List<int>();
            char currentSymbol = '\0';
            try
            {
                char testSymbol = splitSymbols.First();
                currentSymbol = testSymbol;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, something went wrong. The details: " + ex.Message);
            }
            void getTheNumber() { 
            foreach (char c in splitSymbols)
            {

                if (c != currentSymbol)
                {
                    count++;
                    currentSymbol = c;
                } else if (c == currentSymbol)
                {
                    count++;
                    numberOfSymbols.Add(count);
                    count = 0;
                }

            }
                count++;
                numberOfSymbols.Add(count);
                numberOfSymbols.Sort();
                Console.WriteLine($"The max number of different symbols is {numberOfSymbols.Last()}");
            }
            if (splitSymbols.Length > 0)
            {
                getTheNumber();
            }

            
        }
    }
}
