public class Solution
{
public bool IsBalanced(string num)
    {
        int sumO = 0;
        int sumE = 0;

        for(int i = 0; i < num.Length; i++)
        {
            int digit = num[i] - '0';

            if(i % 2 == 0)
                sumE += digit;
            else
                sumO += digit;
        }

        return sumO == sumE;
    }
}