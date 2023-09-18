public class Solution 
{
    public string solution(string s, int n)
    {
         string answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            
            // 공백일 경우
            if (c == ' ')
            {
                answer += " ";
            }
            
            // 공백이 아닐 경우
            else
            {
                int tmp = c + n;
                // c를 n 만큼 민 값을 변수에 저장
                if (tmp > 122)
                {
                    answer += (char)(tmp - 26);
                }
                // 소문자 범위 넘어간 경우 먼저 처리
                else if (c <= 90 && tmp >90)
                {
                    answer += (char)(tmp - 26);
                }
                // 초기값이 대문자인데 Z 뒤로 넘어갔을 경우
                else if (tmp >= 65 && tmp <= 90 || tmp >= 97 && tmp <=122)
                {
                    answer += (char)(tmp);
                }  
            }
        }
        return answer;
    }
}