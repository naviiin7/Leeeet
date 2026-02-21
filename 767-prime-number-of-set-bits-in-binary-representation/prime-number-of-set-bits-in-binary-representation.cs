public class Solution {
    public int CountPrimeSetBits(int left, int right) 
    {
        int paths = 0;
        for(int i=left; i<=right; i++)
        {
            string binr = Convert.ToString(i, 2);
            int count = 0;
            int pr = 0;
            foreach (char c in binr)
            {
                if( c == '1' )
                    count++;
            }
            if(count <= 1)
                continue;
            
            for(int j=1; j<=count;j++)
            {
                if(count % j == 0)
                    pr++;

            }
                    if(pr == 2)
                    paths++;

        }
        return paths;
    }
}