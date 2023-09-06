using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int n = int.Parse(s[0]); 
        int m = int.Parse(s[1]);
        // n 과 m int 변환
        
        for (int i = 1; i <= m; i++)
        {
            for(int j =1; j <= n; j++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}