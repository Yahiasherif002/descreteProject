int num1, num2;
Console.WriteLine("Get All Perfect In Range of Between two Number");
Console.WriteLine("Enter the first number:");
num1 = (int)double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number:");
num2 = (int)double.Parse(Console.ReadLine());
Console.WriteLine(" the perfect number between " + num1 + " and " + num2);

for (int i = num1; i <= num2; i++)
{
    decimal sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
            sum = sum + j;
    }
    if (sum == i)
        Console.WriteLine("\t" + i);
}







