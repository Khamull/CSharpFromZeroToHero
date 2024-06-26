namespace CodeAlongCheckPalimdrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, revs = "";

            Console.WriteLine("Enter string");

            s = Console.ReadLine(); 

            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome \nEntered String Was" + s + "string reversed is" + revs);
            }
            else
            {
                Console.WriteLine("The String is not a Palindrome\nEntered String Was" + s + "and reverse string is" + revs);

            }
            Console.ReadLine();
        }
    }
}
