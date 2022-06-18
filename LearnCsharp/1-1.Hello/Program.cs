namespace _1_1.Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1、console基础
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine(333 * 256 + 7);
            //Console.WriteLine("Hello" + 888);

            //2、Console.WriteLine(Console.ReadLine())机理
            //Console.WriteLine(Console.ReadLine());
            ////这两种写法等同
            //string Input = Console.ReadLine();
            //Console.WriteLine(Input);

            //3、交换a、b
            //方法一
            //Console.WriteLine("请输入a的值, 按下回车键后继续");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入b的值, 按下回车键后继续");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"交换前a={a},b={b}, 按下任意键后继续");
            //Console.ReadKey();
            //int c = a;
            //a = b; b = c;
            //Console.WriteLine($"交换后a={a},b={b}");
            //方法二
            //Console.WriteLine("请输入a的值, 按下回车键后继续");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入b的值, 按下回车键后继续");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"交换前a={a},b={b}, 按下任意键后继续");
            //Console.ReadKey();
            //a = a + b;b = a - b;a = a - b;
            //Console.WriteLine($"交换后a={a},b={b}");

            //4、对话
            //Console.WriteLine("请问你叫什么名字?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"你好，{name}。");

            //5、输入数字并相加
            //Console.WriteLine("请输入a的值, 按下回车键后继续");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入b的值, 按下回车键后继续");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int sum = a + b;
            //Console.WriteLine($"a={a},b={b}, a+b={sum}");
            //ps：Convert.ToInt32与int.Parse作用几乎相同，但在转换null时后者会报错，前者会转化为0，后者无法处理double类型

            //6、简单故事生成
            //故事内容：
            //巴老爷有88颗芭蕉树，来了88个把式要在巴老爷88棵芭蕉树下住。巴老爷拔了88棵芭蕉树，不让88个把式在88棵芭蕉树下住。88个把式少了88棵芭蕉树，巴老爷在88棵树边哭。
            //现在想让主角“巴老爷”、数量“88”、反派“把式”改为容易替换的变量，以便生成不同的故事。应当如何实现？
            //string story = "——巴老爷有88棵芭蕉树，来了88个把式要在巴老爷88棵芭蕉树下住。巴老爷拔了88棵芭蕉树，不让88个把式在88棵芭蕉树下住。88个把式少了88棵芭蕉树，巴老爷在88棵树边哭。";
            //story = story.Replace("。", "。\n");
            //Console.WriteLine($"原来的故事是\n{story}");
            //Console.WriteLine("请输入主角的名字, 按下回车键后继续");
            //string role1 = Console.ReadLine();
            //Console.WriteLine("请输入芭蕉树的数量, 按下回车键后继续");
            //string role2 = Console.ReadLine();
            //Console.WriteLine("请输入敌人的名字, 按下回车键后继续");
            //string role3 = Console.ReadLine();
            //Console.WriteLine("请输入敌人的数量, 按下回车键后继续");
            //string role4 = Console.ReadLine();
            //story = story.Replace("巴老爷", $"{role1}");
            //story = story.Replace("88棵", $"{role2}棵");
            //story = story.Replace("把式", $"{role3}");
            //story = story.Replace("88个", $"{role4}个");
            //Console.WriteLine($"现在的故事是\n{story}");

            //7、使用string.replace的方法替换
            //string story1 = "——巴老爷有88棵芭蕉树，来了88个把式要在巴老爷88棵芭蕉树下住。\n巴老爷拔了88棵芭蕉树，不让88个把式在88棵芭蕉树下住。\n88个把式少了88棵芭蕉树，巴老爷在88棵树边哭。";
            //Console.WriteLine($"故事1是\n{story1}");
            //string story2 = "——巴老爷有88棵芭蕉树，来了88个把式要在巴老爷88棵芭蕉树下住。巴老爷拔了88棵芭蕉树，不让88个把式在88棵芭蕉树下住。88个把式少了88棵芭蕉树，巴老爷在88棵树边哭。";
            //story2 = story2.Replace("。", "。\n");
            //Console.WriteLine($"故事2是\n{story2}");

        }
    }
}