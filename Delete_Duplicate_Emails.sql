/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
 
 DELETE FROM Person
 WHERE id not in (Select MIN(p2.id) from Person p2 group by p2.email);
