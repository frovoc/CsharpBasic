namespace _2_1_1.面向对象写法模拟水壶
{
    class waterBottle
    {
        public string name ="";
        public int waterBottleCapacity;
        public int waterTemperature;
        public int waterVolume;
    }
    class waterHandle
    {
        public static void WaterHeat(waterBottle s1, int heatTarget)
        {
            if (s1.waterVolume >0)
            {
                s1.waterTemperature = heatTarget;
                Console.WriteLine($"{s1.name}内水温已加热到{heatTarget}℃");
                if (s1.waterTemperature >= 100)
                {
                    s1.waterTemperature = 100;
                    Console.WriteLine($"{s1.name}内的水已烧开,无法继续加热");
                }
            }
            else
            {
                Console.WriteLine($"{s1.name}内没水，无法加热");
            }
        }
        public static void WaterAdd(waterBottle s1, int waterAddVolume)
        {
            s1.waterVolume += waterAddVolume;
            Console.WriteLine($"向{s1.name}中加了{waterAddVolume}ml水");
            if (s1.waterVolume > s1.waterBottleCapacity)
            {
                s1.waterVolume = s1.waterBottleCapacity;
                Console.WriteLine($"{s1.name}已加满");
            }
        }
        public static void WaterReduce(waterBottle s1, int waterReduceVolume)
        {
            s1.waterVolume -= waterReduceVolume;
            Console.WriteLine($"{s1.name}往外倒了{waterReduceVolume}ml水");
            if (s1.waterVolume < 0)
            {
                s1.waterVolume = 0;
                Console.WriteLine($"{s1.name}已倒空");
            }
        }
        public static void PrintState(waterBottle s1)
        {
            Console.WriteLine($"{s1.name}的容量是{s1.waterBottleCapacity}ml,当前壶内有{s1.waterVolume}ml水，当前壶内水温{s1.waterTemperature}℃");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                /*模拟一个水壶，它可以加水、倒水，还具有加热功能。---水量 ---水温
                 它具有一定的容量（毫升，ml），水的温度不可能超过100度。
                请设计这个“水壶”，并创建三种不同容量的水壶对象进行测试。b1\b2\b3
                */
                waterHandle waterHandle = new waterHandle();

                waterBottle s1 = new waterBottle();
                    s1.name = "小壶";
                    s1.waterBottleCapacity = 100;
                    s1.waterTemperature = 23;
                    s1.waterVolume = 0;
                
                
                waterBottle s2 = new waterBottle();
                    s2.name = "中壶"; 
                    s2.waterBottleCapacity = 200;
                    s2.waterTemperature = 23;
                    s2.waterVolume = 50;


                waterBottle s3 = new waterBottle();
                    s3.name = "大壶";
                    s3.waterBottleCapacity = 300;
                    s3.waterTemperature = 23;
                    s3.waterVolume = 100;

            waterHandle.PrintState(s1);
            waterHandle.WaterAdd(s1, 50);
            waterHandle.WaterReduce(s1, 100);
            waterHandle.WaterHeat(s1, 100);
            waterHandle.PrintState(s1);

            Console.WriteLine();
            waterHandle.PrintState(s2);
            waterHandle.WaterAdd(s2, 500);
            waterHandle.WaterReduce(s2, 100);
            waterHandle.WaterHeat(s2, 100);
            waterHandle.PrintState(s2);

            Console.WriteLine();
            waterHandle.PrintState(s3);
            waterHandle.WaterAdd(s3, 500);
            waterHandle.WaterReduce(s3, 100);
            waterHandle.WaterHeat(s3, 100);
            waterHandle.PrintState(s3);



        }
    }
}