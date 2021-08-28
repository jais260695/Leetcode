public class Solution {
    public int MinInsertions(string s) {
        int n = s.Length;
        int openCount = 0;
        int closeCount=0;
        int result = 0;
        foreach(char ch in s)
        {
            if(ch=='(')
            {
                if(closeCount==1)
                {
                    if(openCount==0)
                    {
                        result+=2;
                    }
                    else
                    {
                        result++;
                        openCount--;
                    }
                    closeCount=0;
                }
                openCount++;
            }
            else
            {
                closeCount++;
                if(closeCount==2)
                {
                    if(openCount==0)
                    {
                        result++;
                    }
                    else
                    {
                        openCount--;
                    }
                    closeCount=0;
                }
            }
        }
        if(closeCount==1)
        {
            if(openCount==0)
            {
                result+=2;
            }
            else
            {
                result++;
                openCount--;
            }
            closeCount=0;
        }
        
        result+=2*openCount;
        return result;
    }
}