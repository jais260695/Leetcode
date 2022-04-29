/* Write your T-SQL query statement below */
select customer_id, Count(V.visit_id) as count_no_trans
from Visits V
left join Transactions T
ON V.visit_id = T.visit_id
where T.transaction_id is null
group by customer_id;