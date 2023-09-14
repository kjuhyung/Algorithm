using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int maxWidth = 0;
        int maxHeight = 0;
        
        for (int i = 0; i<sizes.GetLength(0); i++)
        {
            int width = Math.Max(sizes[i,0],sizes[i,1]); 
            int height = Math.Min(sizes[i,0],sizes[i,1]); // 앞,뒤 값을 비교하여 큰 값을 가로로 작은 값을 세로로 지정
            if (maxWidth < width)
                maxWidth = width;
            if (maxHeight < height)
                maxHeight = height;
            // 가로,세로 중 가장 큰 값 지정
        }
        return maxWidth * maxHeight;
    }
}