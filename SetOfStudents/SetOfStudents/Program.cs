using System;
using System.Collections.Generic;

namespace SetOfStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            HashSet<int> studentsA = new HashSet<int>(); 

            for(int i = 0; i < a; i++)
                studentsA.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            HashSet<int> studentsB = new HashSet<int>();

            for (int i = 0; i < b; i++)
                studentsB.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            HashSet<int> studentsC = new HashSet<int>();

            for (int i = 0; i < c; i++)
                studentsC.Add(int.Parse(Console.ReadLine()));

            HashSet<int> total = new HashSet<int>(studentsA);
            total.UnionWith(studentsB);
            total.UnionWith(studentsC);

            Console.WriteLine("Total students: " + total.Count);
        }
    }
}
