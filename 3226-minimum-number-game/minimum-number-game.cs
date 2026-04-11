public class Solution 
{
    public int[] NumberGame(int[] nums) 
    {
        List<int> list = new List<int>(nums);
        List<int> numbers = [];
        while(list.Count > 0)
        {
            int p = list.Min();
            list.Remove(p); 
            int q = list.Min();
            list.Remove(q);
            numbers.Add(q);
            numbers.Add(p);
        }   
        return numbers.ToArray();
    }
}