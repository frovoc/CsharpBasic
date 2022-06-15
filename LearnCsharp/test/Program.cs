namespace hello2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7、if相关1
            // 1、输入一个数字，如果是2、3或5的倍数，则打印0；否则打印它本身。
            //2、输入一个数字，如果是2的倍数，则打印它乘以2的结果；如果是3或5的倍数则类似2的倍数，也打印3或5的结果；否则打印0。
            //Console.WriteLine("请输入a的值，如果是2、3或5的倍数，则打印0；否则打印它本身。按回车键继续");
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0)
            //{
            //    Console.WriteLine($"a={a}，是2、3或5的倍数，故输出0");
            //}
            //else
            //{
            //    Console.WriteLine($"a={a}，不是2、3或5的倍数，故输出它本身{a}");
            //}
            //Console.WriteLine("请输入b的值，如果是2的倍数，则打印它乘以2的结果；如果是3或5的倍数则类似2的倍数，也打印3或5的结果；否则打印0。按回车键继续");
            //int b = int.Parse(Console.ReadLine());
            //if (b % 2 == 0)
            //{
            //    Console.WriteLine($"b={b}, 是2的倍数故输出{b}*2={b * 2}");
            //}
            //else if (b % 3 == 0)
            //{
            //    Console.WriteLine($"b={b}, 是3的倍数故输出{b}*3={b * 3}");
            //}
            //else if (b % 5 == 0)
            //{
            //    Console.WriteLine($"b={b}, 是5的倍数故输出{b}*5={b * 5}");
            //}
            //else
            //{
            //    Console.WriteLine($"b={b}, 不是2、3、5的倍数故输出" + 0);
            //}

            //8、概率抽卡
            //抽卡游戏，40%概率获得黄忠，30%概率获得张飞，20%概率获得赵云，10%概率获得关羽。
            //Random random = new Random();
            //Console.WriteLine("请再按下任意键后开始抽奖");
            //Console.ReadKey();
            //int a = random.Next(0,100);
            //random.next(0,100) 的实际取值范围是0-99共100个数字，建议将概率小的放前面判断，
            //条件是依次判断的if else写法时，连续的顺序判断可以简化为下列写法
            //string name = "";
            //if (a < 10)
            //{
            //    name = "关羽";
            //}
            //else if (a < 30)
            //{
            //    name = "赵云";
            //}
            //else if (a < 60)
            //{
            //    name = "张飞";
            //}
            //else
            //{
            //    name = "黄忠";
            //}
            //Console.WriteLine($"a={a}");
            //Console.WriteLine($"\n恭喜您获得了{name}");

            //9、剪刀石头布
            Console.WriteLine("请选择您要出的剪刀、石头、布，按回车继续");
            string you = Console.ReadLine();
            string ai = "";
            Random random = new Random();
            int a = random.Next(0, 9);
            if (a <3)
            {
                ai = "剪刀";
            }
            else if (a<6)
            {
                ai = "石头";
            }
            else
            {
                ai = "布";
            }
            if(you == ai)
            {
                Console.WriteLine($"你={you}，AI={ai}，平局");
            }
            else if ((you == "剪刀" && ai == "石头")||(you == "石头"&&ai="布")||())
            {

            }

            Console.ReadKey();
        }
    }
}