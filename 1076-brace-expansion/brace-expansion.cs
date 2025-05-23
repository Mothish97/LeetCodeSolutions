public class Solution {

    public void dfs(int curlvl,string path,List<string> option,HashSet<string> output)
    {
        if(curlvl == option.Count)
        {
            output.Add(path);
            return;
        }
        foreach(var c in option[curlvl])
        {
            dfs(curlvl+1,path+c.ToString(),option,output);
        }
    }


    public string[] Expand(string s) 
    {
        var options = new List<string>();
        var c ="";
        bool open = false;
        foreach(var i in s)
        {
            if(i == ',') continue;
            if(i == '{')
            {
                open = true;
                c="";
                continue;
            }
            else if(i == '}')
            {
                open = false;
                options.Add(c);
                c="";
                continue;
            }
            if(open)
            {
                c= c+ i.ToString();
            }
            else
            {
                options.Add(i.ToString());
            }
        }
        var ot = new HashSet<string>();
        //Console.WriteLine(string.Join(",", options));
        dfs(0,"",options,ot);
        var result = ot.ToArray();
        Array.Sort(result);
        return result;
    }
}