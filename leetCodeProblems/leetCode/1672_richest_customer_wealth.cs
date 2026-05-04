namespace leetCode;

public class SolutionMaxWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        var maxWealth = 0;

        for (var i = 0; i < accounts.Length; i++)
        {
            var sumCurrentCustomer = 0;
            for (var j = 0; j < accounts[i].Length; j++)
            {
                sumCurrentCustomer += accounts[i][j];
                if (sumCurrentCustomer > maxWealth) maxWealth = sumCurrentCustomer;
            }
        }

        return maxWealth;
    }
}