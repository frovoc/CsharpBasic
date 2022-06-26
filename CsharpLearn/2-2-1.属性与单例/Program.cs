namespace _2_2_1.属性与单例
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            string[] s = { "gui", "e", "3", "hhui" };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Utils.Intance.RandomNum(5, 100);
            }
            Utils.Intance.PrintArray(nums);
            Utils.Intance.PrintArray(s);
        }
    }
}