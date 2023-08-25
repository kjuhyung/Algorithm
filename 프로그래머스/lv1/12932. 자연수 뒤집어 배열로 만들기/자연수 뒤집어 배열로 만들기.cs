using System;

public class Solution 
{
    public int[] solution(long n)
    {
        string arr = n.ToString();
        int[] answer = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
           answer[i] = arr[i] - '0';
        }                       
        Array.Reverse(answer);
        
        return answer;
    }
}