using System;

public class Solution 
{
    float sum = 0;
    public double solution(int[] numbers) 
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum / numbers.Length;
    }
}