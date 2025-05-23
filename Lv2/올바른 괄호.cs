// 스택 사용
using System;
using System.Collections.Generic;

public class Solution 
{
    public bool solution(string s) 
    {        
        Stack<char> stack = new Stack<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                stack.Push('(');
            }
            else if(s[i] == ')')
            {
                if(stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        if(stack.Count == 0) return true;
        else return false;
    }
}


// 카운트 변수 이용 -------

public class Solution 
{
    public bool solution(string s) 
    {
        int count = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(')
            {
                count++;
            }
            else if(s[i] == ')')
            {
                count--;
            }

            if(count < 0) return false;
        }

        return (count == 0);
    }
}
