public class MyCalendar {

    public List<Tuple<int,int>> sortedIntervals;
    public int size;
    
    public MyCalendar() {
        sortedIntervals = new List<Tuple<int,int>>();
        size = 0;
    }
    
    public bool Book(int start, int end) {
        
        for(int i=0;i< size;i++)
        {
            if(start<sortedIntervals[i].Item2 && end > sortedIntervals[i].Item1) 
            {
                return false;
            }
            else
            {
                if(end <= sortedIntervals[i].Item1)
                {
                    sortedIntervals.Insert(i,new Tuple<int,int>(start,end));
                    size++;
                    return true;
                }
            }
        }
        
        
        sortedIntervals.Add(new Tuple<int,int>(start,end));
        size++;
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */