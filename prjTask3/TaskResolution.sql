--We do have 2 tables in a relational database: 
--∙ Clients (client_id(PK), client_name) 
--∙ Orders (order_id(PK), client_id, order_sum, order_date) 
--Please write the following SQL queries: 

--  a- list of clients, which have an order with order_sum > 50 

select cli.client_name
from Clients cli
inner join Orders ord on ord.client_id = cli.client_id
where ord.order_sum > 50


--  b- clients, whose total sum of orders exceeds 100 

select cli.client_name as account_name
from Orders tblOrders
inner join Clients cli on tblOrders.client_id = cli.client_id
group by cli.client_name
having sum(order_sum) >= 100
order by cli.client_name
