namespace _1_4.函数基础
{
    internal class Program
    {
        static int InputNum()
        {
            while (true)
            {
                string input = Console.ReadLine();
                input = input.Trim();
                int num;
                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("格式不正确，请输入正确的数字");
                    continue; //不执行下面的循环步骤并重新开始循环
                }
                return num; //结束循环并返回num
            }
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static float Divide(int a, int b)
        {
            //return (float)a / b;
            return a * 1.0f / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入a的值");
            int a = InputNum();
            Console.WriteLine("请输入b的值");
            int b = InputNum();

            Console.WriteLine($"a={a},b={b}");
            Console.WriteLine($"a+b={Add(a, b)}");
            Console.WriteLine($"a-b={Sub(a, b)}");
            Console.WriteLine($"a*b={Multiply(a, b)}");
            Console.WriteLine($"a/b={Divide(a, b)}");
        }
    }
}