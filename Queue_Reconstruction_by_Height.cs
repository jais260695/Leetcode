public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
        int n = people.Count();
        Array.Sort(people, delegate(int[] a, int[] b){
            if(a[0]!=b[0]) return b[0] - a[0];
            return a[1] - b[1];
        });
        
        
        List<int[]> list = new List<int[]>();
        
        for(int i=0;i<n;i++)
        {
            list.Insert(people[i][1],new int[2]{people[i][0], people[i][1]});
        }
        
        return list.ToArray();
    }
}