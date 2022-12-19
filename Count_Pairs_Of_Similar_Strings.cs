public class Solution {
    public int SimilarPairs(string[] words) {
        int n = words.Count();
        int[] bitVal = new int[n];
        int result = 0;
        for(int i=0;i<n;i++)
        {
            int temp = 0;
            foreach(char ch in words[i])
            {
                temp|= (1<<(ch-'a'));
            }
            bitVal[i] = temp;
        }
        
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(bitVal[i]==bitVal[j]) result++;
            }
        }
        
        return result;
    }
}