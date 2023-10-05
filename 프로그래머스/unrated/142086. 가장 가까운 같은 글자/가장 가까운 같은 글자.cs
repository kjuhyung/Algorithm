using System;

public class Solution 
{
    public int[] solution(string s)
    {
        int sLeng = s.Length;
        int[] answer = new int[sLeng];
        
        for (int i = 0; i< sLeng; i++)
        {
            int index = -1;
            for(int j = i-1; j >=0; j--)
            {
                if(s[j] == s[i])
                {
                    index = i - j;
                    break;
                }
            }
            answer[i] = index;
        }
        return answer;
    }
}