public class Solution {
    bool[] visited;
    public int FindScore(int[,] compatibility, int n, int stdIndex)
    {
        if(stdIndex==n) return 0;
        int max = 0;
        for(int mentorIndex=0;mentorIndex<n;mentorIndex++)
        {
            if(!visited[mentorIndex])
            {
                visited[mentorIndex]=true;
                max = Math.Max(compatibility[stdIndex,mentorIndex]+FindScore(compatibility,n,stdIndex+1),max);
                visited[mentorIndex]=false;
            }
        }
        return max;
    }
    public int MaxCompatibilitySum(int[][] students, int[][] mentors) {
        int n =  students.Count();
        int m = students[0].Count();
        int[,] compatibility = new int[n,n];
        visited = new bool[n];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                for(int k=0;k<m;k++)
                {
                    if(students[i][k]==mentors[j][k])
                    {
                        compatibility[i,j]++;
                    }
                }
            }
        }
        return FindScore(compatibility,n,0);        
    }
}