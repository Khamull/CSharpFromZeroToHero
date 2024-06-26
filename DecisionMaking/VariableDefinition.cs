using System;
using CheckPalimdrome;

namespace DecisionMaking
{
    public enum Result
    {
        Distinction = 1,
        FirstClass,
        SecondClass
    }

    public delegate int FindRank(Enum result);

    public class ExampleEnum
    {
        public static int EnumExample(Enum result)
        {
            Result resultType = (Result)result;

            switch (resultType)
            {
                case Result.Distinction:
                    Console.WriteLine("Student passed with Rank 1 (Distinction)");
                    return 1;
                case Result.FirstClass:
                    Console.WriteLine("Student passed with Rank 2 (First Class)");
                    return 2;
                case Result.SecondClass:
                    Console.WriteLine("Student passed with Rank 3 (Second Class)");
                    return 3;
                default:
                    Console.WriteLine("Invalid result");
                    return -1;
            }
        }
    }
    public class CallDelegate()
    {
        public static void RunDelegate()
        {
            Console.WriteLine("########### Delegate Execution ###############");
            // Create an instance of ExampleEnum and assign its EnumExample method to the delegate
            FindRank findRankDelegate = new FindRank(ExampleEnum.EnumExample);

            // Use the delegate to find the rank for a specific result
            Result studentResult = Result.FirstClass;
            int rank = findRankDelegate(studentResult);

            // Output the result
            Console.WriteLine($"Delegate Rank for {studentResult}: {rank}");
        }
    }
    internal class VariableDefinition
    {
        static void Main(string[] args)
        {
            Palimdrome p = new Palimdrome();
            p.Execute();
            CallDelegate.RunDelegate();

            Console.WriteLine("############## MENU ##################");
            Console.WriteLine("1 - Teste de Looping");
            Console.WriteLine("2 - Teste de Square");
            Console.WriteLine("3 - Operadores Aritiméticos");
            Console.WriteLine("Digite sua Opção: ");
            int op = Convert.ToInt32(Console.ReadLine());
            if(op == 1)
            {
                Looping teste = new Looping();
                teste.ForLoopTest();
                teste.ForEachLoopTest();
                teste.whileloop();
                teste.DoWhileLoop();
            }            
            if(op == 2)
            {
                Square esquar = new Square();
                Console.WriteLine("Valor B:");
                esquar.B = Convert.ToInt32(Console.ReadLine());
                esquar.SquareRoot();
            }
            if(op == 3)
            {
                ArithmeticOperators ao = new ArithmeticOperators();
                Console.WriteLine("Valor A:");
                ao.A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Valor B:");
                ao.B = Convert.ToInt32(Console.ReadLine());
                ao.AddNumbers();
                ao.MultiplyNumber();
                ao.Subtracts();
                ao.increment();
                Console.WriteLine("Resutado Decresimo: " + ao.Decrement());
                ao.Divides();
                ao.Modulus();



                
            }

            ConstExemple();
            VariableDeclarations();
            ExecCalc();
            CompareNumbers ab = new CompareNumbers();
            Console.WriteLine("Valor A:");
            ab.A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor B:");
            ab.B = Convert.ToInt32(Console.ReadLine());
            ab.FindLargeNumber();
            ab.FindNimerNumber();
            ab.NumberEqualNumber();
            ab.EqualNumber();
            ab.NumerosDiferentes();
            ab.maiorouigual();

            VerifyUserNameAndPassword vp = new VerifyUserNameAndPassword();
            Console.WriteLine("Usuário:");
            vp._username = Console.ReadLine();
            Console.WriteLine("Senha:");
            vp._password = Console.ReadLine();
            if (vp.CompareUserNameAndPassword())
                Console.WriteLine("Usuário Logado");
            else
                Console.WriteLine("Usuário ou Senha Incorretos!");
        }

        static void EscreveNaTela(int a, double b, string c)
        {
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void VariableDeclarations()
        {
            //Variable Definition
            int a;
            double b;
            string c;

            //Variable Inicialization
            a = 10;
            b = 20.4;
            c = "Kelanni";
            Kelanni Kel = new Kelanni();
            Kel.a = 1;
            Kel.b = 2.5;
            Kel.c = "Kelanni";
            EscreveNaTela(Kel.a, Kel.b, Kel.c);
            EscreveNaTela(a, b, c);
        }
        static void ConstExemple()
        {
            //Const Declaration
            const int valueToMultiply = 4;
            int result;
            int a;
            a = 100;

            //Const Usage
            result = a * valueToMultiply;
            Console.WriteLine(result);
        }
        static void ExecCalc()
        {
            Calculator _calculator = new Calculator();
            _calculator.num1 = 1;
            _calculator.num2 = 2;
            _calculator.addnumbers();

            int result = _calculator.MultiplyNumber(4, 3);
            Console.WriteLine(result);


        }
    }
    public class Calculator
    {
        public int num1;
        public int num2;
        public int result;
        public void addnumbers()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }
        public int MultiplyNumber(int a, int b)
        {
            result = a * b;
            return result;

        }
    }
    public class Kelanni()
    {
        public int a { get; set; }
        public double b { get; set; }
        public string c { get; set; }
    }

