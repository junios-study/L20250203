using static System.Runtime.InteropServices.JavaScript.JSType;

namespace L20250203
{
    internal class Program
    {
        static int[,] data = new int[10, 10];

        static void Initialze() //PascalCase
        {
            int number = 1;

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    data[j, i] = number++;
                }
            }
        }

        static void Print()
        {
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(data[j, i].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Initialze();
            Print();
        }
    }
}
