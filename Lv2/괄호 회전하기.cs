using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string s) 
    {
        int answer = 0;
        int j;

        Stack<char> brackes = new Stack<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            brackes.Clear();
            
            for (j = 0; j < s.Length; j++)
            {
                char c = s[(i + j) % s.Length];

                if (c == '{' || c == '[' || c == '(')
                {
                    brackes.Push(c);
                }
                else
                {
                    if (brackes.Count == 0) break;

                    if (c == ')' && brackes.Pop() != '(' ||
                        c == ']' && brackes.Pop() != '[' ||
                        c == '}' && brackes.Pop() != '{') break;
                }
            }

            if (j == s.Length && brackes.Count == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}
