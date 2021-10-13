public class Solution {
    public class Point{
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public static Point p0;
    public static int Dist(Point p1, Point p2)
    {
        return (p1.x-p2.x)*(p1.x-p2.x) + (p1.y-p2.y)*(p1.y-p2.y);               
    }
    public static int Orientation(Point P0, Point P1, Point P2)
    {
        int x1 = P1.x-P0.x;
        int y1 = P1.y-P0.y;
        int x2 = P2.x-P1.x;
        int y2 = P2.y-P1.y;
        int val = y1*x2 - y2*x1;
        if(val==0) return 0;
        if(val>0) return 1;
        return 2;
    }
    public class MyComparer: IComparer<Point>
    {
        public int Compare(Point p1, Point p2)
        {
            int o = Orientation(Solution.p0,p1,p2);
            if(o==0) return Dist(p0,p1)<Dist(p0,p2) ? -1 : 1;
            return o==2 ? -1 : 1;
        }
    }
    public Point NextToTop(Stack<Point> st)
    {
        Point p = st.Pop();
        Point res = st.Peek();
        st.Push(p);
        return res;
    }
    public int[][] OuterTrees(int[][] trees) {
        int n = trees.Count();
        if(n<=3) return trees;
        Point[] points = new Point[n];
        for(int i=0;i<n;i++)
        {
            points[i] = new Point(trees[i][0],trees[i][1]);
        }        
        int yMin = points[0].y;
        int min = 0;
        for(int i=1;i<n;i++)
        {
            if(points[i].y<yMin || (points[i].y==yMin && points[i].x<points[min].x))
            {
                yMin = points[i].y;
                min = i;
            }
        }
        Point t = points[0];
        points[0] = points[min];
        points[min] = t;
        p0 = points[0];
        Array.Sort(points,1,n-1,new MyComparer());
        int m = n;
        /*for(int i=1;i<n;i++)
        {
            while(i<n-1 && Orientation(p0,points[i],points[i+1])==0)
            {
                i++;
            }
            points[m] = points[i];
            m++;
        }*/
        /*for(int i=0;i<m;i++)
        {
            Console.WriteLine(points[i].x+" "+points[i].y);
        }*/
        Stack<Point> st = new Stack<Point>();
        st.Push(points[0]);
        st.Push(points[1]);
        st.Push(points[2]);
        for(int i=3;i<m;i++)
        {
            while(st.Count()>1 && Orientation(NextToTop(st),st.Peek(),points[i])==1)
            {
                st.Pop();
            }
            st.Push(points[i]);
        }   
        int j = m-1;
        while(st.Count()!=m && j>0 && Orientation(p0,points[j],points[j-1])==0)
        {
            st.Push(points[j-1]);
            j--;
        }
        int[][] result = new int[st.Count()][];      
        int it = 0;
        while(st.Count()>0)
        {
            Point p = st.Pop();
            result[it] = new int[2];
            result[it][0] = p.x;
            result[it][1] = p.y;
            it++;
        }
        return result;
    }
}