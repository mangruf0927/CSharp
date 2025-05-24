using System;
using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int solution(string begin, string target, string[] words)
    {
        if (!words.Contains(target)) return 0;
        else return bfs(begin, target, words);
    }

    public int bfs(string begin, string target, string[] words)
    {
        Queue<(string word, int count)> queue = new Queue<(string word, int count)>();
        bool[] visited = new bool[words.Length];

        queue.Enqueue((begin, 0));

        while (queue.Count > 0)
        {
            var (current, count) = queue.Dequeue();

            if (current == target) return count;

            for (int next = 0; next < words.Length; next++)
            {
                if (!HasMatches(current, words[next])) continue;
                if (visited[next]) continue;

                queue.Enqueue((words[next], count + 1));
                visited[next] = true;
            }
        }


        return 0;
    }

    bool HasMatches(string a, string b)
    {
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b[i]) count++;
        }

        if (count >= a.Length - 1) return true;
        else return false;
    }
}
