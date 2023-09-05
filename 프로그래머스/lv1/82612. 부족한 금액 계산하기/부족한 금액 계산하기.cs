class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum = 0; 
        for (int i =1; i<= count; i++)
        {
            sum += price * i; // 필요한 금액
        }
        if (money > sum)
        {
            return 0; // 부족하지 않으면 0
        }
        else return sum - money; // 부족한 금액
    }
}