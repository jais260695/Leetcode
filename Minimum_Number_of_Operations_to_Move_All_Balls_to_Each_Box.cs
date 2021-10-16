public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int[] result = new int[n];
        for(int i=0;i<n;i++)
        {
                for(int j=0;j<n;j++)
                {
                        if(boxes[j]=='1')
                        {
                            result[i]+=Math.Abs(i-j);
                        }
                }
        }
        return result;
    }
}