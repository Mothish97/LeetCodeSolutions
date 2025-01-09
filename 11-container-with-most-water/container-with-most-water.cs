public class Solution {
    public int MaxArea(int[] height) {
        var left =0;
        var right = height.Length-1;
        var maxArea =0;
        while(left<right)
        {
            var minH = Math.Min(height[left],height[right]);
            var area = minH *(right-left);
            maxArea = Math.Max(maxArea,area );
            if(height[left]>height[right])
            {
                right--;
            }
            else if(height[left]<height[right]) {
                left++;
            }
            else
            {
                left++;
            }       
        }
        return maxArea;
        
    }
}