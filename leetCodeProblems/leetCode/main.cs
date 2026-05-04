using leetCode.datastructure_and_algorithms;

namespace leetCode;

public class main
{
    public static void Main()
    {
        var solution = new q3_array1();
        var result = solution.FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 0 });
        Console.WriteLine(string.Join(",", result));
    }
}