/* Write your T-SQL query statement below */
select DISTINCT T.id , IIF(T.p_id is null, 'Root', IIF(T1.id is null,'Leaf','Inner')) AS type
from tree T
Left join tree T1
ON T.id = T1.p_id;