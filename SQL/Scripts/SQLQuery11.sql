use pubs
select MAX(qty) from sales
--Nested querry
select * from sales where qty = (select Max(qty) from sales)
select * from sales where qty = (select Min(qty) from sales)

select MAX(ord_date) from sales
select * from sales where ord_date =(select MAX(ord_date) from sales)
select Count(*) from sales where ord_date =(select MAX(ord_date) from sales)

select * from sales where qty < (select Max(qty) from sales)
select * from sales where qty > (select Min(qty) from sales)

select * from stores
select * from sales where stor_id=(select stor_id from stores where stor_name='Bookbeat')
select * from sales where stor_id in (select stor_id from stores where stor_name in('Bookbeat','Barnum''s','News & Brews'))

select * from sales where qty > all(select qty from sales where stor_id=7131)
select * from sales where qty > (select Max(qty) from sales where stor_id=7131)

select * from sales order by qty  
select * from sales order by qty  desc
select * from sales where qty>30 order by qty 
select * from sales where qty<30 order by qty desc
select * from sales order by ord_date 

select * from authors
select au_id,state,city from authors order  by state,city

--groupby
--counting authors per each state
select state,Count(*) as 'Authors Count' from authors group by state

--to filter groupby use having
--counting authors from each state minimum 2 authors from each state
select state,COUNT(*) as 'Authors count' from authors group by state having COUNT(*)>1
--get sum of the qty of each stores
select stor_id,Sum(qty) as 'Total quantity'  from sales group by stor_id
--get sum of the qty of each stores with min sum is 50
select stor_id,Sum(qty) as 'Total quantity'  from sales group by stor_id having Sum(qty) > 50
select state,Count(*) as 'Authors Count' from authors group by state
select state,Count(*) as 'Authors Count' from authors where contract=1 group by state
select state,Count(*) as 'Authors Count' from authors where contract=1 group by state order by [Authors Count]

