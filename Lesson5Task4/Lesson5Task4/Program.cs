using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson5Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            var answer = from l in list
                         where l.Contains('2')
                         orderby new Regex("2").Matches(l).Count descending
                         select l.Substring(0, l.LastIndexOf(' ') - 4);
            foreach (var a in answer)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
