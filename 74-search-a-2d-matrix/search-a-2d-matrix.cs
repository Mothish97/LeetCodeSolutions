public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        var lst = new List<int>();
        foreach(var a in matrix)
        {
            lst.AddRange(a.ToList());
        }
        Console.WriteLine(String.Join(",",lst));
        var left = 0;
        var right = lst.Count-1;
        while(left<=right)
        {
            var mid = left + (right - left) /2;
            if(lst[mid]< target)
            {
                left= mid+1;
            }
            else if(lst[mid]>target)
            {
                right = mid-1;
            }
            else{
                return true;
            }
        }
        return false;
    }
}