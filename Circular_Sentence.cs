public class Solution {
    public bool IsCircularSentence(string sentence) {
        string[] strArr = sentence.Split(' ');
        
        int n = strArr.Count();
        
        for(int i=1;i<n;i++)
        {
            if(strArr[i][0]!=strArr[i-1][strArr[i-1].Length-1])
            {
                return false;
            }
        }
        
        return strArr[0][0]==strArr[n-1][strArr[n-1].Length-1];
    }
}