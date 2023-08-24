using System;

public class Solution
{
    public int solution(int n, int k)
    {   
        int food = 0;
        int drink = 0;
        int ser = 0;
        
        ser = (n / 10) * 2000 ;
        food = n * 12000;
        drink = k * 2000;
        int result = food + drink - ser;
        
        return result;
    }
}