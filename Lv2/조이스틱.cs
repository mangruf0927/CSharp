using System;

public class Solution
{
    public int solution(string name)
    {
        int count = 0;

        // 상하 조작
        for (int i = 0; i < name.Length; i++)
        {
            count += Math.Min(name[i] - 'A', 'Z' - name[i] + 1);
        }

        // 좌우 조작
        int min = name.Length - 1;

        for (int i = 0; i < name.Length; i++)
        {
            int next = i + 1;

            while (next < name.Length && name[next] == 'A')
            {
                next++;
            }

            int right = i + i + name.Length - next; 
            int left = 2 * (name.Length - next) + i; 

            min = Math.Min(min, Math.Min(right, left));
        }

        return count + min;
    }
}
