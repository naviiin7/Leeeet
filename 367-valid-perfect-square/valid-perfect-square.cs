

public class Solution 
{
    public bool IsPerfectSquare(int num) 
    {
        if (num < 0) return false; 
        
        double root = Math.Sqrt(num); 

        if (root % 1 == 0) 
            return true; 
            
        return false; 
    }
}

        
    