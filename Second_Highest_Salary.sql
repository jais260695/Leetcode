/* Write your T-SQL query statement below */
SELECT ISNULL((SELECT distinct Salary 
FROM Employee 
ORDER BY Salary DESC
OFFSET 1 ROW 
FETCH NEXT 1 ROW ONLY),null) AS SecondHighestSalary
