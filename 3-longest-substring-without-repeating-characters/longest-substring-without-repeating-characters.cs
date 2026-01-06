public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int max = 0;
        int start = 0;

        for (int i = 0; i < s.Length; i++)
        {
            while (set.Contains(s[i]))
            {
                set.Remove(s[start]);
                start++;
            }

            set.Add(s[i]);
            max = Math.Max(max, set.Count);
        }

        return max;
    }
}
