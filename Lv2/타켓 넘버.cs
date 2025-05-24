using System;

public class Solution 
{
    int answer;
    public int solution(int[] numbers, int target)
    {
        answer = 0;
        bool[] visited = new bool[numbers.Length];

        dfs(numbers, target, 0, 0);
        return answer;
    }

    public void dfs(int[] numbers, int target, int current, int sum)
    {
        if (current == numbers.Length)
        {
            if (sum == target) answer++;
            return;
        }

        dfs(numbers, target, current + 1, sum + numbers[current]);
        dfs(numbers, target, current + 1, sum - numbers[current]);
    }
}
