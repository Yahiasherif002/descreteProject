using System.Runtime.ConstrainedExecution;
using System;
using Microsoft.VisualBasic.FileIO;

int num1, num2,div;
div = 0;
Console.WriteLine("Get All prime numbers In Range of Between two Number");
Console.WriteLine("Enter the first number:");
num1 = (int)double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
num2 = (int)double.Parse(Console.ReadLine());
Console.WriteLine(" the prime number between " + num1 + " and " + num2);

for (int i = num1; i < num2; i++)

{

    for (int j = 1; j < num2; j++)

    {

        if (i % j == 0)

        {

            div++;

        }

    }

    if (div == 2)

    {

        Console.WriteLine(i);

    }

    div = 0;

}

