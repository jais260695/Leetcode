public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int searchIndex = 0;
        if(ruleKey=="color") searchIndex = 1;
        if(ruleKey=="name") searchIndex = 2;
        int result = 0;
        foreach(var item in items)
        {
            if(item[searchIndex]==ruleValue) result++;
        }
        return result;
    }
}