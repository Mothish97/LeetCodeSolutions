public class Solution {
    public int Jump(int[] nums) {
        if (nums.Length == 1) return 0; // No jumps needed if we are already at the last index.

        int res = 0, curPos = 0;

        while (curPos < nums.Length - 1) {
            // If we can directly reach the last index in one jump
            if (curPos + nums[curPos] >= nums.Length - 1) {
                return res + 1;
            }

            int maxStep = 0;
            int maxInd = curPos; // Track the best index to jump to

            // Explore all possible jumps within range
            for (int j = curPos + 1; j <= curPos + nums[curPos]; j++) {
                if (j >= nums.Length) break; // Avoid out-of-bounds

                // Choose the index that gives the farthest reach
                if (j + nums[j] > maxStep) {
                    maxStep = j + nums[j]; // Track farthest reach
                    maxInd = j; // Update best index to jump to
                }
            }

            Console.WriteLine($"Jumping to index: {maxInd}");
            curPos = maxInd; // Move to the best index
            res++; // Increment jump count
        }

        return res;
    }
}
