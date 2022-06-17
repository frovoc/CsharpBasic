namespace while和for循环相关
{
    internal class Program
    {
        static int InputNum()
        {
            while (true)
            {
                string input = Console.ReadLine();
                int num;
                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("请输入格式正确的数字");
                    continue;
                }
                return num;
            }
        }
        static void Main(string[] args)
        {
            //while循环
            //1+2+3+4+....+1000
            //int a = 0;
            //int sum = 0;
            //while (a < 1000)
            //{
            //    a = a + 1;
            //    sum = sum + a;
            //}
            //经典写法，分段解决问题
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    input = input.Trim();
            //    if (input == "end")
            //    {
            //        break;
            //    }
            //    int inputnum;
            //    bool success = int.TryParse(input, out inputnum);
            //    if (!success)
            //    {
            //        Console.WriteLine("请输入格式正确的数字");
            //        continue;
            //    }

            //    Console.WriteLine($"{inputnum}* 2 = {inputnum * 2}");
            //}
            //continue的等价写法
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    input = input.Trim();
            //    if (input == "end")
            //    {
            //        break;
            //    }
            //    int inputnum;
            //    bool success = int.TryParse(input, out inputnum);
            //    if (!success)
            //    {
            //        Console.WriteLine("请输入格式正确的数字");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputnum}* 2 = {inputnum * 2}");
            //    }                
            //}
            //for循环累加
            //Console.WriteLine("请输入循环次数，从0开始循环");
            //int length = InputNum();
            //int sum =0;
            //for (int i = 1; i <= length; i++)
            //{
            //   sum = sum + i;
            //}
            //Console.WriteLine(sum);
            //for循环累乘
            //Console.WriteLine("请输入循环次数（算那个数字的阶乘）");
            //int length = InputNum();
            //int sum =1;
            //for (int i = 1; i <= length; i++)
            //{
            //    sum = sum * i;
            //}
            //Console.WriteLine(sum);
            //for循环嵌套打印表格
            //Console.WriteLine("请输入行数");
            //int row = InputNum();
            //Console.WriteLine("请输入列数");
            //int col = InputNum();
            //for (int a = 1; a <= row; a++)
            //{
            //    for (int b = 1; b <= col; b++)
            //    {
            //        Console.Write($"{a}_{b}\t");
            //    }
            //    Console.WriteLine();
            //}
            //for循环打印99乘法表
            //for (int a = 1; a <= 9; a++)
            //{
            //    for (int b = 1; b <= 9; b++)
            //    {
            //        Console.Write($"{a}*{b}={a*b}\t");
            //    }
            //    Console.WriteLine();
            //}
            //for循环打印直角三角形
            Console.WriteLine("请输入左直角三角形高度");
            int highLL = InputNum()+1;
            Console.WriteLine();
            for (int i = 0; i < highLL; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //for循环打印等腰三角形
            Console.WriteLine();
            Console.WriteLine("请输入等腰三角形高度，请输入奇数");
            int highD = (InputNum()+1)/2;
            Console.WriteLine();
            for (int i = 0; i < highD; i++)
            {
                for (int a = 0; a < i+1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = highD; i >0 ; i--)
            {
                for (int a = i; a > 0; a--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //for循环打印右直角三角形
            Console.WriteLine();
            Console.WriteLine("请输入右直角三角形高度");
            int highLR = InputNum()+1;
            Console.WriteLine();
            for (int i = 0; i < highLR; i++)
            {
                for (int a = highLR-i; a >0 ; a--)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < i; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //for循环打印正三角形
            Console.WriteLine();
            Console.WriteLine("请输入正三角形高度");
            int highZ = InputNum() + 1;
            int widthZ = highZ * 2 - 1;
            int midW = (widthZ + 1) / 2;
            Console.WriteLine();
            for (int i = 1; i < highZ; i++)
            {
                for (int a = midW - i; a > 0; a--)
                {
                    Console.Write(" ");
                }
                for (int b = 0; b < 2*i-1; b++)
                {
                    Console.Write("*");
                }
                for (int c = midW - i; c>0; c--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}