    public class ArithmeticOperators()
    {
        //16. Section 3 Hands On : Simple Calculator (Assignment)
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }

        static ArithmeticOperators()
        {
            Console.WriteLine("#### Runing Arithmetic Operators ####");
        }

        public void AddNumbers()
        {
            Result = A + B;
            Console.WriteLine("Resultado Soma: " + Result.ToString());
        }
        public void MultiplyNumber()
        {

            Result = A * B;
            Console.WriteLine("Resutado Multiplicação: " + Result.ToString());
        }
        public void Subtracts()
        {

            Result = A - B;
            Console.WriteLine("Resutado subitração: " + Result.ToString());

        }
        public void Divides()
        {

            Result = A / B;
            Console.WriteLine("Resutado divisão: " + Result.ToString());
        }
        public void Modulus()
        {

            Result = A % B;
            Console.WriteLine("Resutado Modulo: " + Result.ToString());
        }
        public void increment()
        {
            int c = A;
            ++c;
            Console.WriteLine("Resutado incremento: " + Convert.ToString(c));
        }
        public int Decrement()
        {
            int c = A;
            Result = --c;
            //Console.WriteLine("Resutado Decresimo: " + c.ToString());
            return Result;
        }
    }
    public class CompareNumbers()
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result { get; set; }

        static CompareNumbers()
        {
            Console.WriteLine("#### Runing Compare Numbers ####");
        }
        public void FindLargeNumber()
        {
            if (A > B)
            {
                Result = A;
            }
            else
            {
                Result = B;
            }
            Console.WriteLine("Largest Number: " + Result);
        }
        public void FindNimerNumber()
        {
            if (A < B)
            {
                Result = A;
            }
            else
            {
                Result = B;
            }
            Console.WriteLine("Nimer Number: " + Result);
        }
        public void EqualNumber()
        {
            string resultado = "";
            if (A == B)
            {
                resultado = "IGUAL!";
            }
            else
            {
                resultado = "NÃO IGUAL!";
            }
            Console.WriteLine(resultado);
        }
        public void NumerosDiferentes()
        {
            if (A != B)
                Console.WriteLine("diferente");
            else
                Console.WriteLine("igual");
        }
        public void NumberEqualNumber()
        {
            Console.WriteLine("A é Menor ou Igual ao do B ");
            if (A <= B)
            {
                Console.WriteLine("verdade");
            }
            else
            {
                Console.WriteLine("falso");
            }
            //Ternário
            var teste = A <= B ? "Verdade" : "Falso";
            Console.WriteLine("A é Menor ou Igual ao do B? {0}",teste);

        }
        public void maiorouigual()
        {
            if (A >= B)
            {
                Console.WriteLine("verdade");
            }
            else
            {
                Console.WriteLine("falso ");
            }
            Console.WriteLine("A é Maior ou Igual ao B ");

        }
        
    }
    public class VerifyUserNameAndPassword()
    {
        private string UserName;
        private string Password;
        private string _UserName = "Kelanni";
        private string _Password = "A123456";
        public string _password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string _username
        {
            get { return UserName; }
            set { UserName = value; }
        }
        static VerifyUserNameAndPassword()
        {
            Console.WriteLine("#### Logical Operatos ####");
        }

        public bool CompareUserNameAndPassword()
        {
            if (!string.IsNullOrEmpty(_password) && !string.IsNullOrEmpty(_username))
            {
                if (_password == Password || _username == UserName)
                    return true;
            }
            return false;
        }
    }
    //10. Section 2 Hands On : Squared (Assignment )
    public class Square()
    {
        static Square()
        {
            Console.WriteLine("### Esquar root ###");
        }
        public double B { get; set; }
        public double n;

        public void SquareRoot ()
        {
            n =Math.Sqrt(B);
            Console.WriteLine("### Root ### " + n);

        }
    }
    //For loop
    class Looping
    {
        public void ForLoopTest()
        {

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("value of ForLoop: {0}", i);
            }
        }
        public void ForEachLoopTest()
        {
            int x = 0;
            int[] Value = new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
            Console.WriteLine("Total Items in Array is: " + Value.Count());
            string message = "value of ForEachLoop: {0} | Index is: {1}";
            foreach (var i in Value)
            {
                Console.WriteLine(message, i, x);
                x++;
            }
        }
        public void whileloop()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("value of Whileloop: " + i);
                i++;
            }
        }
        public void DoWhileLoop()
        {
            int i = 0;

            do
            {
                Console.WriteLine(" value of DoWhileloop: {0}", i); i++;
            } while (i <= 10);
        }                      
    }   
}
