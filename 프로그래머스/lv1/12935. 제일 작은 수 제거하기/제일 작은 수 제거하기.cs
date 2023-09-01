using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] arr)
    {
        List<int>answer = new List<int>();
        int min = arr[0];
        if (arr.Length <= 1)
        {
            answer.Clear();
            answer.Add(-1);
        }
         // 배열 길이가 1이거나 0이면 -1
        
        else
        {
            for(int i = 0; i<arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            } 
            // 최소값 찾아서 저장하기
            
            for (int i =0; i<arr.Length; i++)
            {
                answer.Add(arr[i]);
            }
            answer.Remove(min);
            // answer List에 arr 배열 모든 값 할당한 후 최소값만 제거     
        } 
    
        return answer.ToArray();
    }
}