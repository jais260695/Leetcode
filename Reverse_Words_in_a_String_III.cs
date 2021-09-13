public class Solution {
    public string ReverseWords(string s) {
        string[] str = s.Split(' ');
        string result ="";
        foreach(string temp in str)
        {
            char[] arr = temp.ToCharArray();
            Array.Reverse(arr);
            result += new string(arr);
            result += " ";
        }
        return result.Trim();
    }
}