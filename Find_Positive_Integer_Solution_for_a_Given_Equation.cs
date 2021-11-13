/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z) {
        List<List<int>> res = new List<List<int>>();       
        for(int x=1;x<=1000;x++)
        {
            int l=1, h = 1000;
            while(l<=h)
            {
                int y=l+(h-l)/2;
                if(customfunction.f(x,y)==z)
                {
                    res.Add(new List<int>{x,y});
                    break;
                }
                else if(customfunction.f(x,y)<z)
                {
                    l = y+1;
                }
                else
                {
                    h = y-1;
                }
            }
        }
        return res.ToList<IList<int>>();
    }
}