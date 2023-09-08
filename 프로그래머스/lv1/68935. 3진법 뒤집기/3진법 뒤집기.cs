using System;

public class Solution 
{
    public int solution(int n) 
    {
       int answer = 0;
        string Trit = "";
        while (n != 0)
        {
            Trit = (n % 3) + Trit;  
            n /= 3; 
        }
        // n을 삼진법으로 변환
        char[] tritArray = Trit.ToCharArray();
        Array.Reverse(tritArray);
        string reverseTrit = new string(tritArray); // 생성된 문자배열 뒤집어서 문자열 만들기
        int power = 0;
        for( int i = reverseTrit.Length -1; i >= 0; i--)
        {
            int tmp = int.Parse(reverseTrit[i].ToString());
            answer += tmp * (int)Math.Pow(3,power);
            power++;
        }
        // 다시 10진법으로 변환
        return answer;    
    }
}