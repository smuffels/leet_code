namespace leetCode;

public class SolutionRunningSum
{
    public int[] RunningSum(int[] nums)
    {
        var sumArray = new int[nums.Length];
        var sum = 0;

        if (nums.Length < 1 || nums.Length > 1000) return sumArray;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > -1000000 && nums[i] < 1000000)
            {
                sum = sum + nums[i];
                sumArray[i] = sum;
            }

        return sumArray;
    }
}