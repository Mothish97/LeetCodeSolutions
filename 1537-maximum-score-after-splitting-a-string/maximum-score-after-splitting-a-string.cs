public class Solution {
    public int MaxScore(string s) {
        int maxScore = 0;
        int leftZerosCount = 0;
        int rightOnesCount = s.Split('1').Length - 1;

        for (int i = 0; i < s.Length - 1; i++)
        {
            leftZerosCount += s[i] == '0' ? 1 : 0;
            rightOnesCount -= s[i] == '1' ? 1 : 0;
            int currentScore = leftZerosCount + rightOnesCount;
            maxScore = Math.Max(maxScore, currentScore);
        }

        return maxScore;
    }
}