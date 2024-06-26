using System;

namespace SimpleCalculator
{
    //17. Hands On Simple Calculator | Code Along
    internal class Program
    {
        static void Main(string[] args)
        {
            double num, num2;
            int choice;


            Console.WriteLine("Plase Enter your First Number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter your Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter your choice");
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("press 2 for subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        double addition = num + num2;
                        Console.WriteLine("Answer is" + addition);
                        break;
                    }
                case 2:
                    {
                        double subtraction = num + num2;
                        Console.WriteLine("Answer is" + subtraction);
                        break;
                    }
                case 3:
                    {
                        double Multiplication = num * num2;
                        Console.WriteLine("Answer is" +  Multiplication);
                        break;
                    }
                case 4:
                    {
                        double Division = num / num2;
                        Console.WriteLine("Answer is" + Division);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
