
public class Solution
{
    public string ReverseVowels(string s)
    {
        char[] vowels = { 'a','e','i','o','u','A','E','I','O','U' };
        List<char> collected = new List<char>();

        char[] chars = s.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (vowels.Contains(chars[i]))
            {
                collected.Add(chars[i]);
                chars[i] = '_';
            }
        }

        int index = collected.Count - 1;

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == '_')
            {
                chars[i] = collected[index--];
            }
        }

        return new string(chars);
    }
}
