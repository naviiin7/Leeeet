public class Solution
{
    public bool IsTrionic(int[] nums)
    {
        if(nums.Length < 4)
            return false;

        int i = 0;

        int start = i;
        while(i + 1 < nums.Length && nums[i] < nums[i+1])
            i++;
        if(i == start) return false;

        start = i;
        while(i + 1 < nums.Length && nums[i] > nums[i+1])
            i++;
        if(i == start) return false;

        start = i;
        while(i + 1 < nums.Length && nums[i] < nums[i+1])
            i++;
        if(i == start) return false;

        return i == nums.Length - 1;
    }
}