public class Solution 
{
    public bool solution(string s) 
    {
        bool answer;
        int test = 0;
        if (4== s.Length || s.Length ==6)
            answer = int.TryParse(s, out test);
        else answer = false;
        return answer;
    }
}