namespace GradingSystem
{
    internal class Program
    {
        //30. Exception Classes
        static void Main(string[] args)
        {
            int grade = 0;

            Console.WriteLine("Entre Grade");
            try
            {
                grade = Convert.ToInt32(Console.ReadLine());
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            if (grade >= 90) 
            {
                Console.WriteLine("Grade Is an A");            
            }
            else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("Grade Is an B");
            }
            else if(grade <80 &&  grade >= 70)
            {
                Console.WriteLine("Grade Is an C");
            }
            else if (grade <70 && grade >= 60)
            {
                Console.WriteLine("Grade Is an D");
            }
            else
            {
                Console.WriteLine("Grade Is an F!!!!!");
            }


            //Create a grading system with the scale of
            //100 - 90 = A
            /* 89 - 80 = B
               79 - 70 = C
               69 - 60 = D
               < 59 = F */
            bool w = true;
            int count = 0;
            while (w)
            {
                Console.WriteLine("Informe a Nota:");
                Grading grading = new Grading();
                try
                {
                    grading.A = Convert.ToInt32(Console.ReadLine());
                    if (grading.A < 0 || grading.A > 100)
                    {
                        Console.WriteLine("Input Invalido! Somente Notas Entre 0 e 100 são permitidas!");
                    }
                    else
                    {
                        grading.ComparadorGrading();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Input Invalido! Somente Numeros Inteiros! " + ex.Message + ex.InnerException);
                }
                finally 
                { 
                    Console.WriteLine("Finally Block");
                    Console.WriteLine("Current Count " + count);
                    if (count == 3)
                        w = false;
                    count++;
                }
            }
        }
    }
    public class Grading
    {
        public int A { get; set; }
        
        public void ComparadorGrading()
        {
            if (A >= 90)
            {
                Console.WriteLine("NOTA A");
            }
            else if (A <= 89 && A >= 80)
            {
                Console.WriteLine("NOTA B");
            }
            else if (A <= 79 && A >= 70)
            {
                Console.WriteLine("NOTA C");
            }
            else if (A <= 69 && A >= 60)
            {
                Console.WriteLine("NOTA D");
            }
            else
            {
                Console.WriteLine("F FU");
            }
        }
    }
}
