namespace _1_6.函数生命周期和引用
{
    internal class Program
    {
        //1、理解什么是参数传递？
        //1-1、在本例中函数Func函数只接受了一个外部的参数并在函数内部修改了传入的参数，并没有传出，所以Main函数中的参数值并未发生变化。
        static void Func(int a)
        {
            a = 9;
            Console.WriteLine($"Func函数执行完毕，a={a}");
            int count=0;//2-1、若在main函数内定义count则此处无法调用main函数内定义的count所以需要在此处重新定义，函数内的count和main函数内的count不是同一个变量，无法在main函数内记录func函数调用的次数。
            count++;
        }

        //1-2、在本例中函数Func函数只接受了一个外部的参数并在函数内部修改了传入的参数，并将其传出重新赋给b，所以Main函数中的参数值也发生了变化。
        static int Func2(int a)
        {
            a = 9;
            Console.WriteLine($"第二例");
            Console.WriteLine($"Func函数执行完毕，a={a}");
            return a;
        }
        //2、函数外定义全局变量，记得加static
        static int count;//记录函数调用次数的正解
        static Random random;//定义全局随机函数（常用全局定义）


        static void Main(string[] args)
        {
            //int count = 0;//2-2、故只能定义一个函数外的全局变量使所有函数中的count都变为同一个函数以达到记录函数调用次数的目的。
            random = new Random();//在函数内部实例化全局随机函数，以进行下一步的调用。 
            int a = random.Next(1,5);
            int b = 3;
            Func(a);
            Func(a);
            Func(a);
            Func(a);
            Func(a);
            Func(a);
            b =Func2(b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("count=" + count);
        }
    }
}