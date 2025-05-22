using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string X, string Y) 
    {
        List<char> answer = new List<char>();

        int[] CountX = new int[10];
        int[] CountY = new int[10];

        foreach(var cnt in X)
        {
            CountX[cnt - '0']++;
        }

        foreach(var cnt in Y)
        {
            CountY[cnt - '0']++;
        }

        for(int i = 9; i >=0; i--)
        {
            int common = Math.Min(CountX[i], CountY[i]);
            for(int j = 0; j < common; j++)
            {
                answer.Add((char)(i + '0'));
            }
        }

        if(answer.Count == 0) return "-1";
        if(answer[0] == '0') return "0";

        return new String(answer.ToArray());
    }
}
