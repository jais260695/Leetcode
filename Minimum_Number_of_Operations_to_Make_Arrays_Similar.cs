public class Solution {
    public long MakeSimilar(int[] nums, int[] target) {
        int n = nums.Count();

        List<int>[] odd = new List<int>[2];
        odd[0] = new List<int>();
        odd[1] = new List<int>();

        List<int>[] even = new List<int>[2];
        even[0] = new List<int>();
        even[1] = new List<int>();

        for(int i=0;i<n;i++)
        {
            if(nums[i]%2==0)
            {
                even[0].Add(nums[i]);
            }
            else
            {
                odd[0].Add(nums[i]);
            }

            if(target[i]%2==0)
            {
                even[1].Add(target[i]);
            }
            else
            {
                odd[1].Add(target[i]);
            }
        }

        odd[0].Sort();
        odd[1].Sort();
        long result = 0;
        for(int i=0;i<odd[0].Count();i++)
        {
            if(odd[0][i]>odd[1][i])
            {
                result+=(long)(odd[0][i]-odd[1][i])/2;
            }
        }

        even[0].Sort();
        even[1].Sort();
        for(int i=0;i<even[0].Count();i++)
        {
            if(even[0][i]>even[1][i])
            {
                result+=(long)(even[0][i]-even[1][i])/2;
            }
        }

        return result;
    }
}