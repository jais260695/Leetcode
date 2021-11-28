public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] arr = sentence.Split(' ');
        int n = arr.Count();
        for(int i=0;i<n;i++)
        {
            if(arr[i].StartsWith(searchWord))
                return i+1;
        }
        return -1;
    }
}