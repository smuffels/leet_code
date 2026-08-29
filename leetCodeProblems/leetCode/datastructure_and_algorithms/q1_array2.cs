namespace leetCode.datastructure_and_algorithms;

public class q1_array2
{
    public int[] FindErrorNums(int[] nums)
    {
        var result = new int[2];
        var set = new HashSet<int>();
        var repeatedNum = 0;
        var missingNum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i])) repeatedNum = nums[i];

            set.Add(nums[i]);
        }

        var min = 1;
        var max = nums.Max();
        for (var i = min; i <= max; i++)
            if (!set.Contains(i))
            {
                missingNum = i;
                break;
            }
            else
            {
                missingNum = max + 1;
            }

        if (min == max) missingNum = min + 1;


        result[0] = repeatedNum;
        result[1] = missingNum;
        return result;
    }
}