using System;

public class Solution
{
    public int solution(string t, string p) 
    {
        int answer = 0;
        string[] partString = new string[t.Length];
        long[] partLong = new long[t.Length];
        long castingP = long.Parse(p);
        
        for (int i = 0; i<=t.Length-p.Length; i++)
        {
            partString[i] = t.Substring(i, p.Length);
            partLong[i] = long.Parse(partString[i]);
            if(partLong[i] <= castingP)
            {
                answer++;
            }
        }
        return answer;
    }
}