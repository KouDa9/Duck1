﻿using System;

namespace Duck1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck duck1 = new MallarDuck();
            RedheadDuck duck2 = new RedheadDuck();

            Duck[] mas = new Duck[] { duck1, duck2 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].display());
                Console.WriteLine(mas[i].swim());
                Console.WriteLine(mas[i].quack());
            }

            Console.ReadKey();
        }
    }
}
