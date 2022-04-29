/* Write your T-SQL query statement below */
select W.id
from weather W inner join Weather W1
ON W1.recorddate = DATEADD(day,-1,W.recorddate)
 and W.temperature > W1.temperature;