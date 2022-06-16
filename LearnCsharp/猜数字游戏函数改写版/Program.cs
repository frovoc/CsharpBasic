namespace 猜数字游戏函数改写版
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
                    Console.WriteLine("请输入正确格式的数字");
                    continue;
                }
                return num;
            }
        }
        static int RandomNum(int a, int b)
        {
            Random random = new Random();
            return random.Next(a, b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入AI生成数字的最小值");
            int min = InputNum();
            Console.WriteLine("请输入AI生成数字的最大值");
            int max = InputNum();
            int ai = RandomNum(min,max);
            Console.WriteLine($"作弊：{ai}");
            Console.WriteLine("请输入你猜的结果，并在回车后继续");
            int you = InputNum();
            int i = 1;
            while (ai != you)
            {
                if (you > ai)
                {
                    Console.WriteLine("Tip：偏大");
                    Console.WriteLine("请重新输入你猜的结果，并在回车后继续");
                    you = InputNum();
                    i++;
                }
                else
                {
                    Console.WriteLine("Tip：偏小");
                    Console.WriteLine("请重新输入你猜的结果，并在回车后继续");
                    you = InputNum();
                    i++;
                }
            }
            Console.WriteLine($"恭喜你猜对了，您一共猜了{i}次");
        }
    }
}