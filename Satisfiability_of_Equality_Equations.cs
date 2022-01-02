public class Solution {
    
    public char Find(Dictionary<char,char> dict, char u)
    {
        while(dict[u]!=u)
        {
            u = dict[u];
        }
        return u;
    }
    
    public void Union(Dictionary<char,char> dict, char u, char v)
    {
        char uP = Find(dict,u);
        char vP = Find(dict,v);
        dict[uP] = vP;
    }
    
    public bool EquationsPossible(string[] equations) {
        List<string> equal = new List<string>();
        List<string> notEqual = new List<string>();
        Dictionary<char,char> dict = new Dictionary<char,char>();
        for(int i=0;i<equations.Count();i++)
        {
            
            char x = equations[i][0];
            char y = equations[i][3];
            
            if(!dict.ContainsKey(x))
            {
                dict.Add(x,x);
            }
            
            if(!dict.ContainsKey(y))
            {
                dict.Add(y,y);
            }
            
            if(equations[i].Substring(1,2)=="==")
            {
                equal.Add(equations[i]);
            }
            
            else
            {
                notEqual.Add(equations[i]);
            }
            
         }
        
        for(int i=0;i<equal.Count();i++)
        {
            char xP = Find(dict,equal[i][0]);
            char yP = Find(dict,equal[i][3]);
            
            if(xP!=yP)
            {
                Union(dict,xP,yP);
            }
        }
        
        for(int i=0;i<notEqual.Count();i++)
        {
            char xP = Find(dict,notEqual[i][0]);
            char yP = Find(dict,notEqual[i][3]);
            
            if(xP==yP)
            {
                return false;
            }
        }
        
        return true;
    }
}