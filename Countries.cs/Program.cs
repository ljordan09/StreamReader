using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Countries.cs
{
    class Program 
    {
        const string FILENAME = "countries.txt";
        static void Main(string[] args)
        {
            ArrayList entries;
            entries = CountriesTextFile.readFromFile("Countries.txt");

            bool repeat = true;
            while (repeat)

            {
                //create a menu with 3 options
                Console.WriteLine("\nWelcome to the Countries Maintenence Application\n");
                Console.WriteLine("Please choose: \n");
                Console.WriteLine("1 - See the list of countries");
                Console.WriteLine("2 - Add to the list of countries");
                Console.WriteLine("3 - Exit ");

                string input = Console.ReadLine().Trim();
                int number = 0;
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("You must enter 1, 2, or 3. Try again:\n ");
                    continue;
                }

                if (number == 1)
                {
                    //option 1 displays list countries
                    foreach (string countries in CountriesTextFile.Country)
                    {
                        Console.WriteLine(countries);
                    }
                    
                }

                else if (number == 2)
                {
                    ArrayList countries = CountriesTextFile.readFromFile(FILENAME);
                    
                    Console.Write("Type in a country:\n ");
                    string country = Console.ReadLine();

                    CountriesTextFile _countries = new CountriesTextFile(country);

                    countries.Add(_countries);

                    CountriesTextFile.writeToFile(FILENAME, countries);
                    break;

                    
                }
                else if (number == 3)
                {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Enter 1, 2, or, 3: \n");
                    repeat = true;
                }

               
            }

            
           
        }  



    }
}







            
            
            //option 2 prompts user to add country and it gets filed
            //option 3 goodbye


     