public class Solution
{
    public int CountPrimes(int n)
    {
        if (n < 3) return 0;

        bool[] isComposite = new bool[n];
        int count = 0;

        for (int i = 2; i < n; i++)
        {
            if (isComposite[i]) continue;

            count++;

            for (long j = (long)i * i; j < n; j += i)
                isComposite[j] = true;
        }

        return count;
    }
}