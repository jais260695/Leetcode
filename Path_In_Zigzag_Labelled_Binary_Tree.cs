public class Solution {
    public IList<int> PathInZigZagTree(int label) {
        List<int> ans = new List<int>();
        ans.Add(label);
        int temp = label;
        int count = 1;
        while(temp>1)
        {
            temp>>=1;
            count<<=1;
        }
        count=count-1;
        while(label>1)
        {        
            count>>=1;
            label = (count)^(label/2);
            ans.Add(label);
        }
        ans.Reverse();
        return ans.ToList<int>();
    }
}