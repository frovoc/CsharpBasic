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
            //int a = random.Next(0, 100);
            //random.next(0, 100) 的实际取值范围是0 - 99共100个数字，建议将概率小的放前面判断，
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
            //Console.WriteLine("请选择您要出的剪刀、石头、布，按回车继续");
            //string you = Console.ReadLine();
            //string ai = "";
            //Random random = new Random();
            //int a = random.Next(0, 9);
            //if (a <3)
            //{
            //    ai = "剪刀";
            //}
            //else if (a<6)
            //{
            //    ai = "石头";
            //}
            //else
            //{
            //    ai = "布";
            //}
            //if(you == ai)
            //{
            //    Console.WriteLine($"你={you}，AI={ai}，平局");
            //}
            //else if ((you == "剪刀" && ai == "石头")||(you == "石头" && ai == "布")||(you == "布" && ai == "剪刀"))
            //{
            //    Console.WriteLine($"你={you}，AI={ai}，你输了");
            //}
            //else
            //{
            //    Console.WriteLine($"你={you}，AI={ai}，你赢了");
            //}


            //10、循环打印相关

            //反复循环抽卡和石头剪刀布
            //注意1、！！！！！ 随机数发生器new Random();不能放在循环里反复出现，只用一次就行了创建一个实例就够。   
            //Console.WriteLine("请再按下任意键后开始抽奖");
            //Console.ReadKey();
            //Random random = new Random();
            //string input = "";
            //while (input != "end")
            //{
            //    int a = random.Next(0, 100);
            //    string name = "";
            //    if (a < 10)
            //    {
            //        name = "关羽";
            //    }
            //    else if (a < 30)
            //    {
            //        name = "赵云";
            //    }
            //    else if (a < 60)
            //    {
            //        name = "张飞";
            //    }
            //    else
            //    {
            //        name = "黄忠";
            //    }
            //    Console.WriteLine($"a={a}");
            //    Console.WriteLine($"\n恭喜您获得了{name}");
            //    Console.WriteLine("输入end结束抽奖或者回车继续");
            //    input = Console.ReadLine();
            //}

            //循环石头剪刀布
            //Console.WriteLine("请再按下任意键后开始游戏");
            //Console.ReadKey();
            //string input = "";
            //Random random = new Random();
            //while (input != "end")
            //{
            //    Console.WriteLine("请输入您要出的剪刀、石头、布，按回车继续");
            //    string you = Console.ReadLine().Trim();
            //    string ai = "";
            //    if (you != "剪刀" || you != "石头" || you != "布")
            //    {
            //        Console.WriteLine("请重新输入您要出的剪刀、石头、布，按回车继续");
            //        you = Console.ReadLine().Trim();
            //    }
            //    int a = random.Next(0, 9);
            //    if (a < 3)
            //    {
            //        ai = "剪刀";
            //    }
            //    else if (a < 6)
            //    {
            //        ai = "石头";
            //    }
            //    else
            //    {
            //        ai = "布";
            //    }
            //    if (you == ai)
            //    {
            //        Console.WriteLine($"你={you}，AI={ai}，平局");
            //    }
            //    else if ((you == "剪刀" && ai == "石头") || (you == "石头" && ai == "布") || (you == "布" && ai == "剪刀"))
            //    {
            //        Console.WriteLine($"你={you}，AI={ai}，你输了");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"你={you}，AI={ai}，你赢了");
            //    }
            //    Console.WriteLine("输入end结束游戏或者回车继续");
            //    input = Console.ReadLine();
            //    input = input.Trim();
            //}   

            //数字循环
            //    Console.WriteLine("请输入数字开始循环");
            //Label1:
            //    string input1 = Console.ReadLine();
            //    string input2 = "";
            //    int num;
            //    if (int.TryParse(input1, out int a))
            //    {
            //        num = int.Parse(input1);
            //        while (input2 != "end")
            //        {
            //            num = num * 2;
            //            Console.WriteLine(num);
            //            Console.WriteLine("输入end结束或者回车继续");
            //            input2 = Console.ReadLine();
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("请输入数字");
            //        goto Label1;
            //    }


            //猜数字游戏
            //Random random = new Random();
            //int a = random.Next(1, 100);
            //Console.WriteLine("请输入你猜的结果，并在回车后继续");
            //int b = int.Parse(Console.ReadLine()); //此时已经猜了一次故定义i从1开始
            //int i = 1; 
            //while (a != b)
            //{
            //    if (a < b)
            //    {
            //        Console.WriteLine("Tip：偏大");
            //        Console.WriteLine("请重新输入你猜的结果，并在回车后继续");
            //        b = int.Parse(Console.ReadLine());
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tip：偏小");
            //        Console.WriteLine("请重新输入你猜的结果，并在回车后继续");
            //        b = int.Parse(Console.ReadLine());
            //        i++;
            //    }
            //}
            //Console.WriteLine($"恭喜你猜对了，您一共猜了{i}次");

            // 寻找1~100之间，所有13的倍数。
            //int a = 1;
            //while (a<100)
            //{
            //    if (a%13 == 0)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    a++;
            //}

            Console.ReadKey();
        }
    }
}