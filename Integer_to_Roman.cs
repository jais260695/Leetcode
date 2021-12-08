public class Solution {
    public string IntToRoman(int num) {
        string[] thousands = new string[4]{"","M","MM","MMM"};
        string[] hundreds = new string[10]{"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
        string[] tens = new string[10]{"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};
        string[] ones = new string[10]{"","I","II","III","IV","V","VI","VII","VIII","IX"};
        
        string result  = "";
        
        result+=thousands[num/1000];
        num = num%1000;
        result+=hundreds[num/100];
        num = num%100;
        result+=tens[num/10];
        num = num%10;
        result+=ones[num];
        
        return result;
    }
}