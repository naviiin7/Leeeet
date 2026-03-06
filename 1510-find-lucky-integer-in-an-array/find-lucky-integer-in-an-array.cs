using System.Linq;

public class Solution 
{
    public int FindLucky(int[] arr) 
    {   
        Array.Sort(arr);

        List<int> lucky = new List<int>();
        int count = 1;

        for(int i = 0; i < arr.Length - 1; i++)
        {
            if(arr[i] == arr[i+1])
                count++;
            else
            {
                if(count == arr[i])
                    lucky.Add(arr[i]);

                count = 1;
            }
        }

        if(count == arr[arr.Length - 1])
            lucky.Add(arr[arr.Length - 1]);

        if(lucky.Count == 0)
            return -1;

        return lucky.Max();
    }
}