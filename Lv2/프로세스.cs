using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] priorities, int location) 
    {
        Queue<int> waiting = new Queue<int>(priorities);
        Queue<int> queue = new Queue<int>();

        while(true)
        {
            int max = waiting.Max();

            if(max == waiting.Peek())
            {
                queue.Enqueue(waiting.Peek());
                waiting.Dequeue();

                location--;
                if(location < 0)
                {
                    return queue.Count;
                }
            }
            else if(max > waiting.Peek())
            {
                waiting.Enqueue(waiting.Peek());
                waiting.Dequeue();

                location--;
                if(location < 0) location = waiting.Count - 1;
            }
        }
    }
}

// 리팩토링 (튜플 사용)
using System;
using System.Linq;
using System.Collections.Generic;

public class Solution 
{
    public int solution(int[] priorities, int location) 
    {
        int answer = 0;
        Queue<(int priority, int index)> queue = new Queue<(int, int)>();

        for(int i = 0; i < priorities.Length; i++)
        {
            queue.Enqueue((priorities[i], i));
        }

        while(true)
        {
            int max = queue.Max(x => x.priority);
            var front = queue.Dequeue();

            if(front.priority == max)
            {
                answer ++;

                if(front.index == location) 
                {
                    return answer;
                }
            }
            else
            {
                queue.Enqueue(front);
            }
        }
    }
}
