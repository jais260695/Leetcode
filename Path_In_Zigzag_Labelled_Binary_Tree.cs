public class Solution {
    public IList<int> PathInZigZagTree(int label) {
        List<int> ans = new List<int>();
        ans.Add(label);
        int temp = label;
        int count = 0;
        while(temp>1)
        {
            temp>>=1;
            count++;
        }
        temp=1<<count;
        while(label>1)
        {
            
            int parent = (label/2);
            int realParent = 0;
            count=0;
            while(parent>1)
            {
                if((parent&1)==0)
                {
                    realParent+= 1<<count;
                }
                parent>>=1;
                count++;
            }
            realParent+=(1<<count);
            ans.Add(realParent);
            label = realParent;
        }
        ans.Reverse();
        return ans.ToList<int>();
    }
}