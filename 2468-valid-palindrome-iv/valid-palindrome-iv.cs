public class Solution {
    public bool MakePalindrome(string s) {
        var left =0; 
        var right = s.Length-1;
        var swap = 0;
        while(left<=right)
        {
            //Console.WriteLine($"left: {s[left]} right: {s[right]}");
            if(s[left]!= s[right])
            {
                swap++;
            }
            if(swap>2)
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
        
    }
}