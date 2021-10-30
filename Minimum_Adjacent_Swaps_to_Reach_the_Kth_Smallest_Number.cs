public class Solution {
    public int JustGreater(int l, int r, int key, int[] nums)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(nums[mid]<=key)
            {
                r = mid-1;
            }
            else
            {
                l = mid + 1;
            }
        }  
        return r;
    }
    
    public void Swap(int i, int j, int[] nums)
    {
        int temp = nums[i];
        nums[i]= nums[j];
        nums[j] = temp;
        return;
    }
    
    public void Reverse(int l, int r, int[] nums)
    {
        int i = l;
        int j = r;
        while(i<j)
        {
            Swap(i,j,nums);
            i++;
            j--;
        }
    }
    
    public void NextPermutation(int[] nums) {
        int n = nums.Count();
        int i = n-2;        
        while(i>=0 && nums[i+1]<=nums[i])
        {
            i--;
        }        
        if(i<0)
        {
            Reverse(0,n-1,nums);
            return;
        }       
        int justGreater = JustGreater(i+1,n-1,nums[i],nums);
        Swap(i,justGreater,nums);
        Reverse(i+1,n-1,nums);
    }
    public int GetMinSwaps(string num, int k) {
        int n = num.Length;
        int[] nums = new int[n];
        int[] temp = new int[n];
        for(int i=0;i<n;i++)
        {
            nums[i] = num[i] - '0';
            temp[i] = num[i] - '0';
        }        
        for(int i = 0;i<k;i++)
        {
            NextPermutation(nums);
        }
        int result = 0;
        for(int j=0;j<n-1;j++)
        {
            int l = j;
            while(l<n && nums[l]!=temp[j])
            {
                l++;
            }
            while(l>j)
            {
                Swap(l,l-1,nums);
                l--;
                result++;
            }
        }
        return result;
    }
}