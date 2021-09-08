public class BrowserHistory {
    Stack<string> browser = new Stack<string>();
    Stack<string> history = new Stack<string>();
    
    public BrowserHistory(string homepage) {
        browser.Push(homepage);
    }
    
    public void Visit(string url) {
        history.Clear();
        browser.Push(url);
    }
    
    public string Back(int steps) {
        while(steps>0 && browser.Count()>1)
        {
            history.Push(browser.Pop());
            steps--;
        }
        return browser.Peek();
    }
    
    public string Forward(int steps) {
        while(steps>0 && history.Count()>0)
        {
            browser.Push(history.Pop());
            steps--;
        }
        return browser.Peek(); 
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */