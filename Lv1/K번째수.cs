using System;

public class Solution 
{
    public int[] solution(int[] array, int[,] commands) 
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1] - 1;
            int num = end - start + 1;

            int[] temp = new int[num];

            for (int j = 0; j < num; j++)
            {
                temp[j] = array[j + start];
            }
            
            Array.Sort(temp);
            answer[i] = temp[commands[i, 2] - 1];
        }

        return answer;
    }
}
