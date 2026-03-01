/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter your second number: ");
        string input2 = Console.ReadLine();

        DivideStrings(input1, input2);
    }

    static void DivideStrings(string s1, string s2)
    {
        try
        {
            int num1 = int.Parse(s1);
            int num2 = int.Parse(s2);

            int result = num1 / num2;

            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: One or both inputs were not valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide a number by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error has occured: {ex.Message}");
        }
    }
}