public class Solution {
    public List<List<int>> result = new List<List<int>>();
    public void Function(int[] nums, int i)
    { 
        if(i>=nums.Count()-1) 
        { 
            result.Add(nums.ToList());
            return;
        }
        for(int j = i;j<nums.Count();j++)
        {
            Swap(nums,j,i);
            Function(nums,i+1);
            Swap(nums,j,i);
        }    
    }
    
    public void Swap(int[] list, int i, int j)
    {
            int temp = list[j];
            list[j] = list[i];
            list[i] = temp;
    }
    
    public IList<IList<int>> Permute(int[] nums) {
        for(int i =0 ;i<nums.Count();i++)
        {  
            Swap(nums,0,i);  
            Function(nums,1);
            Swap(nums,0,i);
        } 
        return result.ToList<IList<int>>();
    }
}