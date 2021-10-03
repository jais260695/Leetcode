public class Solution {  
    public bool IsHappy(int n) {
        HashSet<int> map = new HashSet<int>();
        while(n!=1)
        {
            int newN = 0;
            while(n>0)
            {
                int t = n%10;
                newN += (t*t);
                n = n/10;
            }
            if(map.Contains(newN)) return false;
            map.Add(newN);
            n = newN;
        }
        return true;
    }
}