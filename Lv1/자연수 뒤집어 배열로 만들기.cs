public class Solution 
{
    public int[] solution(long n) 
    {
        int length = n.ToString().Length;
        int[] answer = new int[length];

        for (int i = 0; i < length; i++)
    {
        answer[i] = (int)(n % 10);
        n /= 10;
    }

        return answer;
    }
}


// List 사용
using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(long n) 
    {
        List<int> answer = new List<int>();

        while (n > 0)
        {
            answer.Add(Convert.ToInt32(n % 10));
            n /= 10;
        }

        return answer.ToArray();
    }
}
