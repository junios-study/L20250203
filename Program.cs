namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]
            //[][][][][][][][][][]

            int[,] data = new int[10, 10];

            int number = 1;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    data[j, i] = number++;
                }
            }

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(data[j, i].ToString() + "\t" );
                }
                Console.WriteLine();
            }
        }
    }
}
