public class Solution {
    public int[] FindArray(int[] pref) {
        int n = pref.Count();
        int prev = pref[0];
        
        for(int i=1;i<n;i++)
        {
            pref[i] = prev^pref[i];
            prev = prev^pref[i];
            
        }
        
        return pref;
    }
}