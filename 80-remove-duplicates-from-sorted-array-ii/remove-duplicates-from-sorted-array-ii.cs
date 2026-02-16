public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int size = nums.Length;
        if(size <= 2)
        {
            return size;
        }
        int j = 2;
        for(int i = 2; i < size; i++)
        if(nums[i] != nums[j-2])
        {
            nums[j] = nums[i];
            j++;
        }
        return j;

    }
}