public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] arr = new string[26]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        
        HashSet<string> map = new HashSet<string>();
        foreach(string s in words)
        {
            string str = "";
            foreach(char ch in s)
            {
                str+=arr[ch-'a'];
            }
            map.Add(str);
        }
        return map.Count();
    }
}