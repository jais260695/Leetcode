public class Solution {
    public class StringComparer: IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            string t1 = s1+s2;
            string t2 = s2+s1;
            return t2.CompareTo(t1);
        }
    }
    public string LargestNumber(int[] nums) {
        int n = nums.Count();
        string[] strNums = new string[n];
        for(int i=0;i<n;i++)
        {
            strNums[i] = nums[i].ToString();
        }
        Array.Sort(strNums,new StringComparer());
        string result = "";
        if(Convert.ToInt32(strNums[0])==0) return "0";
        for(int i=0;i<n;i++)
        {
            result+=strNums[i];
        }        
        return result;    
    }
}