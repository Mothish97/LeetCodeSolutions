public class Solution {
    public int PossibleStringCount(string word)
    {
        var freq = new List<int>();
        var left = 0; 
        var right = 1;

        while(right<word.Count())
        {
            //Console.WriteLine($"{word[left]} == {word[right]}" );
            if(word[left] == word[right])
            {
                right++;
            }
            else
            {
                freq.Add(right-left);
                left=right;
                right= left+1;
            }
        }
        freq.Add(right-left);
        //Console.WriteLine(string.Join(",",freq));
        if(freq.Max()== 1)
        {
            return 1;
        }
        var res =1;
        foreach(var d in freq)
        {
            if(d>1)
            {
                res += d-1;
            }
        }
        return res;

        
    }
}