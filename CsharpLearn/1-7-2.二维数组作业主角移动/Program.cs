namespace _1_7_2.二维数组作业主角移动
{
    internal class Program
    {
        static void printMap(char[,] map)
        {
            Console.WriteLine();
            for (int i = 0; i <map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void StringToArray2D(string s,char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = s[i * (map.GetLength(1) + 1) + j];
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            "#################\n" +
            "#    o          #\n" +
            "#    ~~~     H  #\n" +
            "#      ~~~      #\n" +
            "#        ~~~    #\n" +
            "#    C    ~~~   #\n" +
            "#     D  C  ~~~ #\n" +
            "#               #\n" +
            "#               #\n" +
            "#################\n";
         */

            string s =""+
                "#################\n" +
                "#    o          #\n" +
                "#    ~~~     H  #\n" +
                "#      ~~~      #\n" +
                "#        ~~~    #\n" +
                "#    C    ~~~   #\n" +
                "#     D  C  ~~~ #\n" +
                "#               #\n" +
                "#               #\n" +
                "#################\n";

            Console.Write(s);
            char[,] map = new char[10, 17];
            StringToArray2D(s, map);
            int oi = 1;
            int oj = 5;
            while (true)
            {
                Console.Clear();
                printMap(map);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        if (2<= oi )
                        {
                            map[oi, oj] = ' ';
                            map[oi -= 1, oj] = 'o';
                        }
                        break;
                    case ConsoleKey.S:
                        if (oi <= 7)
                        {
                            map[oi, oj] = ' ';
                            map[oi += 1, oj] = 'o';
                        }
                        break;
                    case ConsoleKey.A:
                        if (oj >= 2)
                        {
                            map[oi, oj] = ' ';
                            map[oi, oj -= 1] = 'o';
                        }
                        break;
                    case ConsoleKey.D:
                        if (oj <= 14)
                        {
                            map[oi, oj] = ' ';
                            map[oi, oj += 1] = 'o';
                        }
                        break;
                    default:
                        Console.WriteLine("请输入正确的按键WASD");
                        break;
                }
            }
        }
    }
}