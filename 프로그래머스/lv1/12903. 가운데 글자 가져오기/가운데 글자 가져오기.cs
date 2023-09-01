using System;
using System.Text;

public class Solution
{
    public string solution(string s)
    {
        string answer;
        StringBuilder sb = new StringBuilder(s);
        
        int divisor = sb.Length % 2 != 0 ?
            (s.Length -1) /2 : (s.Length -2) /2;
        if (sb.Length % 2 !=0)
        {
            sb.Remove(0,divisor);
            sb.Remove(1,divisor);
        }
        else
        {
            sb.Remove(0,divisor);
            sb.Remove(2,divisor);
        }
        
        answer = sb.ToString();        
        return answer;
    }
}