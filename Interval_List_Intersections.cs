public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        int fLen = firstList.Count();
        int sLen = secondList.Count();
        int i=0;
        int j=0;
        List<int[]> result = new List<int[]>();
        while(i<fLen && j<sLen)
        {
            if(firstList[i][1]<secondList[j][0])
            {
                i++;
            }
            else if(secondList[j][1]<firstList[i][0])
            {
                j++;
            }
            else
            {
                int[] res = new int[2];
                res[0] = Math.Max(secondList[j][0],firstList[i][0]);
                res[1] = Math.Min(secondList[j][1],firstList[i][1]);
                if(secondList[j][1]>firstList[i][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
                result.Add(res);
            }
        }
        return result.ToArray();
    }
}