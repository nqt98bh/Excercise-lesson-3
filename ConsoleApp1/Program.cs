using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Transactions;

class Lesson3
{
    private static void Main()
    {
        int number1 = 10;
        int number2 = 5;
        int number3 = 30;
        double Celsius = 25.0;


        int Sum = number1 + number2;
        Console.WriteLine(Sum);

        int Different = number1 - number1;
        Console.WriteLine(Different);

        int Product = number1 * number2;
        Console.WriteLine(Product);

        int Division = number1 / number2;
        Console.WriteLine(Division);

        int remainer = number1 % number2;
        Console.Write(remainer);

        int square = number1 * number1;
        Console.WriteLine(square);

        int average = (number1 + number2) / 2;
        Console.WriteLine(average);

        int average2 = (average * 2 + number3) / 3;
        Console.WriteLine(average2);

        double Fahrenheit = (Celsius * 9 / 5) + 32;
        Console.WriteLine(Fahrenheit);

        double length = 5; double width = 10;
        double area = length * width;
        Console.WriteLine(area);

        double Radius = 5;
        double VolumeOfSphere = 4 / 3 * Math.PI * Math.Pow(Radius, 3);
        Console.WriteLine(VolumeOfSphere);

        //Part12
        int num = 5;
        int result = CalculateFactorial(num);
        Console.WriteLine($"The factorial of {num} is {result}");
        static int CalculateFactorial(int num)
        {
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        //Part 13
        double principal = 1000; double rate = 0.05; int time = 5; int n = 1;
        double A = principal * Math.Pow(rate / n, n * time);
        Console.WriteLine($"compound interest is {A}");

        //Part 14
        double a = 1; double b = 5; double c = 6;
        SolveQuadraticEquation(a, b, c);

        static void SolveQuadraticEquation(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"The equation has two real solutions: x1 = {x1}, x2 = {x2}");

            }

            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"The equation has one real solution: x = {x}");
            }
            else
            {
                Console.WriteLine("The equation has no solution");

            }
        }
        //Part 15
        int x = 8;
        int fibonacci = Fibonacci(x);
        Console.WriteLine($"The {n}th Fibonacci number is: {fibonacci}");

        static int Fibonacci(int x)
        {
            if (x == 1)
            {
                return 1;

            }
            else if (x == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }

        }

        //Part 16
        int firstTerm = 3; int commonDifference = 2; int termNumber = 5;
        int NthTerm = firstTerm + (termNumber - 1) * commonDifference;
        Console.WriteLine($"the 5th term of the arithmetic sequence is {NthTerm}");

        //Part 17
        Comparison(10, 5);
        static void Comparison(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine($"num1({num1}) is greater than num2({num2})");
            }
            else
            {
                Console.WriteLine($"num1({num1}) is not greater than num2({num2})");

            }

        }

        //Part 18
        int GivenNumber = Convert.ToInt32(Console.ReadLine());
        if (GivenNumber <= 100)
        {
            Console.WriteLine($"The given number ({GivenNumber}) is less than 100");
        }
        else
        {
            Console.WriteLine($"The given number ({GivenNumber}) is greater than 100");
        }

        //Part 19
        int GivenNumber2 = Convert.ToInt32(Console.ReadLine());
        if (GivenNumber2 % 2 == 0 && GivenNumber2 >= 10)
        {
            Console.WriteLine($"The given number ({GivenNumber2}) is even and greater than 10");
        }

        //Part 20
        int GivenNumber3 = Convert.ToInt32(Console.ReadLine());
        if (GivenNumber3 % 3 == 0 || GivenNumber3 % 5 == 0)
        {
            Console.WriteLine($"The given number ({GivenNumber3}) is is divisible by either 3 or 5");

        }

        //Part 21
        int GivenNumber4 = Convert.ToInt32(Console.ReadLine());
        GivenNumber4 += 5;
        Console.WriteLine($"the increment result is {GivenNumber4}");

        //Part 22
        int GivenNumber5 = Convert.ToInt32(Console.ReadLine());
        GivenNumber5 %= 7;
        Console.WriteLine($"the remainder result is {GivenNumber5}");

    }

}
    
    

   
