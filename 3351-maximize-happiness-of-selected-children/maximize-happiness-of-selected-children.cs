public class Solution 
{
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness);
        Array.Reverse(happiness);

        long total = 0;

        for (int i = 0; i < k && i < happiness.Length; i++)
        {
            int value = happiness[i] - i;

            if (value > 0)
                total += value;
        }

        return total;
    }
}
