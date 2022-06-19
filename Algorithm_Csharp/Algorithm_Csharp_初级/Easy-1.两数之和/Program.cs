namespace Easy_1.两数之和
{
    //1. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    internal class Program
    {
        static void TwoSum(int[] nums, int target)
        {
            int[] result = new int[] { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {
                //if (nums[i] >= target)
                //{
                //    continue;
                //}
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]==target - nums[j])
                    {
                        result[0] = i;
                        result[1] = j;
                        Console.WriteLine($"{result[0]},{result[1]}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 12, 2, 3, 4, -5 };
           TwoSum(nums, 7);
        }
    }
}