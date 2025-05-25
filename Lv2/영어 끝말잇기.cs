using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> hash = new HashSet<string>();

        string prev = words[0];
        hash.Add(words[0]);

        for (int i = 1; i < words.Length; i++)
        {
            if (prev[prev.Length - 1] == words[i][0])
            {
                if (!hash.Contains(words[i]))
                {
                    hash.Add(words[i]);
                    prev = words[i];
                    continue;
                }
            }

            return new int[] { i % n + 1, i / n + 1};
        }

        return new int[] {0, 0};
    }
}
