using System;
using System.Collections.Generic;
using System.IO;

namespace VoteCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Dictionary<string, int> votes = new Dictionary<string, int>();
            
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(',');
                        
                        if(votes.ContainsKey(s[0]))
                            votes[s[0]] += int.Parse(s[1]);
                        else
                            votes[s[0]] = int.Parse(s[1]);
                    }

                    foreach (var i in votes)
                        Console.WriteLine(i.Key + ": " + i.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
