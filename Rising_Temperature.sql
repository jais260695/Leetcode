/* Write your T-SQL query statement below */
select W.id
from weather W join Weather W1
ON W.recorddate = DATEADD(day,1,W1.recorddate)
 and W.temperature > W1.temperature;