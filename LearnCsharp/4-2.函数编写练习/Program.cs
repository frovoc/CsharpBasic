namespace _5_1.函数编写练习
{
    internal class Program
    {
        static  string PrintArray(string[] array)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < array.Length; i++)
            {
                a= a + array[i]+",";
                b = b + i + ",";
            }
            return $"[{a}]\n[{b}]";
        }
        static string PrintArray(int[] array)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < array.Length; i++)
            {
                a = a + array[i] + ",";
            }
            return $"[{a}]\n[{b}]";
        }
        //1、查找元素int FindElement(int[] array, int num);
        static int FindElement(int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        //2、判断是否包含元素bool HasElement(int[] array, int num);
        static bool HasElement(int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    return true;
                }
            }
            return false;  
        }

        //3、求最大值 int MaxElement(int[] array);
        static  int MaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        //4、数组求和 int Sum(int[] array)
        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        //5、求最小值 int MinElement(int[] array)
        static  int MinElement(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        //6、求最小值的下标 int MinElementIndex(int[] array)
        //static  int MinElementIndex(int[] array)
        //{
        //    int min = array[0];
        //    int a;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //            a = i;
        //            continue;
        //        }
        //        a = 0;
        //    }
            
        //    return a ;
        //}

        //7、求数组平均数 float Average(int[] array)
        static void Main(string[] args)
        {
            int[] arrayNum = new int[] { 1, 2, 3, -4,- 567, -6,- 7,- 8, -9, 0,- 99, -19 };
            string[] arrayString = new string[] { "1", "2", "true", "bool", "false", "wtf", "Wkr" };
            Console.WriteLine(PrintArray(arrayString));
            Console.WriteLine(PrintArray(arrayNum));
            Console.WriteLine(FindElement(arrayNum, 999));
            Console.WriteLine(HasElement(arrayNum, 999));
            Console.WriteLine(HasElement(arrayNum, 99));
            Console.WriteLine(MaxElement(arrayNum));
            Console.WriteLine(Sum(arrayNum));
            Console.WriteLine(MinElement(arrayNum));
            //Console.WriteLine(MinElementIndex(arrayNum));
        }
    }
}