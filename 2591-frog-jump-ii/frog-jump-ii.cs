public class Solution 
{
public int MaxJump(int[] stones) {
    if (stones.Length is 2)
        return stones[1];

    int left = 1;
    int right = stones[^1];
    while (left < right) {
        var mid = (right - left) / 2 + left;
        if (Check(mid))
            right = mid;
        else
            left = mid + 1;
    }
    return left;

    bool Check(int maxJump) {
        for (int i = 2; i < stones.Length; i++) {
            if (stones[i] - stones[i - 2] > maxJump)
                // stone out of reach, maxJump is too short
                return false;
        }
        return true;
    }
}
}