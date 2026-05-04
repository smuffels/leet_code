namespace leetCode.datastructure_and_algorithms;

public class q1_array1
{
    //Concatenation of Array
    public int[] GetConcatenation(int[] nums)
    {
        var ans = new int[nums.Length * 2];
        int value;

        for (var i = 0; i < nums.Length; i++)
        {
            value = nums[i];
            ans[i] = value;
            ans[nums.Length + i] = value;
        }

        return ans;
    }
}