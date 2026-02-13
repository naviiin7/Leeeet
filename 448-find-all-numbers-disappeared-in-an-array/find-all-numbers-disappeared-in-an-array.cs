public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> diss = new List<int>();

        Array.Sort(nums);

        if (nums[0] > 1) {
            for (int i = 1; i < nums[0]; i++) {
                diss.Add(i);
            }
        }

        for (int i = 0; i < nums.Length - 1; i++) {

            if (nums[i] == nums[i + 1])
                continue;

            if (nums[i] + 1 != nums[i + 1]) {

                int gap = nums[i + 1] - nums[i];

                for (int k = 1; k < gap; k++) {
                    diss.Add(nums[i] + k);
                }
            }
        }

        if (nums[nums.Length - 1] < nums.Length) {
            for (int i = nums[nums.Length - 1] + 1; i <= nums.Length; i++) {
                diss.Add(i);
            }
        }

        return diss;
    }
}
