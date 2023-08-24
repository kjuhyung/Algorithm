using System;

public class Solution {
    public int solution(float num1, float num2) {
        float answer = 0;
        
        answer = (num1 / num2) * 1000 ;
        return (int)answer;
    }
}