﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
//  
Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
             A(n, m);
           
            
            static int A(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return A(n - 1, 1);
                if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
                return A(n,m);
                 Console.WriteLine(A(2, 3));
            }
            Console.ReadKey();
            // Я понимаю, что надо вывести в консоль, но я не понимаю как это сделать. Но это направление кода верное или совсем не то.

