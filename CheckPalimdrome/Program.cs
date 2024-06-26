namespace CheckPalimdrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Palimdrome teste = new Palimdrome();
                Console.WriteLine("### Check Palimdrome ###");
                Console.WriteLine("### Digite uma Palavra para Ver se é Palindromo! ###");
                teste.PalavraOriginal = Console.ReadLine();
                teste.InvertePalavra();
                teste.compara();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    public class Palimdrome
    {
        public string PalavraOriginal { get; set; }
        public string PalavraReverse { get; set; }

        public void InvertePalavra()
        {
            PalavraReverse = new string (PalavraOriginal.Reverse().ToArray());
        }
        public void compara()
        {
            if (PalavraOriginal.ToLower() == PalavraReverse.ToLower())
            {
                Console.WriteLine("{0} é Palimdromo!", PalavraOriginal);

            }
            else
            {
                Console.WriteLine("{0} Não é Palimdromo!", PalavraOriginal);
            }
        }

        public void Execute()
        {
            Console.WriteLine("### Check Palimdrome ###");
            Console.WriteLine("### Digite uma Palavra para Ver se é Palindromo! ###");
            PalavraOriginal = Console.ReadLine();
            InvertePalavra();
            compara();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
