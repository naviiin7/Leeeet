public class Solution
{
    public string ThousandSeparator(int n)
    {
        return n.ToString("N0").Replace(",", ".");
    }
}
