using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        int count = 0;
        int temp = 0;

        Dictionary<int, int> ranking = new Dictionary<int, int>()
        {
            {6, 1}, {5, 2}, {4, 3}, {3, 4}, {2, 5}, {1, 6}, {0, 6}
        };

        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
            {
                temp ++;
                continue;
            } 

            for(int j = 0; j < win_nums.Length; j++)
            {
                if(lottos[i] == win_nums[j]) count++;
            }
        }

        answer[0] = ranking[count + temp];
        answer[1] = ranking[count];

        return answer;
    }

    // 이중 for문 대신 HashSet 사용
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        HashSet<int> winHash = new HashSet<int>(win_nums);

        Dictionary<int, int> ranking = new Dictionary<int, int>()
        {
            {6, 1}, {5, 2}, {4, 3}, {3, 4}, {2, 5}, {1, 6}, {0, 6}
        };
        
        int zero = 0;
        int count = 0;

        for(int i = 0; i < lottos.Length; i++)
        {
            if(lottos[i] == 0)
            {
                zero ++;
            }
            else if(winHash.Contains(lottos[i]))
            {
                count ++;
            }
        }

        answer[0] = ranking[count + zero];
        answer[1] = ranking[count];

        return answer;
    }
}
