public class Solution 
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int og = x;
        List<int> digits = new List<int>();
        while(x>0)
        {
            digits.Add(x%10);
            x /= 10;
        }
        int sum= digits.Sum();
        if(!(og%sum == 0))
            return -1;
        return sum;
        
    }
}