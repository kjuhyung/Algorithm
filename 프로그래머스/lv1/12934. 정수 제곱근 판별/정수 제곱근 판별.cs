using System;

public class Solution 
{
    public long solution(long n) 
    {
        long answer = 0;
        long nSqrt = (long)Math.Sqrt(n);

        if (nSqrt * nSqrt == n)
        {
            answer = (nSqrt + 1) * (nSqrt + 1);
        }
        else
        {
            answer = -1;
        }            
        
        return answer;
    }
}