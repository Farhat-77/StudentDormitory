using System;

namespace StudentDormitory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество нуждающихся в общежитии:");
            int n = Convert.ToInt32(Console.ReadLine());
            ListStudent[] nz = new ListStudent[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0} Нуждаюшиийся:", i + 1);
                Console.WriteLine("Имя:");
                nz[i].name = Console.ReadLine();
                Console.WriteLine("Номер группы:");
                nz[i].group = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Доход:");
                Console.WriteLine("Средний балл:");
                nz[i].score = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Доход:");
                nz[i].income = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.WriteLine("Введите количество мест в общежитии:");
            int m = Convert.ToInt32(Console.ReadLine());
            int mrot = 5000;
            for (int i = 0; i < n; i++)
            {
                if (nz[i].income <= mrot)
                    Console.WriteLine("{0} - Комната выдана!", nz[i]);

                if (nz[i].income > mrot)
                {

                }
            }
        }
    }
}
