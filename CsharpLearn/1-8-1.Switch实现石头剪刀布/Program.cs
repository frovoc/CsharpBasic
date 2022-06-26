namespace _1_8_1.Switch实现石头剪刀布
{
    internal class Program
    {
        static Random random;
        enum 手势
        {
            无=0,
            石头=1,
            布,
            剪刀
        }
        enum 结果
        {
            胜利=1,
            平局,
            失败
        }
        static int inputNum()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim();
                int num;
                bool success = int.TryParse(input, out num);
                if (success)
                {
                    return num;
                }
                Console.WriteLine("请输入数字");
            }
        }
        static 手势 PlayerInput()
        {
            Console.WriteLine("请出招，1、石头；2、布、3剪刀");
            int playerNum;
            while (true)
            {
                playerNum = inputNum();
                switch (playerNum)
                {   
                    case 1:
                        Console.WriteLine("您出了石头");
                        return 手势.石头;
                    case 2:
                        Console.WriteLine("您出了布");
                        return 手势.布;
                    case 3:
                        Console.WriteLine("您出了剪刀");
                        return 手势.剪刀;
                    default:
                        Console.WriteLine("请输入正确的数字");
                        continue;
                }
            }
        }
        static 手势 AiInput()
        {
            random = new Random();
            int AiRandomNum = random.Next(1, 4);
            switch (AiRandomNum)
            {
                case 1:
                    Console.WriteLine("AI出了石头");
                    return 手势.石头;
                case 2:
                    Console.WriteLine("AI出了布");
                    return 手势.布;
                case 3:
                    Console.WriteLine("AI出了剪刀");
                    return 手势.剪刀;
                default :
                    break;
            }
            return 手势.无;
        }
        static 结果 Pk(手势 s1,手势 s2)
        {
            if (s1 == s2)
            {
                Console.WriteLine("平局");
                return 结果.平局;
            }else if((s1 == 手势.石头 && s2==手势.剪刀)||(s1 == 手势.布 && s2==手势.石头)||(s1 == 手势.剪刀 && s2==手势.布))
            {
                Console.WriteLine("胜利");
                return 结果.胜利;
            }
            else
            {
                Console.WriteLine("失败");
                return 结果.失败;
            }
        }
        static void Main(string[] args)
        {
            //1、玩家出招1、石头；2、布、3剪刀。
            //2、AI出招1、石头；2、布、3剪刀。
            //3、胜负判定
            //4、结果统计
            手势 player;
            手势 Ai;
            int win = 0;
            int lose = 0;
            int draw = 0;
            int total = 0;
            while (total<10)
            {
                player = PlayerInput();
                Ai = AiInput();
                switch (Pk(player, Ai))
                {
                    case 结果.胜利:
                        win++;
                        total++;
                        break;
                    case 结果.失败:
                        lose++;
                        total++;
                        break;
                    case 结果.平局:
                        draw++;
                        total++;
                        break;
                }
                    
            }
            Console.WriteLine($"一共玩{total}局，赢{win}局，输{lose}局，平{draw}局");
        }
    }
}