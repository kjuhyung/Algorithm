using System;

public class Solution 
{
    public string[] solution(string[] strings, int n) {
        int leng = strings.Length;
        string[] answer = new string[leng];
        
        for (int i =0; i<leng; i++)
        {
            answer[i] = (strings[i][n])+strings[i];
        }// n번째 글자 맨 앞에 더하기
        
        Array.Sort(answer);
        // 오름차순 정렬
        
        for (int j = 0; j <leng; j++)
        {
            answer[j] = answer[j].Substring(1);
        }
        // 맨 앞 글자 자르기
        
        return answer;
    }
}