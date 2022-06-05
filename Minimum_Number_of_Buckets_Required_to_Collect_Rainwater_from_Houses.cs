public class Solution {
    public int MinimumBuckets(string street) {
        if(street.Equals("H") || street.StartsWith("HH") || street.EndsWith("HH") || street.Contains("HHH")) return -1;
        return street.Split('H').Count() - street.Split("H.H").Count();
    }
}