using System;

class Program
{
    public static void Main(string[] args)
    {
        int number;
      int number2;
      Console.WriteLine("Enter your number");
        number= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter your second number");
        number2= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("numbers are : {0} and {1}", number, number2);

       if (number > number2) {
      Console.WriteLine ("Your first number is greater then the second number");
    } else {
      Console.WriteLine ("Your second number is greater than your first");
    }
    }
} 
