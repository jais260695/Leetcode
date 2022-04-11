public class Solution {
    public int MaxConsecutiveAnswers(string answerKey, int K) {
        int result = 0;
        int i=0;
        int j=0;
        int k = K;
        int n = answerKey.Length;
        
        while(i<=j && j<n)
        {
            if(answerKey[j]=='T')
            {
                j++;
            }
            else
            {
                if(k==0)
                {
                    result = Math.Max(result,j-i);
                    while(i<=j && answerKey[i]=='T')
                    {
                        i++;
                    }
                    
                    i++;
                    k++;
                }
                else
                {
                    k--;
                    j++;
                }
            }
        }
        result = Math.Max(result,j-i);
        i = 0;
        j = 0;
        k = K;
        while(i<=j && j<n)
        {
            if(answerKey[j]=='F')
            {
                j++;
            }
            else
            {
                if(k==0)
                {
                    result = Math.Max(result,j-i);
                    while(i<=j && answerKey[i]=='F')
                    {
                        i++;
                    }
                    
                    i++;
                    k++;
                }
                else
                {
                    k--;
                    j++;
                }
            }
        }       
        return Math.Max(result,j-i);
    }
}