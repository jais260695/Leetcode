public class Solution {
    public int[] RecoverArray(int n, int[] sums) {
        int m = sums.Count();
        
        //if size of sums is 2 then it means it has permutaion sum of one element x, thus sums=[0,x] or [x,0]
        if(m==2) 
        {
            int[] res = new int[1];
            res[0] = sums[0]+sums[1];
            return res;        
        }
        
        //sorting sums array will give us the largest two permutaion sums
        //subtracting these two elements will give us one of the possible elements of source array
        Array.Sort(sums);   
        int diff1  = sums[m-1] - sums[m-2];
        int diff2  = sums[m-2] - sums[m-1];
        
        Dictionary<int,int> dict1 = new Dictionary<int,int>();
        Dictionary<int,int> dict2 = new Dictionary<int,int>();
        
        //store the count of occurence of permutaion sum in sums to easily check if two pairs of sum exists
        int i = 0;
        for(;i<m;i++)
        {
            if(!dict1.ContainsKey(sums[i]))
            {
                dict1.Add(sums[i],0);
                dict2.Add(sums[i],0);
            }
            
            dict1[sums[i]]++;
            dict2[sums[i]]++;
        }
        
        
        int[] result = new int[n];
        // we need to check both the possible source element diff1 and diff2 , if they split sums into valid partition or not
        // a valid partition will be of size (size of sums)/2, having a zero in it and having sum S values which have the
        // S-diff value in other partition uniquely mapped to it.
        //Proof : assume n = 3, this will generate below permutaions
        // 1    2   3
        // 0    0   0
        // 0    0   1
        // 0    1   0
        // 0    1   1
        // 1    0   0
        // 1    0   1
        // 1    1   0
        // 1    1   1
        // if we assume the diff is 1st element of source and remove it from persmutaion sum 
        // we will get the partition of half of sums size as below
        //   findkey    =   diff    +    sums[i] 
        // 1    0   0   =   diff    +   0   0   0
        // 1    0   1   =   diff    +   0   0   1
        // 1    1   0   =   diff    +   0   1   0
        // 1    1   1   =   diff    +   0   1   1

        if(dict1.ContainsKey(diff1))
        {
            int[] newSums = new int[m/2];
            int j = 0;
            i=0;
            bool flag = false;
            for(;i<m;i++)
            {      
                int findKey = sums[i]+diff1;//It indicates the diff value contributes in findKey and not in sums[i];

                // if pair findkey and sums[i] exists
                if(dict1[sums[i]]>0 && dict1.ContainsKey(findKey) && dict1[findKey]>0)
                {
                    if(sums[i]==0) flag = true;

                    //assign the sums[i] to newSums array as diff will contribute to findkey but not sums[i].
                    newSums[j] = sums[i];

                    //reduce the count of pair values, so that same sum and findkey values are uniquely mapped to each other
                    dict1[findKey]--;
                    dict1[sums[i]]--;
                    j++;
                }
            }
            
            //create result only if zero exists in partition, having zero will make sure that the partition is valid
            if(flag)
            {
                result = new int[n];

                result[0] = diff1;
                
                //recursively check for n-1 remaining source elements with new partition newSums
                int[] newResult = RecoverArray(n-1, newSums);
                
                for(i=0;i<n-1;i++)
                {
                    result[i+1] = newResult[i];
                }
                return result;
            }
            
        }

        //check other possible value of diff1 is not valid
        if(dict2.ContainsKey(diff2))
        {
               
            result = new int[n];            
            int[] newSums = new int[m/2];
            int j = 0;
            i=0;
            bool flag = false;
            for(;i<m;i++)
            {      
                int findKey = sums[i]+diff2;

                // if pair findkey and sums[i] exists
                if(dict2[sums[i]]>0 && dict2.ContainsKey(findKey) && dict2[findKey]>0)
                {
                    if(sums[i]==0) flag = true;

                    //assign the sums[i] to newSums array as diff will contribute to findkey but not sums[i].
                    newSums[j] = sums[i];

                    //reduce the count of pair values, so that same sum and findkey values are uniquely mapped to each other
                    dict2[findKey]--;
                    dict2[sums[i]]--;
                    j++;
                }
            }
            
            //create result only if zero exists in partition, having zero will make sure that the partition is valid
            if(flag)
            {
                
                result[0] = diff2;
                
                //recursively check for n-1 remaining source elements with new partition newSums
                int[] newResult = RecoverArray(n-1, newSums);

                for(i=0;i<n-1;i++)
                {
                    result[i+1] = newResult[i];
                }

            }
        }
        
        
        return result;
    }
}