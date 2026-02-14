public class Solution {
    public int FirstMissingPositive(int[] nums) {
        HashSet<int> seen = new HashSet<int>(nums);

        int result = 1;
        
        while (seen.Contains(result)) {
            result++;
        }

        return result;
    }
}