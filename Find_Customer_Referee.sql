/* Write your T-SQL query statement below */
SELECT name
FROM Customer
WHERE referee_id IS NULL or  referee_id != 2;