namespace leetCode.datastructure_and_algorithms;

public class q3_array2
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();
        var min = 1;
        var max = nums.Length;

        for (var i = min; i <= max; i++)
            if (!nums.Contains(i))
                result.Add(i);

        return result;
    }
}