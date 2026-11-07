public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        int a = haystack.Length;
        int b = needle.Length;

        if (a < b)
            return -1;

        for (int i = 0; i <= a - b; i++)
        {
            int pos = 0;

            while (pos < b && haystack[i + pos] == needle[pos])
            {
                pos++;
            }

            if (pos == b)
                return i;
        }

        return -1;
    }
}