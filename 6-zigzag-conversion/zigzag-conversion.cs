public class Solution {
    public string Convert(string s, int numRows) 
    {
    if (numRows == 1 || s.Length <= numRows)
    return s;

     var dct = new Dictionary<int,List<char>>();
     for(int i =0;i<numRows;i++)
     {
        dct.Add(i,new List<char>());
     }
     int curRow = 0;
     var isDown = true;
     foreach(var c in s)
     {
        dct[curRow].Add(c);
        if(isDown)
        {
            curRow++;
        }else{
            curRow--;
        }
        if(curRow == 0)
        {
            isDown = true;
        } 
        if(curRow == numRows-1)
        {
            isDown = false;
        }
     }
     var res ="";
     foreach(var d in dct)
     {
        res += new string(d.Value.ToArray());
     }
     return res;
    }
}