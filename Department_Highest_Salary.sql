/* Write your T-SQL query statement below */
SELECT D.Name as Department, E.name as Employee, E.Salary as Salary
FROM Employee E
INNER JOIN Department D
ON E.DepartmentId = D.Id
WHERE E.Salary = (Select Max(Salary) from Employee  where DepartmentId = E.DepartmentId)