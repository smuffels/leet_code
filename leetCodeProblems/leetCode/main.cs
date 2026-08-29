using leetCode.datastructure_and_algorithms;

namespace leetCode;

public class main
{
    public static void Main()
    {
        var solution = new q1_array2();
        var result = solution.FindErrorNums(new[] { 3, 5, 9, 4, 1, 2, 7, 8, 1 });
        Console.WriteLine(string.Join(",", result));
    }
}