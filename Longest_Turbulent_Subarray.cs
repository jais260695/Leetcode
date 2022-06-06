public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        int n = arr.Length;
        int result = 1;
        int i = 0;
        while(i<n)
        {
            
            int sign = 0;
            int j = i+1;
            if(j<n && arr[j]>arr[i])
            {
                sign = -1;
            }
            else if(j < n && arr[j]<arr[i])
            {
                sign = 1;
            }
            
            if(sign!=0)
            {
                j++;
                while(j<n)
                {
                    if(sign==-1)
                    {
                        if(arr[j]<arr[j-1])
                        {
                            sign = 1;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        if(arr[j]>arr[j-1])
                        {
                            sign = -1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    j++;
                }
            }
            
            result = Math.Max(result,j-i);
            if(i==j-1) i=j;
            else i=j-1;
        }
         
        return result; 
    }
}