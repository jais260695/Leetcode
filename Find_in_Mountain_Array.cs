/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    int n;
    int peak;
    public int FindPeak(MountainArray arr)
    {
        int l = 0;
        int r = n-1;
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(mid-1<0 || arr.Get(mid)>arr.Get(mid-1))
            {
                if(mid+1>=n || arr.Get(mid)>arr.Get(mid+1))
                {
                    return mid;
                }
                else
                {
                    l = mid + 1;
                }
            }
            else
            {
                r = mid - 1;
            }
        }
        return -1;
    }
    
    public int SearchLeft(int l, int r,int t,MountainArray arr)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(arr.Get(mid)==t)
            {
                return mid;
            }
            else if(arr.Get(mid)<t)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return -1;
    }
    
     public int SearchRight(int l, int r,int t,MountainArray arr)
    {
        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(arr.Get(mid)==t)
            {
                return mid;
            }
            else if(arr.Get(mid)>t)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return -1;
    }
    
    
    
    public int FindInMountainArray(int target, MountainArray mountainArr) {
        n = mountainArr.Length();
        peak = FindPeak(mountainArr);
        if(mountainArr.Get(peak)==target) return peak;
        
        int leftResult = SearchLeft(0,peak,target,mountainArr);
        if(leftResult!=-1)
        {
            return leftResult;
        }
        
        return SearchRight(peak+1,n-1,target,mountainArr);
    }
}