public class Solution 
{


    public int MinOperations(int[] nums)
    {
        bool flag = true;
        for(int i=1; i<nums.Length; i++)
        {
            if(nums[0] != nums[i])
                flag = false;
                
        }
        return flag ? 0 : 1; 
        
    }
}