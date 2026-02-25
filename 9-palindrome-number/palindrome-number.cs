public class Solution {
    public bool IsPalindrome(int x) {
        string a = x.ToString();
        string reversed = new string(a.Reverse().ToArray());
        bool arEqual = (reversed == a);
        return arEqual;
    }
}