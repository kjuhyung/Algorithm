using System;

public class Solution
{
    public long solution(long n) 
    {
        string arr = n.ToString();
        long[] a = new long[arr.Length];
        for (int i = 0; i<arr.Length; i++)
        {
        a[i] = long.Parse(arr[i].ToString());
        }
        Array.Sort(a);
        Array.Reverse(a);
        
        long answer = 0;
        for (int i = 0; i<a.Length; i++)
        {
            answer = answer * 10 + a[i];
        }
        
        return answer;
    }
}