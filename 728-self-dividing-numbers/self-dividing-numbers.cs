public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        List<int> num = new List<int>();
        
        for (int i = left; i <= right; i++) {
            int a = i; 
            bool isValid = true;

            while (a > 0) {
                int b = a % 10;
                if (b == 0 || i % b != 0) {
                    isValid = false;
                    break;
                }
                a /= 10;
            }

            if (isValid) {
                num.Add(i);
            }
        }
        return num; 
    }
}
