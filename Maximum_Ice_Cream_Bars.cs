public class Solution {
    public void QuickSort(int[] arr, int l, int h)
    {
        if(l>=h) return;
        int pivot = FindPivot(arr, l, h);
        QuickSort(arr,l,pivot-1);
        QuickSort(arr,pivot+1,h);
    }
    
    public int FindPivot(int[] arr, int l, int h)
    {
        int pivot = arr[h];
        int i=0;
        int j=i-1;
        while(i<h)
        {
             if(arr[i]<=pivot)
             {
                 j++;
                 Swap(arr,i,j);
             }
            i++;
        }
        j++;
        Swap(arr,h,j);
        return j;
    }
    
    public void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    
    public int MaxIceCream(int[] costs, int coins) {
        int n = costs.Count();
        //QuickSort(costs,0,n-1);
        Array.Sort(costs);
        int i=0;
        while(coins>0 && i<n)
        {
            if(costs[i]>coins) break;
            coins-=costs[i];
            i++;
        }
        return i;
    }
}