using System;
using System.Collections.Generic;

public class Solution
{
    // 조합 사용
    public int solution(int k, int[,] dungeons)
    {
        List<int[]> list = new List<int[]>();

        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            list.Add(new int[] { dungeons[i, 0], dungeons[i, 1] });
        }
        int answer = Premutation(k, list, 0);

        return answer;
    }

    public int Premutation(int k, List<int[]> dungeons, int count)
    {
        int max = count;

        for (int i = 0; i < dungeons.Count; i++)
        {
            if (k >= dungeons[i][0])
            {
                List<int[]> next = new List<int[]>(dungeons);
                next.RemoveAt(i);

                int result = Premutation(k - dungeons[i][1], next, count + 1);
                max = Math.Max(max, result);
            }
        }

        return max;
    }


    // dfs 사용
    int answer = 0;
  
    public int Solution2(int k, int[,] dungeons)
    {
        bool[] visited = new bool[dungeons.GetLength(0)];
        dfs(k, dungeons, visited, 0);
        return answer;
    }

    public void dfs(int k, int[,] dungeons, bool[] visited, int count)
    {
        answer = Math.Max(answer, count);
        for (int i = 0; i < dungeons.GetLength(0); i++)
        {
            if (!visited[i] && k >= dungeons[i, 0]) // 방문 X && 최소 피로도 이상 
            {
                visited[i] = true;
                dfs(k - dungeons[i, 1], dungeons, visited, count + 1);
                
              visited[i] = false; // 백트레킹
            }
        }
    }
}
