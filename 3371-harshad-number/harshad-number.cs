public class Solution 
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        int og = x;
        List<int> digits = new List<int>();
        int sum = 0;
        while(x>0)
        {
            digits.Add(x%10);
            x /= 10;
        }
        foreach(int k in digits)
            sum += k;
        if(!(og%sum == 0))
            return -1;
        return sum;
        
    }
}