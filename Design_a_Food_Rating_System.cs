public class FoodRatings {
    
    public static string[] cuisines;
    public static int[] ratings;
    public static string[] foods;
    
    public class FoodComparer: IComparer<int>
    {
        public int Compare(int f1, int f2)
        {
            if(ratings[f1] != ratings[f2])
            {
                return ratings[f2] - ratings[f1];
            }
            
            return foods[f1].CompareTo(foods[f2]);
        }
    }
    

    Dictionary<string,int> foodToRating = new Dictionary<string,int>();    
    Dictionary<string, SortedDictionary<int, int>> cusineToFood = new Dictionary<string, SortedDictionary<int ,int>>();
    
    public FoodRatings(string[] foods, string[] cuisines, int[] ratings) {
        FoodRatings.cuisines = cuisines;
        FoodRatings.ratings = ratings;
        FoodRatings.foods = foods;
        
        int n = foods.Count();
        for(int i=0;i<n;i++)
        {
            foodToRating.Add(foods[i],i);
            if(!cusineToFood.ContainsKey(cuisines[i]))
            {
                cusineToFood.Add(cuisines[i],new SortedDictionary<int,int>(new FoodComparer()));
            }
            cusineToFood[cuisines[i]].Add(i, i);
        }
        
    }
    
    public void ChangeRating(string food, int newRating) {
        int index = foodToRating[food];
        string cuisine = cuisines[index];
        int rating = ratings[index];
        cusineToFood[cuisine].Remove(index);
        ratings[index] = newRating;
        cusineToFood[cuisine].Add(index,index);
        
    }
    
    public string HighestRated(string cuisine) {
        return foods[cusineToFood[cuisine].Keys.First()];
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */