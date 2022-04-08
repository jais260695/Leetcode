public class Cashier {
    int n;
    int discount;
    Dictionary<int,int> productPriceMap = new Dictionary<int,int>();
    int billerCount = 0;
    public Cashier(int n, int discount, int[] products, int[] prices) {
        this.n = n;
        this.discount = discount;
        
        for(int i=0;i<products.Count();i++)
        {
            productPriceMap.Add(products[i],prices[i]);
        }
        
    }
    
    public double GetBill(int[] product, int[] amount) {
        billerCount++;
        double total = 0;
        
        for(int i=0;i<product.Count();i++)
        {
            total+= (amount[i]*productPriceMap[product[i]]);
        }
        
        if(billerCount==n)
        {
            billerCount=0;
            total -= ((total*discount)/100);
        }
        
        return total;
    }
}

/**
 * Your Cashier object will be instantiated and called as such:
 * Cashier obj = new Cashier(n, discount, products, prices);
 * double param_1 = obj.GetBill(product,amount);
 */