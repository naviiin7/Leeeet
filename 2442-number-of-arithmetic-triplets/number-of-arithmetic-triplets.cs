public class Solution 
{
    public int ArithmeticTriplets(int[] nums, int diff) 
    {
        int count = 0;
        for( int i=0; i<nums.Length; i++ )
        {
            if(    (  nums.Contains(nums[i] + diff)  )   &&    ( nums.Contains(nums[i]+2*diff) )  )       
            count++;
        }    
        return count;             
    }
}