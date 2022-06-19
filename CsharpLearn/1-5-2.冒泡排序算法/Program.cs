namespace _1_5_2.冒泡排序算法
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
        //static void Exchange(int a, int b)
        //{
        //    int temp;
        //    temp=a;
        //    a = b;
        //    b= temp;
        //    //Console.WriteLine($"{a},{b}");
        //}
        static void MaoPao(int[] array)
        {
            for (int j = array.Length; j >0 ; j--)
            {
                for (int i = 0; i < j-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }                 
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 3,9,50 };
            PrintArray(array);
            MaoPao(array);
            PrintArray(array);

        }
    }
}