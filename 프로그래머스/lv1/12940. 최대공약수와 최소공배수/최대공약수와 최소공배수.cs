public class Solution 
{
    public int[] solution(int n, int m) 
    {
        int[] answer = new int[2];
        int gcd = CalcGCD(n, m);
        int lcm = CalcLCM(n, m);
        answer[0] = gcd;
        answer[1] = lcm;
        return answer;
    }
    int CalcGCD(int a, int b)
    {
        while(b!=0)
        {
            int tmp = a%b;
            a = b;
            b = tmp;
        }
        return a;
    }
    int CalcLCM(int a, int b)
    {
        int gcd = CalcGCD(a,b);
        int lcm = (a*b) / gcd;
        return lcm;
    }
        
}