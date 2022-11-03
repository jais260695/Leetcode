public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int n1 = nums1.Count();
        
        int xor1 = 0;
        
        for(int i=0;i<n1;i++)
        {
            xor1^=nums1[i];
        }
        
        
        int n2 = nums2.Count();
        
        int xor2 = 0;
        
        for(int i=0;i<n2;i++)
        {
            xor2^=nums2[i];
        }
        
        return (n2%2==0 ? 0 : xor1)^(n1%2==0 ? 0 : xor2);
    }
}