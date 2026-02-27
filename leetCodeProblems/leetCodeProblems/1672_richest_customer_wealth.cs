namespace _1480_running_sum_of_1d_array_2;


public class SolutionMaxWealth {
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int sumCurrentCustomer = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                
                sumCurrentCustomer += accounts[i][j];
                if (sumCurrentCustomer > maxWealth)
                {
                    maxWealth = sumCurrentCustomer;
                }
            }
        }

        return maxWealth;
    }
}