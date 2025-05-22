using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(string s) 
    {
        int[] answer = new int[s.Length];

        Dictionary<char, int> letter = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (letter.ContainsKey(s[i]))
            {
                answer[i] = i - letter[s[i]];
            }
            else
            {
                answer[i] = -1;
            }
            letter[s[i]] = i;
        }
        return answer;
    }
}
