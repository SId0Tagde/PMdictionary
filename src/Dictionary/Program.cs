// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
namespace Dictionary{

    public class Program {

        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<long, string>();
            addyearandPM(dictionary);
            Console.WriteLine();
            printDictionary(dictionary.AsEnumerable());

            try
            {

                //Finds Prime Minister on 2004.
                Console.WriteLine("Prime Minister of year 2004 is ");
                if (dictionary.ContainsKey(2004))
                { Console.Write(dictionary.GetValueOrDefault(2004) + "\x0A"); }

                //Add current year and PM.
                Console.WriteLine();
                addcurrentyearandPM(dictionary);
            }
            catch (NullReferenceException e)
            {
                System.Console.WriteLine(e.Data);
            }

            //Sorting the dictionary in reversed order
            Console.WriteLine();
            Console.WriteLine("sorting and printing the dictionary in reversed order");
            var reversed = dictionary.Reverse();
            printDictionary(reversed);

        }

        private static void addcurrentyearandPM(SortedDictionary<long, string> dictionary)
        {   
            Console.WriteLine(" Add current year and PM .");
            Console.WriteLine("Enter year");
            var year = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of Prime Minister.");
            var PMname = Console.ReadLine();
            if (!dictionary.ContainsKey(year)) { dictionary.Add(year, PMname); }
        }

        private static void printDictionary(IEnumerable<KeyValuePair<long, string>> dictionary)
        {   
            foreach (var (key, value) in dictionary)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }

        private static void addyearandPM(SortedDictionary<long, string> dictionary)
        {
            for (int i = 0; i < 3; i++)
            {  try{
                Console.WriteLine("Enter year.");
                var year = long.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name of Prime Minister.");
                var PMname = Console.ReadLine();
                if(!dictionary.ContainsKey(year))
                dictionary.Add(year, PMname); 
                }catch(NullReferenceException e ){
                     System.Console.WriteLine("Null arguments");;
                }
            }
        }
    }
}