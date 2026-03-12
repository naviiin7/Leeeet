public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double kelvin = celsius + 273.15;
        double far = celsius * 1.80 + 32.00;
        return ([kelvin,far]);
    }
}