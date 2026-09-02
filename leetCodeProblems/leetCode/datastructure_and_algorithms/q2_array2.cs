namespace leetCode.datastructure_and_algorithms;

public class q2_array2
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int counter;
        var solution = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            counter = 0;
            foreach (var number in nums)
            {
                if (number < nums[i] && number != nums[i]) counter++;

                solution[i] = counter;
            }
        }

        return solution;
    }
}