﻿Console.WriteLine("Введите переменную a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную c");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max) max=b;
if (c>max) max=c;
Console.WriteLine(max);
