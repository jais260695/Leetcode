public class Solution {
    public class Pair
    {
        public int Value;
        public int Index;
        
        public Pair(int v, int i)     
        {
            Value = v;
            Index = i;
        }
    }
    
    Pair[] numAndIndex ;
    List<int> result;
    
    public void Merge(int l, int mid, int r)
    {
        int leftSize = mid-l+1;
        int rightSize = r-mid;       
        int index = l;
        
        Pair[] leftArr = new Pair[leftSize];
        Pair[] rightArr = new Pair[rightSize];
        
        for(int i = 0;i<leftSize;i++)
        {
            leftArr[i] = numAndIndex[l+i];
        }
        
        for(int j = 0;j<rightSize;j++)
        {
            rightArr[j] = numAndIndex[mid+1+j];
        }
        
        int leftIndex = 0;
        int rightIndex = 0;
        
        while(leftIndex<leftSize && rightIndex<rightSize)
        {
            if(leftArr[leftIndex].Value > rightArr[rightIndex].Value)
            {
                result[leftArr[leftIndex].Index] += rightSize - rightIndex;
                numAndIndex[index] = leftArr[leftIndex];
                leftIndex++;
                index++;
            }
            else
            {
                numAndIndex[index] = rightArr[rightIndex];
                rightIndex++;
                index++;
            }
        }
        
        while(rightIndex<rightSize)
        {
 
                numAndIndex[index] = rightArr[rightIndex];
                rightIndex++;
                index++;
        }
        while(leftIndex<leftSize)
        {

                numAndIndex[index] = leftArr[leftIndex];
                leftIndex++;
                index++;
        }
        
    }
    
    public void MergeSort(int l, int r)
    {
        if(l>=r) return;
        int mid = l + (r-l)/2;
        MergeSort(l,mid);
        MergeSort(mid+1,r);
        
        Merge(l,mid,r);
    }
    
    public IList<int> CountSmaller(int[] nums) {
        int n = nums.Count();
        
        numAndIndex = new Pair[n];
        result = new List<int>();
        
        for(int i=0;i<n;i++)
        {
            numAndIndex[i] = new Pair(nums[i],i);
            result.Add(0);
        }
        
        MergeSort(0,n-1);
        
        return result.ToList<int>();
        
    }
}