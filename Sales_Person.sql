/* Write your T-SQL query statement below */
select S.name
from Company C
inner join Orders O
on C.com_id = O.com_id and C.name like '%RED%'
right join salesperson S
on S.sales_id = O.sales_id
where O.order_id is null;
