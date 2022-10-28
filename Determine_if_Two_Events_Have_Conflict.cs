public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        string[] start1 = event1[0].Split(':');
         string[] end1 = event1[1].Split(':');
        
         string[] start2 = event2[0].Split(':');
         string[] end2 = event2[1].Split(':');
        
        if(Convert.ToInt32(start1[0]+start1[1]) >= Convert.ToInt32(start2[0]+start2[1])  &&  Convert.ToInt32(start1[0]+start1[1]) <= Convert.ToInt32(end2[0]+end2[1]) ) 
            return true;
         if(Convert.ToInt32(start2[0]+start2[1]) >= Convert.ToInt32(start1[0]+start1[1])  &&  Convert.ToInt32(start2[0]+start2[1]) <= Convert.ToInt32(end1[0]+end1[1]) ) 
            return true;
        return false;
    }
}