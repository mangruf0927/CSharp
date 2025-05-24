using System;
using System.Collections.Generic;

class Solution
{
    int[,] directions = new int[,] { { 0, -1 }, { 0, 1 }, { -1, 0 }, { 1, 0 } }; // 상하좌우

    public int solution(int[,] maps)
    {
        bool[,] visited = new bool[maps.GetLength(0), maps.GetLength(1)];

        return bfs(maps, visited);
    }

    public int bfs(int[,] maps, bool[,] visited)
    {
        Queue<(int x, int y)> queue = new Queue<(int, int)>();
        int[,] distance = new int[maps.GetLength(0), maps.GetLength(1)];

        visited[0, 0] = true;
        queue.Enqueue((0, 0));
        distance[0, 0] = 1;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.Item1 == maps.GetLength(0) - 1 && current.Item2 == maps.GetLength(1) - 1)
            {
                return distance[current.Item1, current.Item2];
            }

            for (int next = 0; next < directions.GetLength(0); next++)
            {
                int x = current.Item1 + directions[next, 0];
                int y = current.Item2 + directions[next, 1];

                if (x < 0 || y < 0 || x >= maps.GetLength(0) || y >= maps.GetLength(1)) continue;
                if (maps[x, y] == 0 || visited[x, y]) continue;

                visited[x, y] = true;
                distance[x, y] = distance[current.Item1, current.Item2] + 1;
                queue.Enqueue((x, y));
            }
        }

        return -1;
    }
}
