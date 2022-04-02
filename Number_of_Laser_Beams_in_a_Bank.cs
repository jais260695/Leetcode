public class Solution {
    public int NumberOfBeams(string[] bank) {
        int prev = 0;
        int result = 0;
        
        int n = bank.Count();
        for(int i=0;i<n;i++)
        {
            int count = 0;
            foreach(char ch in bank[i])
            {
                if(ch=='1') count++;
            }
            
            if(count==0) continue;
            
            result+=(prev*count);
            prev = count;
        }
        return result;
    }
}