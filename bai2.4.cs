﻿using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap n:");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write("$");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        for (int i = 1; i <= n; i++)
        {
            for (int j = n; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}