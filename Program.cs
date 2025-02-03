namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----*
            //---**
            //--***
            //-****
            //*****

            int size = 10;

            for (int j = 1; j <= size; j++)
            {
                for (int i = 1; i <= size - j; i++)
                {
                    Console.Write(' ');
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }



        }
    }
}
