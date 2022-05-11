/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        
        Dictionary<int,Employee> map = new Dictionary<int,Employee>();

        foreach(var e in employees)
        {
            map.Add(e.id,e);
        }
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(id);
        
        int result = 0;
        
        while(queue.Count()>0)
        {
            int empID = queue.Dequeue();
            
            result+=map[empID].importance;
            
            foreach(var empSubID in map[empID].subordinates)
            {
                queue.Enqueue(empSubID);
            }
        }
        
        return result;
    }
}