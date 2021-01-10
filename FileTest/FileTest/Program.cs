using System;
using System.Globalization;
using System.IO;
using FileTest.Entities;

namespace FileTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] s = File.ReadAllLines(sourceFilePath);

                string folderPath = Path.GetDirectoryName(sourceFilePath);
                
                Directory.CreateDirectory(folderPath + @"\Out");
                
                using (StreamWriter sw = File.AppendText(folderPath + @"\Out\summary.csv"))
                {
                    foreach(string i in s)
                    {
                        string[] aux = i.Split(',');
                        Product p = new Product(aux[0], double.Parse(aux[1], CultureInfo.InvariantCulture), int.Parse(aux[2]));
                        sw.WriteLine(p.Name + "," + p.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
