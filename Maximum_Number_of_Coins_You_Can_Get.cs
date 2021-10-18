public class Solution {
    
    public void Swap(int[] piles, int i, int j)
    {
        int temp = piles[i];
        piles[i] = piles[j];
        piles[j] = temp;
    }
    
    public int Partition(int[] piles, int l, int h)
    {
        int j=l-1;
        for(int i=l;i<h;i++)
        {
            if(piles[i]<=piles[h])
            {
                j++;
                Swap(piles,i,j);
            }
        }
        Swap(piles,h,j+1);
        
        return j+1;
            
    }
    
    public void QuickSort(int[] piles, int l, int h)
    {
        if(l<=h)
        {
            int p = Partition(piles,l,h);
            QuickSort(piles,l,p-1);
            QuickSort(piles,p+1,h);
        }
    }
    
    public int MaxCoins(int[] piles) {
        int len = piles.Count();
        QuickSort(piles,0,len-1);
        
        int n = len/3;
        int res = 0;
        
        for(int i= len-2;i>=n;i=i-2)
        {
            res+=piles[i];
        }
        
        return res;
    }
}