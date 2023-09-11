public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        int index = 0;
        for (int i = 0; i < s.Length; i++ )
        {
            if (s[i] == ' ')
            {
                answer += s[i];
                index = 0;
                continue;
            }
            if (index % 2 == 0)
            {
                answer += s[i].ToString().ToUpper();
                index++;
            }
            else
            {
                answer += s[i].ToString().ToLower();
                index++;
            }
        }
        return answer;
    }
}