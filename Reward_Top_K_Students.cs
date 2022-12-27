public class Solution {
    public class PQComparer : IComparer<Tuple<int,int>>
    {
        public int Compare(Tuple<int,int> a,Tuple<int,int> b)
        {
            if(a.Item2!=b.Item2)
            {
                return b.Item2-a.Item2;
            }
            return a.Item1-b.Item1;
        }
    }
    public IList<int> TopStudents(string[] positive_feedback, string[] negative_feedback, string[] report, int[] student_id, int k) {
        HashSet<string> positive = new HashSet<string>();
        HashSet<string> negative = new HashSet<string>();
        
        foreach(string pos in positive_feedback)
        {
            positive.Add(pos);
        }
        
        foreach(string neg in negative_feedback)
        {
            negative.Add(neg);
        }
        int n = report.Count();
        PriorityQueue<int,Tuple<int,int>> pq = new PriorityQueue<int,Tuple<int,int>>(new PQComparer());
        for(int i=0;i<n;i++)
        {
            int score = 0;
            foreach(string word in report[i].Split(' '))
            {
                if(positive.Contains(word))
                {
                    score+=3;
                }
                if(negative.Contains(word))
                {
                    score-=1;
                }
            }
            
            pq.Enqueue(student_id[i],new Tuple<int,int>(student_id[i],score));
            
        }
        
        List<int> result = new List<int>();
        
        while(pq.Count>0 && k>0)
        {
            k--;
            result.Add(pq.Dequeue());
        }
        //result.Reverse();
        return result.ToList<int>();
    }
}