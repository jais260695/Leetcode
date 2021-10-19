public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        int n = deck.Count();
        Array.Sort(deck);
        if(n<=2) return deck;
        
        List<int> result = new List<int>();
        result.Add(deck[n-2]);
        result.Add(deck[n-1]);
        int listLength = 2;
        
        for(int i=n-3;i>=0;i--)
        {
            int val = result[listLength-1];
            result.RemoveAt(listLength-1);
            result.Insert(0,val);
            result.Insert(0,deck[i]);
            listLength++;
        }
        
        return result.ToArray();
    }
}