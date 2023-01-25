public class Solution {
    int JustGreater(int[] arr, int key)
    {
        int l = 0;
        int r = arr.Count()-1;

        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(arr[mid]>key)
            {
                r = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return l;
    }

    int JustSmaller(int[] arr, int key)
    {
        int l = 0;
        int r = arr.Count()-1;

        while(l<=r)
        {
            int mid = l + (r-l)/2;
            if(arr[mid]<key)
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }
        return r;
    }
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int n = arr.Count();

        int l = JustSmaller(arr,x);
        if(l+1<n && arr[l+1]==x) l++;
        int r = JustGreater(arr,x);
        if(r-1>=0 && arr[r-1]==x) r--;

        List<int> result = new List<int>();

        if(l>=0 && r<n && arr[l]==arr[r])
        {
            int count = r-l+1;
            while(count>0 && k>0)
            {
                result.Add(arr[l]);
                count--;
                k--;
            }
            l--;
            r++;
        }

        for(int i=0;i<k;i++)
        {
            if(l>=0 && r<n)
            {
                if(x-arr[l] <= arr[r]-x)
                {
                    result.Insert(0,arr[l]);
                    l--;
                }
                else
                {
                    result.Add(arr[r]);
                    r++;
                }
            }
            else if(l>=0)
            {
                result.Insert(0,arr[l]);
                l--;
            }
            else
            {
                result.Add(arr[r]);
                r++;
            }
        }

        return result.ToList<int>();
    }
}