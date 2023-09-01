using System;

public class Solution
{
    public int solution(int[] numbers) 
    {
        int answer = 0;
        foreach (int n in numbers)
        {
            if(n !=0)
            {
                answer += n;
            }
        }        
        
        return 45 - answer;
    }
}