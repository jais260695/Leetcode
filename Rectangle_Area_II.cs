
public class Solution {
    public int mod = 1000000007;
    public class CoordSpec {
        public int xDir;
        public int eventType;
        public int rectId;
        public CoordSpec(int x, int e, int r)
        {
            xDir = x;
            eventType = e;
            rectId = r;
        }
        
    } 

    public class HeightInterval
    {
        public int y2;
        public int y1;

        public HeightInterval(int top, int bottom)
        {
            y2 = top;
            y1 = bottom;
        }

    }

    public long CalcArea(List<int> activeRect,int width,int[][] rectangles)
    {
        if(width==0) return 0;
        List<HeightInterval> intervals = new List<HeightInterval>();

        //Store height intervals that is in [x1,y1,x2,y2] store [y2,y1]
        foreach(int id in activeRect)
        {
            intervals.Add(new HeightInterval(rectangles[id][3],rectangles[id][1]));
        }

        //sort intervals [y2,y1] by heighest y2 at the top
        intervals = intervals.OrderByDescending(i => i.y2).ToList<HeightInterval>();
        
        //Merge the intervals and get the total length 
        long length = 0;
        int i = 0;
        while(i<intervals.Count())
        {
            int top = intervals[i].y2;
            int bottom = intervals[i].y1;
            i++;
            while(i<intervals.Count() && intervals[i].y2 >= bottom)
            {
                bottom = Math.Min(bottom,intervals[i].y1);
                i++;
            }

            length= (length%mod + (top-bottom)%mod)%mod;
        }
        
        return ((long)width*length)%mod;
    }
    public int RectangleArea(int[][] rectangles) {
        int n = rectangles.Count();
        List<CoordSpec> xCoords = new List<CoordSpec>();
        
        //store x coordinate, (start or end as 0 or 1 respectively ) for a rectangle and rectnagle index in rectangle array
        for(int i=0;i<n;i++)
        {
            xCoords.Add( new CoordSpec(rectangles[i][0],0,i) );
            xCoords.Add( new CoordSpec(rectangles[i][2],1,i) );
        }

        //sort by x coordinate
        xCoords = xCoords.OrderBy(xc => xc.xDir).ToList<CoordSpec>();

        long area = 0;
        int prevXDir = 0;
        List<int> activeRect = new List<int>();
        for(int i=0;i<xCoords.Count();i++)
        {
            int cuurentXDir = xCoords[i].xDir;
            int eventType = xCoords[i].eventType;
            int rectId = xCoords[i].rectId;
            
            // calculate area before taking any action based on active rectangles till now and width as (cuurentXDir-prevXDir)
            area=(area+CalcArea(activeRect,cuurentXDir-prevXDir,rectangles))%mod;

            // if xCoord is of type start and add the rectangle index in active list
            // else remove from active list
            if(eventType==0)
            {
                activeRect.Add(rectId);
            }
            else{
                activeRect.RemoveAll((ar)=>ar==rectId);
            }
            prevXDir = cuurentXDir;
        }
        return (int)area;
    }
}