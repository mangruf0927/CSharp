using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] progresses, int[] speeds) 
    {
        List<int> days = new List<int>();
        List<int> answer = new List<int>();

        for(int i = 0; i < progresses.Length; i++)
        {
            if((100 - progresses[i]) % speeds[i] == 0 )
            {
                days.Add((100 - progresses[i]) / speeds[i]);
            }
            else if((100 - progresses[i]) % speeds[i] != 0)
            {
                days.Add((100 - progresses[i]) / speeds[i] + 1);
            }
        }

        int standard = days[0];
        int count = 1;

        for(int i = 1; i < days.Count; i++)
        {
            if(standard >= days[i])
            {
                count ++;
            }
            else
            {
                answer.Add(count);
                standard = days[i];
                count = 1;
            }
        }

        answer.Add(count);

        return answer.ToArray();
    }

  // Queue 사용
  public int[] SolutionWithQueue(int[] progresses, int[] speeds) 
    {
        Queue<int> queue = new Queue<int>();
        List<int> answer = new List<int>();

        for(int i = 0; i < progresses.Length; i++)
        {
            int days = 0;

            if((100 - progresses[i]) % speeds[i] == 0 )
            {
                days = (100 - progresses[i]) / speeds[i];
            }
            else
            {
                days = (100 - progresses[i]) / speeds[i] + 1;
            }
            queue.Enqueue(days);
        }

        while(queue.Count > 0)
        {
            int standard = queue.Dequeue();
            int count = 1;

            while(queue.Count > 0 && queue.Peek() <= standard)
            {
                queue.Dequeue();
                count ++;
            }

            answer.Add(count);
        }

        return answer.ToArray();
    }
}
