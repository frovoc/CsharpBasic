namespace _1_8_2.交通灯模拟_状态机
{
    internal class Program
    {
        enum 交通灯
        {
            红,
            绿,
            黄,
            无
        }
        //简单的交通灯转换写法
        static void simpleTrafficLight()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("红灯");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("绿灯");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("黄灯");
                Thread.Sleep(400);
            }
        }

        //状态机写法
        static void stateTrafficLight()
        {
            交通灯 trafficLightState = 交通灯.无;
            int time = 0;
            int red_time = 30;
            while (true)
            {
                switch (trafficLightState)
                {
                    case 交通灯.红:
                        {
                            Console.Clear();
                            Console.WriteLine($"红灯 剩余时间{time}");
                            time--;
                            if (time == 0)
                            {
                                trafficLightState = 交通灯.绿;
                                time = 30;
                            }
                        }
                        break;
                    case 交通灯.绿:
                        {
                            Console.Clear();
                            Console.WriteLine($"绿灯 剩余时间{time}");
                            time--;
                            if (time == 0)
                            {
                                trafficLightState = 交通灯.黄;
                                time = 4;
                            }
                        }
                        break;
                    case 交通灯.黄:
                        {
                            Console.Clear();
                            Console.WriteLine($"黄灯 剩余时间{time}");
                            time--;
                            if (time == 0)
                            {
                                trafficLightState = 交通灯.红;
                                time = red_time;
                            }
                        }
                        break;
                    default:
                        trafficLightState = 交通灯.红;
                        time = red_time;
                        break;
                }
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.W:
                            red_time++;
                            break;
                        case ConsoleKey.S:
                            red_time--;
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(100);//时间流逝的颗粒度，100相当于0.1s，time每减1时间每过0.1s。
            }
        }
        static void Main(string[] args)
        {
            stateTrafficLight();
        }
    }
}