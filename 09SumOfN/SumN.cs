using System;

class SumN
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note: You may need to use a for-loop.
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("{0}", sum);
        
    }
}

