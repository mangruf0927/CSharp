public class Solution
{    
    // queue 사용
    public int solution(int[] order)
    {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>(order);

        int answer = 0;

        for (int i = 1; i <= order.Length; i++)
        {
            if (queue.Peek() == i)
            {
                queue.Dequeue();
                answer++;

                while (queue.Count > 0 && stack.Count > 0)
                {
                    if (queue.Peek() != stack.Peek()) break;

                    queue.Dequeue();
                    answer++;
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(i);
            }

        }

        return answer;
    }

    // index 사용
    public int solution2(int[] order)
    {
        Stack<int> stack = new Stack<int>();
        int index = 0;

        int answer = 0;

        for (int i = 1; i <= order.Length; i++)
        {
            if (order[index] == i)
            {
                index++;
                answer++;

                while (stack.Count > 0 && stack.Peek() == order[index])
                {
                    index++;
                    answer++;
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(i);
            }

        }

        return answer;
    }
}
