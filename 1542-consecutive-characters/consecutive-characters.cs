using System.Linq;

public class Solution 
{
    public int MaxPower(string s) 
    {
        List<int> pows = new List<int>();

        int count = 1;

        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] == s[i-1])
            {
                count++;
            }
            else
            {
                pows.Add(count);
                count = 1;
            }
        }

        pows.Add(count);

        return pows.Max();
    }
}