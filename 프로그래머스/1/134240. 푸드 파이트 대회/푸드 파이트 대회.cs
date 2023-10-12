using System;
using System.Linq;

public class Solution
{
    public string solution(int[] food)
    {
        string answer = "";
        for(int i = 1; i < food.Length; i++)
        {
            for(int j = 0; j < food[i]/2; j++)
            {
                answer += i.ToString();
            }
        }
        string str = new string (answer.Reverse().ToArray());
        return answer + "0" + str;
    }
}