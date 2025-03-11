//The problem:

//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//You can return the answer in any order.

//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]

//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]
 
//Constraints:

//2 <= nums.length <= 104
//-109 <= nums[i] <= 109
//-109 <= target <= 109
//Only one valid answer exists.
 

//Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.


namespace LeetCodeChallenges
{
    public class TwoSum
    {
        public static int[] CalculateTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict[nums[i]] = i;
                }
            }

            throw new ArgumentException("No two sum solution");
        }

        static void Main()
        {
            RunExample(new int[] { 2, 7, 11, 15 }, 9, "Example 1"); // Expected: [0,1]
            RunExample(new int[] { 3, 2, 4 }, 6, "Example 2"); // Expected: [1,2]
            RunExample(new int[] { 3, 3 }, 6, "Example 3"); // Expected: [0,1]
        }

        private static void RunExample(int[] numbers, int target, string exampleName)
        {
            int[] result = CalculateTwoSum(numbers, target);
            Console.WriteLine($"{exampleName}:");
            result.ToList().ForEach(element => Console.Write($"{element}  "));
            Console.WriteLine();
        }
    }
}
