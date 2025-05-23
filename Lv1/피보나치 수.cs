public class Solution 
{
    public int solution(int n) 
    {
        int answer = 0;
        int prev1 = 0; int prev2 = 1;
        
        for(int i = 2; i < n + 1; i++)
        {
            answer = (prev1 + prev2) % 1234567;
            prev1 = prev2;
            prev2 = answer;
        }
        
        return answer;
    }
}
