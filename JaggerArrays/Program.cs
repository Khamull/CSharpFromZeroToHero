namespace JaggerArrays
{
    internal  class Program
    {
        static unsafe void Main()
        {
            const int arraySize = 30;
            int* fib = stackalloc int[arraySize];
            int* p = fib;
            // The sequence begins With 1,1.
            *p++ = *p++ = 1;
            for (int i = 2; i < arraySize; ++i, ++p)
            {
                // Sum the previous Two numbers.
                *p = p[-1] + p[-2];
            }
            for (int i = 0; i< arraySize; ++i)
            {
                Console.WriteLine(fib[i]);
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();





            String[][] stringJaggerArray = new String[3][];

            stringJaggerArray[0] = new string[3] {"Asia", "Africa", "America" };
            stringJaggerArray[1] = new string[5] {"India", "South Africa", "USA", "China", "Japan" };
            stringJaggerArray[2] = new string[5] {"New Delhi", "Johannesburg", "Washington", "Benjing", "Tokyo" };
            Console.WriteLine("Posição stringJaggerArray[1][0]: " + stringJaggerArray[1][0]);
            Console.WriteLine("Texto para Pesquisar:");
            string pesquisa = Console.ReadLine();
            #region ForEach Exemplo
            int jaggedArrayIndex = 0;
            foreach(var item in stringJaggerArray)
            {

                int index = 0;
                foreach(var subitem in item)
                {
                    if (subitem == pesquisa)
                    {
                        Console.WriteLine("{0} esta no Indice {1} da Posição {2}", pesquisa, index, jaggedArrayIndex);
                        break;
                    }
                    index++;
                }
                jaggedArrayIndex++;
            }
            #endregion

            for (int i = 0; i < stringJaggerArray.Count(); i++)
            {
                Console.WriteLine("stringJaggerArray[{0}]", i);
               for (int j = 0; j < stringJaggerArray[i].Length; j++)
               {
                    Console.WriteLine("stringJaggerArray[{0}][{1}]", i, j);
                    if (stringJaggerArray[i][j] == pesquisa)
                    {
                        Console.WriteLine( pesquisa + " Possição " + i + " "+ j); 
                    }
                    else
                    {
                        Console.WriteLine(pesquisa + " Possição " + i + " " + j + " Não Localizada!");
                    }
               }
            }
        }

    }
}
