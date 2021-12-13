public class Solution {
    public int NumRabbits(int[] answers) {
        int n = answers.Count();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int result = 0;
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(answers[i]))
            {
                dict.Add(answers[i],answers[i]);
                result = result+ 1+ answers[i];
            }
            else if(dict[answers[i]]==0)
            {
                dict[answers[i]]  =   answers[i];
                result = result+ 1+ answers[i];
            }
            else
            {
                dict[answers[i]]  =   dict[answers[i]]  - 1; 
            }
        }
        return result;
    }
}