using System;

public class Solution
{
    public int solution(string message) 
    {
        int size = 0;
        if (1 <= message.Length && message.Length <= 50)
        {
            size = message.Length * 2;
        }
        return size;
    }
}