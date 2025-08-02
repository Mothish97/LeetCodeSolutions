public class Solution {
    public int MaximumGain(string st, int x, int y) 
    {
        var res = 0;
        var lst = st.ToCharArray().ToList();
        var fpr = "ab";
        var f=x;
        var spr = "ba";
        var s = y;
        if(y>x)
        {
            fpr = "ba";
            spr=  "ab";
            s=x;
            f=y;
        }

        var i =0;
        while(i<lst.Count()-1)
        {
            var str = $"{lst[i]}{lst[i+1]}";
            if(str == fpr)
            {
                res+= f;
                lst.RemoveAt(i);
                lst.RemoveAt(i);
                i--;
                if(i<0) i=0;

            }
            else{
                i++;
            }
        }

        i =0;
        while(i<lst.Count()-1)
        {
            var str = $"{lst[i]}{lst[i+1]}";
            if(str == fpr)
            {
                res+= f;
                lst.RemoveAt(i);
                lst.RemoveAt(i);
                i--;
                if(i<0) i=0;

            }
            else if(str == spr)
            {
                res+= s;
                lst.RemoveAt(i);
                lst.RemoveAt(i);
                i--;
                if(i<0) i=0;
            }
            else{
                i++;
            }
        }
        return res;
        
    }
}