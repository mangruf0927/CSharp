using System;

// 삼중 for문
public class Solution
{
  public int solution(int[] number)
    {
        int answer = 0;
        
        for (int i = 0; i < number.Length - 2; i++)
        {
            for (int j = i + 1; j < number.Length - 1; j++)
            {
                for (int k = j + 1; k < number.Length; k++)
                {
                    if (number[i] + number[j] + number[k] == 0) answer++;
                }
            }
        }

        return answer;
    }
}

// dfs 사용
public class Solution
{
    int answer;
    
  public int solution(int[] number)
    {
        answer = 0;
        dfs(number, 0, 0, 0);
        
        return answer;
    }

    public void dfs(int[] number, int start, int count, int sum)
    {
        if (count == 3)
        {
            if (sum == 0) answer++;
            return;
        }

        for (int i = start; i < number.Length; i++)
        {
            dfs(number, i + 1, count + 1, sum + number[i]);
        }
    }
}
