using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] numbers) 
    {
       List<int> answer = new List<int>();
        
        for (int i = 0; i<numbers.Length -1; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
            {
                int sum = numbers[i] + numbers[j];
                
                if(answer.Contains(sum) == false)
                {
                    answer.Add(sum);
                }
            }
        }
        answer.Sort();
        
        return answer.ToArray();
    }
}