public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Count();
        int[][] posAndSpeed = new int[n][];
        double[] timeToReach = new double[n];
        
        for(int i=0;i<n;i++)
        {
            posAndSpeed[i] = new int[2];
            posAndSpeed[i][0] = position[i];
            posAndSpeed[i][1] = speed[i];
        }
        
        Array.Sort(posAndSpeed,delegate(int[] a, int[] b){
            return a[0]-b[0];
        });
        
        for(int i=0;i<n;i++)
        {
            timeToReach[i] = (double)(target-posAndSpeed[i][0])/(double)posAndSpeed[i][1];
        }
        
        Stack<double> st = new Stack<double>();
        int k = 0;
        while(k<n)
        {
            double currFleetTime = timeToReach[k];
            while(st.Count()>0 && st.Peek()<=currFleetTime)
            {
                st.Pop();
            }
            
            st.Push(currFleetTime);
            
            k++;
            
        }
        
        return st.Count();
    }
}