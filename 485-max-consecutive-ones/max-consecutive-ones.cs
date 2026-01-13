public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int max = 0;
        List<int> freq = new List<int>();
        foreach(int i in nums)
        {
            if(i==1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else if(i == 0)
                count=0;
        }
        return max;
    }
}