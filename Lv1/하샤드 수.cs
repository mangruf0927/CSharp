public class Solution 
{
    public bool solution(int x) 
    {
        int sum = 0;
        int num = x;

        while (x > 0)
        {
            sum += x % 10;
            x /= 10;
        }

        return (num % sum == 0);
    }
}

// 문자열 사용
public class Solution 
{
    public bool solution(int x) 
    {
        int sum = 0;

        foreach (char c in x.ToString())
        {
            sum += c - '0';
        }

        return (x % sum == 0);
    }
}
