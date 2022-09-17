public class Solution {
    public int JustSmallerOrEqual(int l, int r, int target, int[] people)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            
            if(people[mid]<=target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        
        return  l-1;
    }
    public int NumRescueBoats(int[] people, int limit) {
        int n = people.Count();
        
        Array.Sort(people);
        
        int i = 0;
        int j = n-1;
        
        int ans = 0;
        
        while(i<=j)
        {
            int justSmallerOREqual = JustSmallerOrEqual(i,j,limit-people[i],people);
            if(justSmallerOREqual<=i)
            {
                ans+=(j-(i-1));
                break;
            }
            
            ans+=(j-justSmallerOREqual + 1);
            i++;
            j=justSmallerOREqual-1;
        }   
        
        return ans;
    }
}