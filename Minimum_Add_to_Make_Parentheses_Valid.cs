public class Solution {
    public int MinAddToMakeValid(string s) {
        Stack<char> charStack = new Stack<char>();
        int result = 0;
        foreach(char ch in s)
        {
            if(ch=='(')
            {
                charStack.Push(ch);
            }
            else
            {
                if(charStack.Count()==0 || charStack.Peek()!='(')
                {
                    result++;
                }
                else
                {
                    charStack.Pop();
                }
            }
        }
        result+=charStack.Count();
        return result;
    }
}