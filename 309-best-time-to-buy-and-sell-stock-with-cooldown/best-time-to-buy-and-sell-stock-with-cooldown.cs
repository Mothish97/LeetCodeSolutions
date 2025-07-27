public class Solution {
    public Dictionary<(int,bool),int> dct = new Dictionary<(int,bool),int>();
    public int MaxProfit(int[] prices) {
        return dfs(prices,true,0);
    }

    public int dfs(int [] prices, bool isBuy, int lvl)
    {
        if(lvl >= prices.Count())
        {
            return 0;
        }
        if(dct.ContainsKey((lvl,isBuy)))
        {
            return dct[(lvl,isBuy)];
        }
        
        //Console.WriteLine($"Skip{lvl}");
        var skip = dfs(prices,isBuy,lvl+1);
        
        if(isBuy)
        {
           // Console.WriteLine($"Buy  {lvl}");
            var buy = dfs(prices,false,lvl+1);
            // Console.WriteLine($"Buy {buy} prices[lvl] {prices[lvl]}  lvl {lvl}");
            dct.Add((lvl,isBuy),Math.Max(skip,buy - prices[lvl]));
            return Math.Max(skip,buy - prices[lvl]);
        }
        else{
        //Console.WriteLine($"Sell {lvl}");
           var sell = dfs(prices,true,lvl+2);
        //    Console.WriteLine($"sell {sell} prices[lvl] {prices[lvl]}  lvl {lvl}");
            dct.Add((lvl,isBuy), Math.Max(sell + prices[lvl],skip));
           return  Math.Max(sell + prices[lvl],skip);
        }
    }
}