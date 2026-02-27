// See https://aka.ms/new-console-template for more information

using System;
class  aaah{
    public static void Main()
    {
        int[] testArray = {1,2,3,4};
        SolutionRunningSum solution = new SolutionRunningSum();
        int[] result = solution.RunningSum(testArray);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    } 
}

public class SolutionRunningSum {
    public int[] RunningSum(int[] nums) {
        int[] sumArray = new int[nums.Length];
        int sum = 0;

        if (nums.Length < 1 || nums.Length >1000){
            return sumArray;
        }
        for(int i = 0; i< nums.Length; i++){
            if(nums[i]>-1000000 && nums[i]<1000000){
                sum = sum + nums[i];
                sumArray[i] = sum;
            }
            
        }
        return sumArray;
    }
}


