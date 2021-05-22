public class Solution {
    public int[] tree;
    public int[] lazy;
    public void UpdateSegmentTreeLazyMode(int nodeIndex, int left, int right, int i, int j, int val)
    {
        if(left>right) return;
        
        int leftChild = 2*nodeIndex+1;
        int rightChild = 2*nodeIndex+2;
        
        if(lazy[nodeIndex]>0)
        {
            tree[nodeIndex]=lazy[nodeIndex];
            if(left!=right)
            {
                lazy[leftChild]=lazy[nodeIndex];
                lazy[rightChild]=lazy[nodeIndex];
            }
            lazy[nodeIndex] = 0;
        }
        
        if(left>j || right<i) return;//No overlapping of intervals
        
        if(left>=i && right<=j)//complete overlapping of intervals
        {
            tree[nodeIndex]=val;
            if(left!=right)
            {
                lazy[leftChild]=val;
                lazy[rightChild]=val;
            }
            lazy[nodeIndex] = 0;
            return;
        }
        
        int mid = left + (right-left)/2;//partial overlapping of intervals
        UpdateSegmentTreeLazyMode(leftChild,left,mid,i,j,val);
        UpdateSegmentTreeLazyMode(rightChild,mid+1,right,i,j,val);
        tree[nodeIndex] = Math.Max(tree[leftChild],tree[rightChild]);
    }
    
    public int FetchMaxInRange(int nodeIndex, int left, int right, int i, int j)
    {
        if(left>right) return 0;
        
        int leftChild = 2*nodeIndex+1;
        int rightChild = 2*nodeIndex+2;
        
        if(lazy[nodeIndex]>0)
        {
            tree[nodeIndex]=lazy[nodeIndex];
            if(left!=right)
            {
                lazy[leftChild]=lazy[nodeIndex];
                lazy[rightChild]=lazy[nodeIndex];
            }
            lazy[nodeIndex] = 0;
        }
        
        if(left>j || right<i) return 0;//No overlapping of intervals
        
        if(left>=i && right<=j)//complete overlapping of intervals
        {
            return tree[nodeIndex];
        }
        
        int mid = left + (right-left)/2;//partial overlapping of intervals
        int l = FetchMaxInRange(leftChild,left,mid,i,j);
        int r = FetchMaxInRange(rightChild,mid+1,right,i,j);
        return Math.Max(l, r);
    }
    
    
    
    public IList<int> FallingSquares(int[][] positions) {
        int n = positions.Count();

        //Coordinate compression starts
        List<int> coords = new List<int>();
        for(int i=0;i<n;i++)
        {
            coords.Add(positions[i][0]);
            coords.Add(positions[i][0] + positions[i][1]-1);
        }
        
        coords.Sort();
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i=0;i<coords.Count();i++)
        {
            if(!map.ContainsKey(coords[i]))
            {
                map.Add(coords[i],i);
            }
            else
            {
                map[coords[i]] = i;
            }
        }

        //Coordinate compression ends
        
        int m = coords.Count();
        int size = 4*m;
        tree = new int[size];
        lazy = new int[size];
        List<int> result = new List<int>();
        int gMax = 0;
        for(int i=0;i<n;i++)
        {
            int left = map[positions[i][0]];
            int right = map[positions[i][0] + positions[i][1]-1];
            int max = FetchMaxInRange(0,0,m-1,left,right);
            UpdateSegmentTreeLazyMode(0,0,m-1,left,right,max + positions[i][1]);
            if(gMax<max+positions[i][1])
                gMax = max+positions[i][1];
            result.Add(gMax);
        }    
        return result.ToList<int>();
    }
}