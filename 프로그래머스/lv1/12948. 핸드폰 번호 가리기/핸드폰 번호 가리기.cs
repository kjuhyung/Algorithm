public class Solution
{
    public string solution(string phone_number)
    {
        string last = phone_number.Substring(phone_number.Length - 4);
string answer = new string('*',phone_number.Length - 4) + last;
        return answer;
    }
}