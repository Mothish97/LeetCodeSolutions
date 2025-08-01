/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // The result is undefined if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // The result is undefined if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSum(IList<NestedInteger> nestedList) 
    {
        var sum = 0;
        foreach(var s in nestedList)
        {
            if(s.IsInteger())
            {
                sum+= s.GetInteger();
            }
            else{
                sum+= CalculateSum(s,2);
            }
        }
        return sum;
    }

    public int CalculateSum(NestedInteger  lst,int depth)
    {
        var sum = 0;
        foreach(var data in lst.GetList())
        {
            if(data.IsInteger())
            {
                sum += data.GetInteger()* depth;
            }
            else
            {
                sum+=CalculateSum(data,depth+1);
            }
        }

        
        return sum;
    }
}