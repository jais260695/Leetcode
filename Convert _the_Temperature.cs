public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double[] result = new double[2];
        result[0] = celsius + 273.15;
        result[1] = (double)(9*celsius)/(double)(5) + 32;
        return result;
    }
}