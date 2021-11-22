public class Solution {
    public int FindComplement(int num) {       
       return ((1<<((int)(Math.Log(num)/Math.Log(2)) + 1))-1)^num;
    }
}