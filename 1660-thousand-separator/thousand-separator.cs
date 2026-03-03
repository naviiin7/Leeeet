public class Solution
{
    public string ThousandSeparator(int n)
    {
        string s = n.ToString();
        List<string> parts = new List<string>();

        for (int i = s.Length; i > 0; i -= 3)
        {
            int start = Math.Max(0, i - 3);
            int length = i - start;
            parts.Add(s.Substring(start, length));
        }

        parts.Reverse();
        return string.Join(".", parts);
    }
}