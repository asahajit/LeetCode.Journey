/* Write your T-SQL query statement below */
SELECT activity_date as day,COUNT(DISTINCT USER_id) AS active_users from Activity
WHERE DATEDIFF(day,activity_date,'2019-07-27') <=29  
AND activity_date < '2019-07-27' 
GROUP BY activity_date

