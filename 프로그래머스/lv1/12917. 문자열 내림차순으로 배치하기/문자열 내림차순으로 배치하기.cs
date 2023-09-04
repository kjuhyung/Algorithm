using System;

public class Solution 
{
    public string solution(string s) 
    {
        string answer;
        char[] sArray = s.ToCharArray();
        Array.Sort(sArray);
        Array.Reverse(sArray);
        answer = new string(sArray);
        
        return answer;
    }
}