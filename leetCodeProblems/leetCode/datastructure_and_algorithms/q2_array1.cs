namespace leetCode.datastructure_and_algorithms;

public class q2_array1
{
    //Shuffle the Array
    public int[] Shuffle(int[] nums, int n)
    {
        var shuffled = new int[nums.Length];
        var index = 0;

        for (var i = 0; i < n; i++)
        {
            shuffled[index] = nums[i];
            shuffled[index + 1] = nums[n + i];
            index += 2;
        }

        return shuffled;
    }
}