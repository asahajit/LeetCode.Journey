/* Write your T-SQL query statement below */
select c.name as Customers from Customers c 
LEFT JOIN Orders o on c.id=o.customerId
WHERE o.id IS NULL;