public class Solution {
    public bool LemonadeChange(int[] bills) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        dict.Add(5,0);
        dict.Add(10,0);
        int n = bills.Count();
        for(int i=0;i<n;i++)
        {
            if(bills[i]==5)
            {
                dict[5]++;
            }
            else if(bills[i]==10)
            {
                if(dict[5]>0)
                {
                    dict[5]--;
                }
                else
                    return false;
                dict[10]++;
            }
            else
            {
                if(dict[10]>0 && dict[5]>0)
                {
                    dict[10]--;
                    dict[5]--;
                }
                else if(dict[5]>2)
                {
                    dict[5]-=3;
                }
                else
                    return false;
            }
            
        }
        return true;
    }
}