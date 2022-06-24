namespace _1_7_1.二维数组作业打印火车票
{
    internal class Program
    {
        static bool HasTicket = true;

        static int inputNum()
        {
            while (true)
            {
                string input = Console.ReadLine();
                input = input.Trim();
                int Num;
                bool success = int.TryParse(input, out Num);
                if (!success)
                {
                    Console.WriteLine("请输入数字");
                    continue;
                }
                return Num;
            }
        }
        static int inputRow()
        {
            while (true)
            {
                int inputRow = inputNum()-1;
                if (inputRow>2)
                {
                    Console.WriteLine("请输入正确的行数");
                }
                return inputRow;
            }
        }
        static int inputCol()
        {
            while (true)
            {
                int inputCol = inputNum()-1;
                if (inputCol > 3)
                {
                    Console.WriteLine("请输入正确的列数");
                }
                return inputCol;
            }
        }
        static void Print2DArray(bool[,] a2d)
        {
            for (int i = 0; i < a2d.GetLength(0); i++)
            {
                for (int j = 0; j < a2d.GetLength(1); j++)
                {
                    if (a2d[i,j])
                    {
                        Console.Write( $"{i+1}_{j+1}有票\t");
                    }
                    else
                    {
                        Console.Write($"{i+1}_{j+1}无票\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Generate2DArray(bool[,] array2d)
        {
            for (int i = 0; i < array2d.GetLength(0); i++)
            {
                for (int j = 0; j < array2d.GetLength(1); j++)
                {
                    array2d[i, j] = HasTicket;
                }
            }
        }

        static void Main(string[] args)
        {
            bool[,] tickets = new bool[3, 4];
            bool BuyAgain= true;
            while (BuyAgain)
            {
                Generate2DArray(tickets);
                Print2DArray(tickets);
                Console.WriteLine("您想购买第几行车票？");
                int i = inputRow();
                Console.WriteLine("您想购买第几列车票？");
                int j = inputCol();
                tickets[i, j] = false;
                Print2DArray(tickets);
                Console.WriteLine("是否继续购买");
                string buyagain = Console.ReadLine().Trim();
                if (true)
                {

                }

            }
        }
    }
}