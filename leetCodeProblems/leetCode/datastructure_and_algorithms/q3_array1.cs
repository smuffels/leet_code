namespace leetCode.datastructure_and_algorithms;

public class q3_array1
{
    // faster solution with 2 variables
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var max = 0;
        var counter = 0;

        foreach (var n in nums)
            if (n == 1)
            {
                counter++;
            }
            else
            {
                max = Math.Max(max, counter);
                counter = 0;
            }

        max = Math.Max(max, counter);
        return max;
    }

    // slower solution with List
    /*
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        var counter = 0;
        var conecOnes = new List<int>();

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == 1)
            {
                counter++;
            }
            else
            {
                conecOnes.Add(counter);
                counter = 0;
            }

        conecOnes.Add(counter);

        var max = conecOnes.Max();
        return max;
    }
    */
}