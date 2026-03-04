namespace _1480_running_sum_of_1d_array_2;

public class SolutionStepsToZero {
    
    public int NumberOfSteps(int num)
    {
        int steps = 0;

        while (num != 0)
        {
            if (num % 2 == 0)
            {
                num = num / 2;
                steps++;
            }
            else
            {
                num = num - 1;
                steps++;
            }
        }

        return steps;
    }
    
}