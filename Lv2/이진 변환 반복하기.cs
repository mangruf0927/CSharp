using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];

        while (s != "1")
        {
            int length = s.Replace("0", "").Length;
            answer[1] += s.Length - length;
            s = Binary(length);   // s = Convert.ToString(length, 2); 바로 이진 변환
            answer[0]++;
        }

        return answer;
    }

    public string Binary(int n)
    {
        Stack<char> stack = new Stack<char>();
        
        while (n > 0)
        {
            stack.Push((char) ('0' + (n % 2)));
            n /= 2;
        }
        return new string(stack.ToArray());
    }
}
