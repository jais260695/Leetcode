public class Solution {
    public int HammingDistance(int x, int y) {
        int result = 0;
        int temp = x^y;
        while(temp>0)
        {
            result+= (temp&1);
            temp>>=1;
        }
        return result;
    }
}