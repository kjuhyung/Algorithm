using System;

public class Solution
{
    public int solution(int n) 
    {    
        int answer = 0;
        int x;
        for(x = 2; x<=n; x++)
        {
            if (n % x == 1)
            {
                return x;
            }
        }
        x = answer;
        return answer;
    }
}