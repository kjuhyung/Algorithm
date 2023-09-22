using System;

public class Solution
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int leng = commands.GetLength(0);
        
        int[] answer = new int[leng];
        
        for (int n = 0; n < leng; n++)
        {
            int i = commands[n,0];
            int j = commands[n,1];
            int k = commands[n,2];
            
            int[] temp = new int[j - i + 1];
            
            for(int m = 0; m < temp.Length; m++)
            {
                temp[m] = array[i + m -1];
            }
            Array.Sort(temp);
            answer[n] = temp[k-1];            
        }      
        return answer;
    }
}