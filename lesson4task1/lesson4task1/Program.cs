using System;

namespace lesson4task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйстя, введите 20 чисел, которые хотите проверить ");
            int a = 0;
           int [] monolith = new int[20];
            monolith[0] = Convert.ToInt32(Console.ReadLine());
            monolith[1] = Convert.ToInt32(Console.ReadLine());
            monolith[2] = Convert.ToInt32(Console.ReadLine());
            monolith[3] = Convert.ToInt32(Console.ReadLine());
            monolith[4] = Convert.ToInt32(Console.ReadLine());
            monolith[5] = Convert.ToInt32(Console.ReadLine());
            monolith[6] = Convert.ToInt32(Console.ReadLine());
            monolith[7] = Convert.ToInt32(Console.ReadLine());
            monolith[8] = Convert.ToInt32(Console.ReadLine());
            monolith[9] = Convert.ToInt32(Console.ReadLine());
            monolith[10] = Convert.ToInt32(Console.ReadLine());
            monolith[11] = Convert.ToInt32(Console.ReadLine());
            monolith[12] = Convert.ToInt32(Console.ReadLine());
            monolith[13] = Convert.ToInt32(Console.ReadLine());
            monolith[14] = Convert.ToInt32(Console.ReadLine());
            monolith[15] = Convert.ToInt32(Console.ReadLine());
            monolith[16] = Convert.ToInt32(Console.ReadLine());
            monolith[17] = Convert.ToInt32(Console.ReadLine());
            monolith[18] = Convert.ToInt32(Console.ReadLine());
            monolith[19] = Convert.ToInt32(Console.ReadLine());
            if(monolith[0]%3 == 0) { a++; }
            else {a = a;}
            if (monolith[1] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[2] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[3] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[4] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[5] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[6] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[7] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[8] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[9] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[10] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[11] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[12] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[13] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[14] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[15] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[16] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[17] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[18] % 3 == 0) { a++; }
            else { a = a; }
            if (monolith[19] % 3 == 0) { a++; }
            else { a = a; }
            Console.Write($"Подходящих под заданный параметр пар чисел всего, " + a/2);
            Console.ReadKey();
        }
    }
}
