public class Solution 
{

    public int MinOperations(int[] nums)
    {
        int len = nums.Length;
        var set = nums.ToHashSet();    

        if(set.Count == 1)
         {   return 0;   }


        else 
           {return 1;} 
        
    }
}