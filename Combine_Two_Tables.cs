/* Write your T-SQL query statement below */

select firstName,lastName,city,state
from Person P
left join Address A
on P.personID = A.personID;
