using System;

namespace Lesson5Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "Sobol97";
            Console.WriteLine("Please write login");
            string login = Console.ReadLine();

            if (login.Length < 2 || login.Length > 10)
            {
                Console.Write("Login is incorrect ");
            }
            if (Char.IsDigit(login[0]))
            {
                Console.Write("Login is incorrect ");
            }
            bool correct = true;

            for (int i = 0; i < login.Length; i++)
            {
                if (!Char.IsLetterOrDigit(login[i]))
                {
                   correct = false;
                    break;
                }
            }

            if (source == login && correct)
            {
               Console.Write("Login is correct");
            }
            else
            {
               Console.Write("Login is incorrect");
            }
        }
    }
}
