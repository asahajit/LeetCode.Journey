/* Write your T-SQL query statement below */

SELECT v.customer_id,COUNT(customer_id) AS count_no_trans
FROM
(
SELECT v.visit_id,COUNT(t.transaction_id) AS notruns
FROM Visits v LEFT JOIN Transactions t ON v.visit_id=t.visit_id
GROUP BY v.visit_id
Having COUNT(t.transaction_id)=0)T 
INNER JOIN Visits v on v.visit_id=t.visit_id
GROUP BY customer_id