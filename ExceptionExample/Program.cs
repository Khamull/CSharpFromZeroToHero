namespace ExceptionExample
{
    //30. Exception Classes
    public class TemIsZeroException : Exception
    {
        public TemIsZeroException(string message) : base(message) { }
    }
    internal class TestTemperature
    {
        static void PrintTemperature(int iTemperature)
        {
            if (iTemperature == 0)
                throw (new TemIsZeroException("Zero Temperature"));
            else
                Console.WriteLine("temperature: {0}", iTemperature);
        }
        static void Main(string[] args)
        {
            try
            {
                PrintTemperature(0);
            }
            catch (TemIsZeroException e)
            {
                Console.WriteLine(" TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }

    }
    //public class TemIsZeroException : Exception
    //{
    //    public TemIsZeroException(string message) : base(message) { }
    //}
    //public class TestTemperature
    //{
    //    public static void PrintTemperature(int iTemperature)
    //    {
    //        if (iTemperature == 0)
    //            throw (new TemIsZeroException("Zero Temperature"));
    //        else
    //            Console.WriteLine("temperature: {0}", iTemperature);
    //    }
    //}
}

