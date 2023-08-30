public class Solution
{
    public int solution(long num) 
    {
        long answer = 0;
        int i = 0;
        for (i = 1; num != 1; i++)
        {
            if (num%2 == 0)
            {
                num /= 2;
            }
            else if (num % 2 !=0)
            {
                num = num * 3+1;
            }
            if (i >= 500)
                return -1; 
        }
        answer = i - 1;
        return (int)answer;
    }
}