using System.Net.NetworkInformation;

namespace Repeating_Numbers
{
    class Program
    {
        static void Main(string[]args)
        {
            int[] duplicateNumberList = new int[] { 1, 4, 3, 4, 5, 7, 7, 8, 9, 10 }; // array of numbers
            List<int> duplicates = new List<int>();

            Array.Sort(duplicateNumberList);
            

            for (int i = 0; i < duplicateNumberList.Length-1; i++)
            {
               
                if (duplicateNumberList[i] == duplicateNumberList[i+1])
                {
                    if (!duplicates.Contains(duplicateNumberList[i]))
                    {
                        duplicates.Add(duplicateNumberList[i]);
                    }
                }

                
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tThe Duplicate Numbers:");
            Console.WriteLine("=======================================");
            foreach (var item in duplicates)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================");

            Console.ReadLine();
        }
    }
}