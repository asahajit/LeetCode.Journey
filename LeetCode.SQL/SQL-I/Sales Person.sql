/* Write your T-SQL query statement below */
SELECT name FROM SalesPerson where sales_id NOT IN (SELECT s.sales_id from SalesPerson s
LEFT JOIN Orders o on s.sales_id=o.sales_id
LEFT JOIN Company c on c.com_id=o.com_id
WHERE c.name='RED')