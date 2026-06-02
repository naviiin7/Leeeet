public class Solution {
    public int MinOperations(int[] nums, int k)
    {
        int totalSum = 0;
        
        foreach (int num in nums)
        {
            totalSum += num;
        }

        if(totalSum % k == 0)
            return 0;
        else
            return(totalSum%k);
        

        
    }
}