public class Solution {
    public bool IsPowerOfThree(int n) {
        for (int i = 0; i <= 19; i++) {
            if (Math.Pow(3, i) == n) {
                return true;
            }
        }
        return false; 
    }
}
