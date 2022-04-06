public class Solution {
    public class FlowerSeed
    {
        public int P;
        public int G;
        public FlowerSeed(int p, int g)
        {
            P = p;
            G = g;
        }
    }
    public int EarliestFullBloom(int[] plantTime, int[] growTime) {
        int n = plantTime.Count();
        List<FlowerSeed> seeds = new List<FlowerSeed>();
        
        for(int i=0;i<n;i++)
        {
            seeds.Add(new FlowerSeed(plantTime[i],growTime[i]));
        }
        
        var s = seeds.OrderByDescending(s=> s.G).ToList<FlowerSeed>();
        
        int result = 0;
        int last = 0;
        for(int i=0;i<n;i++)
        {
            result+=s[i].P;
            last = Math.Max(last,result+s[i].G+1);
        } 
        
        return last-1;
    }
}