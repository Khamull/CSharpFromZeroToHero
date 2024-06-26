
namespace UofGeeksCodeAlong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, sqrt = 0;

            Console.WriteLine("Please enter the number to be squared" );

            num = Convert.ToInt32(Console.ReadLine());

            sqrt = num * num;

            Console.WriteLine(num + " squared is " + sqrt);

            Console.WriteLine();
        }
    }
}
