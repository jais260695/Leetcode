public class Solution {
    public long DividePlayers(int[] skill) {
        int n = skill.Count();
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int sum = 0;
        
        for(int i=0;i<n;i++)
        {
            sum+=skill[i];
            if(!dict.ContainsKey(skill[i]))
            {
                dict.Add(skill[i],0);
            }
            dict[skill[i]]++;
        }
        
        int totalGroups = n/2;
        
        if((sum%totalGroups)!=0) return -1;
        
        int groupSum = sum/totalGroups;
        long result = 0;
    
        
        foreach(KeyValuePair<int,int> kvp in dict)
        {
            
            while(dict[kvp.Key] > 0)
            { 
                int val = kvp.Key;
                int search = groupSum - val;
                if(!dict.ContainsKey(search) || dict[search]==0)
                {
                    return -1;
                }
                else
                {
                    totalGroups--;
                    dict[val]--;
                    dict[search]--;
                    result+= ((long)val*(long)search);
                }
            }
        }
        
        return totalGroups==0 ? result : -1;
        
    }
}