public class Solution 
{
    public static Dictionary<int, char> dct = Enumerable.Range(1, 26)
    .ToDictionary(i => i, i => (char)('a' + i - 1));
    public string GetSmallestString(int n, int k) 
    {
        char[] arr = Enumerable.Repeat('a', n).ToArray();
        k = k-n;
        var i =0;
        while(k>0)
        {
            k++;
            if(k>=26)
            {
                k = k-26;
                arr[i] = 'z';
            }
            else{
                arr[i] = dct[k];
                k=0;
            }
            i++;
        }
        Array.Reverse(arr);
        return  new string(arr);




    }
}

//74 4 a
//73 3 a
//72 2 a
//