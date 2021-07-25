public class Solution {
    List<List<int>> result = new List<List<int>>();
    HashSet<string> map = new HashSet<string>();
    public void PermuteUtil( int[] nums, int index, int n, string t)
    {
        if(index==n)
        {
            if(map.Contains(t)) return;
            map.Add(t);
            result.Add(nums.ToList());
            return;
        }
        
        for(int i = index;i<n;i++)
        {
            if(i==index || nums[i]!=nums[index])
            {
                Swap(nums,i,index);
                PermuteUtil(nums,index+1,n, t+"-"+nums[index]);
                Swap(nums,i,index);
            }

        }
                
    }
    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
        return;
    }
    public IList<IList<int>> PermuteUnique(int[] nums) {
        int n = nums.Count();
        PermuteUtil(nums,0,n,"");
        return result.ToList<IList<int>>();
    }
}