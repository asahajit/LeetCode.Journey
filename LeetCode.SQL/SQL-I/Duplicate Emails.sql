/* Write your T-SQL query statement below */
select email FROM Person
GROUP BY  email
having COUNT(email)>1