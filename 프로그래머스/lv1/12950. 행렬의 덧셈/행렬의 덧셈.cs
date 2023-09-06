public class Solution 
{
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int rows = arr1.GetLength(0); // 행 길이
        int cols = arr1.GetLength(1); // 열 길이
        
        int[,] answer = new int[rows, cols];
        for (int i = 0; i < rows; i++) // 행의 길이만큼 반복
        {
            for (int j = 0; j < cols; j++) // 열의 길이 만큼 반복
            {
                answer[i, j] = 
                    arr1[i, j] + arr2[i, j]; // 각 행, 열의 인덱스 더하기
            }
        }
        return answer;
    }
}