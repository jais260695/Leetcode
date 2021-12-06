public class Solution {
    
    public int CalculateFrequency(string str)
    {
        Dictionary<char, int> dict = new Dictionary<char,int>();
        char min = 'z';
        foreach(char ch in str)
        {
            if(!dict.ContainsKey(ch))
            {
                if(ch<min) min = ch;
                dict.Add(ch,0);
            }
            dict[ch]++;
        }
        return dict[min];
    }
    
    public int BinarySearch(int[] arr, int val)
    {
        int n = arr.Count();
        int l = 0;
        int h = n-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(arr[mid]<=val)
            {
                l = mid+1;
            }
            else
            {
                h = mid - 1;
            }
        }
        return n-l;
    }
    
    public int[] NumSmallerByFrequency(string[] queries, string[] words) {
        int wCount = words.Count();
        int qCount = queries.Count();
        int[] wordFrequency = new int[wCount];
        int[] result = new int[qCount];
        for(int i=0;i<wCount;i++)
        {
            wordFrequency[i] = CalculateFrequency(words[i]);
        }
        
        Array.Sort(wordFrequency);
        
        for(int i=0;i<qCount;i++)
        {
            int val = CalculateFrequency(queries[i]);
            result[i] = BinarySearch(wordFrequency,val);
        }
        
        return result;
        
    }
}