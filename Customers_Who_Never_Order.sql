/* Write your T-SQL query statement below */
SELECT name as Customers
FROM Customers C
LEFT JOIN Orders O
ON C.id = O.customerId
WHERE O.id IS NULL;