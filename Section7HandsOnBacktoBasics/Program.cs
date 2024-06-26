namespace Section7HandsOnBacktoBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MultiplyFromSample sample = new MultiplyFromSample();
            sample.MultiplyMethod();

            MultiplyNumbers mul = new MultiplyNumbers();
            Console.WriteLine("### Entre com Primeiro Numero ###");
            mul.A =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("### Entre com Segundo Nunero ###");
            mul.B = Convert.ToDouble(Console.ReadLine());
            mul.Conta();
            Console.WriteLine("num1 {0} Vezes num2 {1} Igual {2}", mul.A , mul.B, mul.result);
        }
    }
    public class MultiplyNumbers
    {
        public double A {  get; set; }
        public double B { get; set; }
        public double result { get; set; }
        public void Conta()
        {
            result = A * B;
        }
    }
    public class MultiplyFromSample
    {
        public void MultiplyMethod()
        {
            int num1, num2, multiplied;

            Console.WriteLine("Please Enter Frirt Number!!!");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number!!!");
            num2 = Convert.ToInt32(Console.ReadLine());

            multiplied = num1 * num2;

            Console.WriteLine(num1 + "Multiplied by" +num2 + "Is" +  multiplied);

            Console.WriteLine();
        }
    }
}
