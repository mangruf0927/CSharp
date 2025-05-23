using System;

public class Solution 
{
    public int[] solution(int[] prices) 
    {
        int[] answer = new int[prices.Length];

        for (int i = 0; i < prices.Length - 1; i++)
        {
            int count = 0;

            for (int j = i + 1; j < prices.Length; j++)
            {
                count++;

                if(prices[i] > prices[j])
                {
                    answer[i] = count;
                    break;
                }
            }
            
            answer[i] = count;
        }

        return answer;
    }
}

// Stack 사용
using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] prices) 
    {
        int[] answer = new int[prices.Length];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[i] < prices[stack.Peek()])
            {
                int index = stack.Pop();
                answer[index] = i - index;
            }

            stack.Push(i);
        }

        while (stack.Count > 0)
        {
            int index = stack.Pop();
            answer[index] = prices.Length - index - 1;
        }

        return answer;
    }
}
