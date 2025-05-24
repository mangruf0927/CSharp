using System;
using System.Text;

// StringBuilder 사용 
public class Solution 
{
    public string solution(string number, int k)
    {
        StringBuilder str = new StringBuilder();

        for (int i = 0; i < number.Length; i++)
        {
            char current = number[i];

            while (k > 0 && str.Length > 0 && str[str.Length - 1] < current)
            {
                str.Length--; // 마지막 문자 제거
                k--;
            }

            str.Append(current);
        }

        if (k > 0) str.Length -= k;

        return str.ToString();
    }
}

// Stack 사용
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public string solution(string number, int k)
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < number.Length; i++)
        {
            while (stack.Count > 0 && k > 0 && stack.Peek() < number[i])
            {
                stack.Pop();
                k--;
            }
            stack.Push(number[i]);
        }

        while (k > 0)
        {
            stack.Pop();
            k--;
        }

        return new string(stack.Reverse().ToArray());
    }

}


