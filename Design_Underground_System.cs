public class UndergroundSystem {
    public class Pair
    {
        public string station;
        public int time;
        public Pair(string s , int t)
        {
            station = s;
            time = t;
        }
    }
    
    Dictionary<int,Pair> customerCheckin = new Dictionary<int,Pair>();
    Dictionary<string,Tuple<int,int>> stations = new Dictionary<string,Tuple<int,int>>();
    

    public UndergroundSystem() {
        
    }
    
    public void CheckIn(int id, string stationName, int t) {
        if(!customerCheckin.ContainsKey(id))
        {
            customerCheckin.Add(id,new Pair(stationName,t));
        }
        
    }
    
    public void CheckOut(int id, string stationName, int t) {
        if(customerCheckin.ContainsKey(id))
        {
            Pair p = customerCheckin[id];
            string key = p.station+"-"+stationName;
            if(!stations.ContainsKey(key))
                stations.Add(key,new Tuple<int,int>(0,0));
            stations[key] = new Tuple<int,int>(stations[key].Item1+(t-p.time),stations[key].Item2+1);
            customerCheckin.Remove(id);
            
        }
    }
    
    public double GetAverageTime(string startStation, string endStation) {
        string key = startStation+"-"+endStation;
        return (double)stations[key].Item1/stations[key].Item2;
    }
}

/**
 * Your UndergroundSystem object will be instantiated and called as such:
 * UndergroundSystem obj = new UndergroundSystem();
 * obj.CheckIn(id,stationName,t);
 * obj.CheckOut(id,stationName,t);
 * double param_3 = obj.GetAverageTime(startStation,endStation);
 */