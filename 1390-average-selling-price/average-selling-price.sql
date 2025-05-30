# Write your MySQL query statement below
select p.product_id,Round(IFNULL(Sum(p.price*u.units)/sum(u.units),0),2) as average_price
from Prices p left join UnitsSold u 
on p.product_id = u.product_id 
where u.purchase_date <= p.end_date and u.purchase_date>=p.start_date or u.purchase_date is null group by p.product_id