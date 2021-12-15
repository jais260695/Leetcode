public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        // Trie can be used to improve complexity
        List<string> temp = new List<string>();
        int n = words.Count();
        for(int i=0;i<n;i++)
        {
            int flag = 0;
            int index = 0;
            int toRemove = -1;
            foreach(var s in temp)
            {
                if(s.Length>=words[i].Length && s.Substring(s.Length-words[i].Length)==words[i])
                {
                    flag=1;
                }
                if(s.Length<words[i].Length && words[i].Substring(words[i].Length-s.Length)==s)
                {
                    flag =2;
                    toRemove = index;
                }
                index++;
            }
            
            if(flag==0)
            {
                temp.Add(words[i]);
            }
            if(flag==2)
            {
                temp.RemoveAt(toRemove);
                temp.Add(words[i]);
            }
            
        }
        int length = 0;
        foreach(var st in temp)
        {
            length+=st.Length;
        }
        return length+temp.Count();
    }
}