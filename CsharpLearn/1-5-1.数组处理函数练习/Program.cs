namespace _1_5_1.数组处理函数练习
{
    internal class Program
    {
        //static void PrintArray(string[] array)
        //{
        //    Console.WriteLine($"数组类型{array}：");
        //    for (int a = 0; a < array.Length; a++)
        //    {
        //        Console.Write($"{a}\t");
        //    }
        //    Console.WriteLine();
        //    for (int a = 0; a < array.Length; a++)
        //    {
        //        Console.Write($"{array[a]}\t");
        //    }
        //    Console.WriteLine();
        //}
        //static void PrintArray(int[] array)
        //{
        //    Console.WriteLine($"数组类型{array}：");
        //    for (int a = 0; a < array.Length; a++)
        //    {
        //        Console.Write($"{a}\t");
        //    }
        //    Console.WriteLine();
        //    for (int a = 0; a < array.Length; a++)
        //    {
        //        Console.Write($"{array[a]}\t");
        //    }
        //    Console.WriteLine();
        //}

        //static string ReturnArray(string[] array)
        //{
        //    string a = "";
        //    string b = "";
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        a = a + array[i] + ",";
        //        b = b + i + ",";
        //    }
        //    return $"[{a}]\n[{b}]";
        //}
        //static string ReturnArray(int[] array)
        //{
        //    string a = "";
        //    string b = "";
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        a = a + array[i] + ",";
        //        b = b + i + ",";
        //    }
        //    return $"[{a}]\n[{b}]";
        //}
        ////1、查找元素int FindElement(int[] array, int num);
        //static int FindElement(int[] array, int num)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (num == array[i])
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}

        ////2、判断是否包含元素bool HasElement(int[] array, int num);
        //static bool HasElement(int[] array, int num)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (num == array[i])
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        ////3、求最大值 int MaxElement(int[] array);
        //static int MaxElement(int[] array)
        //{
        //    int max = array[0];
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] > max)
        //        {
        //            max = array[i];
        //        }
        //    }
        //    return max;
        //}

        ////4、数组求和 int Sum(int[] array)
        //static int Sum(int[] array)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum = sum + array[i];
        //    }
        //    return sum;
        //}

        ////5、求最小值 int MinElement(int[] array)
        //static int MinElement(int[] array)
        //{
        //    int min = array[0];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }
        //    }
        //    return min;
        //}

        ////6、求最小值的下标 int MinElementIndex(int[] array)
        //static int MinElementIndex(int[] array)
        //{
        //    int min = array[0];
        //    int a = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //            a = i;
        //            continue;
        //        }
        //    }
        //    //Console.WriteLine($"最小值为{min}，下标为{a}");
        //    return a;
        //}

        //    //7、求数组平均数 float Average(int[] array)
        //    static float Average(int[] array)
        //{
        //    float average = 0f;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        average = average + array[i] * 1.0f / array.Length;
        //    }
        //    Console.WriteLine($"数组有{array.Length}个数");
        //    return average;
        //}
        //8、再写最后一个函数，函数的作用是将数组中的所有元素翻倍（即乘以2），确保改变了原数组中的值。函数名称为DoubleElement，参数为int[] array。
        static void DoubleElement(int[] array)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < array.Length; i++)
            {
                a = a + array[i] + ",";
                array[i] = array[i] * 2;
                b = b + array[i] + ",";
            }
            Console.WriteLine("原来的数组为：" + a);
            Console.WriteLine("现在的数组为：" +b);
        }
            static void Main(string[] args)
            {
                int[] arrayNum = new int[] { 1, 2, 3, -4, -567, -6, -7, -8, -9, 0, -99, -19 };
                //string[] arrayString = new string[] { "1", "2", "true", "bool", "false", "wtf", "Wkr" };
                //PrintArray(arrayString);
                //PrintArray(arrayNum);
               // Console.WriteLine($"元素-99的下标是：{FindElement(arrayNum,-99)}");
               // Console.WriteLine($"数组中是否存在-99：{HasElement(arrayNum, -99)}");
               // Console.WriteLine($"数组中是否存在99：{HasElement(arrayNum, 99)}");
               // Console.WriteLine($"最大值为{MaxElement(arrayNum)}");
               // Console.WriteLine($"数组求和结果是{Sum(arrayNum)}");
               // Console.WriteLine($"最小值为{MinElement(arrayNum)}");
               //Console.WriteLine($"最小值的下标为{MinElementIndex(arrayNum)}");
               // Console.WriteLine($"数组的平均数为：{Average(arrayNum)}");
                DoubleElement(arrayNum);
            }
        }
}