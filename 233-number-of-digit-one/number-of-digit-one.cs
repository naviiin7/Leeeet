public class Solution
{
    public int CountDigitOne(int n)
    {
        long count = 0;                                  

        for (long m = 1; m <= n; m *= 10)                
        {
            long high = n / (m * 10);                    
            long rest = n % (m * 10);                    

            count += high * m;                            
            count += Math.Min(Math.Max(rest - m + 1, 0), m);   
        }

        return (int)count;                               
    }
}