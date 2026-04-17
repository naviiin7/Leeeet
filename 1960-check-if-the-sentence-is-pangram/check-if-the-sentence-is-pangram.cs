public class Solution 
{
    public bool CheckIfPangram(string sentence) 
    {
        int count = 0;
        for( char c ='a'; c <= 'z'; c++)
        {
            if(sentence.Contains(c))
                count ++;
            
        }
        if (count < 26)
            return false;
        return true;
    }
}