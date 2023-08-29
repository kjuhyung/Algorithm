public class Solution
{
    public bool solution(int x) 
    {
        int a = 0;
        int b = x;
        bool answer;
        
        while (b>0)
        {
            a += b % 10;
            b /= 10;
        }
        if (x%a ==0)
        {
            answer = true;
        }
        else answer = false;
        
        
        return answer;
    }
}