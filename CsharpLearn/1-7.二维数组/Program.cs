namespace _1_7.二维数组
{
    internal class Program
    {
        //array.getlength(维度)，比如int[,] arr = new int[4,5]则arr这个二维数组有两维，第一维0对应4行，第二维1对应列
        static void Print2DArray(int[,] a2d)
        {
            for (int i = 0; i < a2d.GetLength(0); i++)
            {
                for (int j = 0; j < a2d.GetLength(1); j++)
                {
                    Console.Write($"{a2d[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Generate2DArray(int[,] array2d)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = i * array2d.GetLength(1) + j;
                }
            }
        }
        static void Main(string[] args)
        {
            //二维数组定义
            int[,] map = new int[2, 8]{ {1, 2, 3, 4, 5, 6, 7, 8 },
                                      {9, 10, 11, 12, 13, 14, 15, 16} };
            int[,] array2d = new int[4, 5];
            Print2DArray(array2d);
            Generate2DArray(array2d);
            Print2DArray(array2d);
        }
    }
}