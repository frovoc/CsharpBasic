using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_1.属性与单例
{
    internal class Utils
    {
        private static Utils instance = null;

        public static Utils Intance
        {
            get 
            {
                if (instance == null)
                { 
                    instance = new Utils();
                }
                return instance; 
            }
        }
        private Random random = new Random();

        public int RandomNum(int a, int b)
        {
            return random.Next(a, b);
        }

        public void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }
        public void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

    }
}
