namespace leetCode;

public class SolutionFizzBuzz
{
    public IList<string> FizzBuzz(int n)
    {
        IList<string> resultList = new List<string>();

        for (var i = 1; i <= n; i++)
            if (i % 3 == 0 && i % 5 == 0)
                resultList.Add("FizzBuzz");
            else if (i % 3 == 0)
                resultList.Add("Fizz");
            else if (i % 5 == 0)
                resultList.Add("Buzz");

            else
                resultList.Add(i.ToString());

        return resultList;
    }
}