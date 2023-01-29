public class SummaryRanges {   
    SortedSet<int> sortedSet;
    public SummaryRanges() {
        sortedSet = new SortedSet<int>();
    }
    
    public void AddNum(int value) {
        sortedSet.Add(value);
    }
    
    public int[][] GetIntervals() {
        List<int[]> result = new List<int[]>();
        int i = 0;
        int first = -1;
        int second = -1;
        foreach(var val in sortedSet)
        {
            if(first==-1)
            {
                first = val;
                second = val;
            }
            else if(val==second+1)
            {
                second=val;
            }
            else
            {
                result.Add(new int[2]{first,second});
                first = val;
                second = val;
            }
        }
        result.Add(new int[2]{first,second});
        return result.ToArray();
    }
}

/**
 * Your SummaryRanges object will be instantiated and called as such:
 * SummaryRanges obj = new SummaryRanges();
 * obj.AddNum(value);
 * int[][] param_2 = obj.GetIntervals();
 */