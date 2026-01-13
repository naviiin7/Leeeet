public class Solution
{
    public int SingleNumber(int[] nums)
    {
        List<int> uniq = new List<int>();
        List<int> rem = new List<int>();


    for (int i = 0; i < nums.Length; i++)
    {
        if (!uniq.Contains(nums[i]) && !rem.Contains(nums[i]))
        {
            uniq.Add(nums[i]);
        }
        else
        {
            uniq.Remove(nums[i]);
            rem.Add(nums[i]);
        }
    }


        return uniq[0];
    }
}
