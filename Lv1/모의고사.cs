using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] answers) 
    {
        int[] number1 = {1, 2, 3, 4, 5};
        int[] number2 = {2, 1, 2, 3, 2, 4, 2, 5};
        int[] number3 = {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};

        int[] correct = {0, 0, 0};

        List<int> answer = new List<int>();

        for(int i = 0; i < answers.Length; i++)
        {
            if(number1[i % 5] == answers[i]) correct[0] ++;
            if(number2[i % 8] == answers[i]) correct[1] ++;
            if(number3[i % 10] == answers[i]) correct[2] ++;
        }

        int maxValue = correct.Max();

        for(int i = 0; i < 3; i++)
        {
            if(maxValue == correct[i]) 
            {
                answer.Add(i + 1);
            }
        }
        return answer.ToArray();
    }
}
