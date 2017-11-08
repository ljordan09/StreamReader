using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Countries.cs
{
    
    class CountriesTextFile
    {
        
        public static StreamReader sr = new StreamReader("Countries.txt");
        public static ArrayList Country = new ArrayList();
        private string country;

        public CountriesTextFile(string country)
        {
            this.country = country;
        }

        public static ArrayList readFromFile(string file)
        {
    
            ArrayList countries = new ArrayList();

            while (true)
                
            {
                //read in a line
                string line = sr.ReadLine();
                if (line == null || line == "")
                {
                    break;
                }
                else
                {
                    Country.Add(line);
                }
               
            }
            sr.Close();
             
            return Country;
        }

        public static void writeToFile(string file, ArrayList Country)
        {
            StreamWriter writeFile = new StreamWriter(file, false);
            foreach (string entry in Country)
            {
                writeFile.WriteLine(Country);
            }
            writeFile.Close();

        }
        

    }
}

