using System;
using System.Collections.Generic;

public class Solution 
{
    public int solution(string[,] clothes) 
    {
        int answer = 1;
        Dictionary<string, int> type = new Dictionary<string, int>();

        for(int i = 0; i < clothes.GetLength(0); i++)
        {
            if(type.ContainsKey(clothes[i,1]))
            {
                type[clothes[i , 1]]++;
            }
            else
            {
                type[clothes[i , 1]] = 1;
            }
        }

        foreach(var cnt in type)
        {
            answer *= (cnt.Value + 1);
        }

        return answer - 1;
    }
}
