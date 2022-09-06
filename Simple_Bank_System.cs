public class Bank {

    long[] balance;
    int numberOfAccounts;
    public Bank(long[] balance) {
        this.balance = balance;
        numberOfAccounts = balance.Count();
    }
    
    public bool Transfer(int account1, int account2, long money) {
        if(Withdraw(account1,money))
        {
            if(Deposit(account2,money))
            {
                return true;
            }
            else
            {
                Deposit(account1,money);
                return false;
            }
        }
        return false;
    }
    
    public bool Deposit(int account, long money) {
        if(account<=numberOfAccounts)
        {
            balance[account-1]+=money;
            return true;
        }
        
        return false;
    }
    
    public bool Withdraw(int account, long money) {
        if(account<=numberOfAccounts && balance[account-1]>=money)
        {
            balance[account-1]-=money;
            return true;
        }
        
        return false;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */