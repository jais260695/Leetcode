/* Write your T-SQL query statement below */
select user_id, UPPER(LEFT(name,1))+LOWER(RIGHT(name,LEN(name)-1)) as name
from users
order by user_id;