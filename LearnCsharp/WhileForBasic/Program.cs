namespace WhileForBasic
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
            //经典写法，分段解决问题
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                int inputnum;
                bool success = int.TryParse(input, out inputnum);
                if (!success)
                {
                    Console.WriteLine("请输入格式正确的数字");
                    continue;
                } 
                
                Console.WriteLine(inputnum*2);
            }
        }
    }
}