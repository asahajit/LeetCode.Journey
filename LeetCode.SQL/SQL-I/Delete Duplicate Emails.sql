/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 
 DELETE FROM Person WHERE id in (SELECT id,email FROM Person
 GROUP BY email
 HAVING COUNT(email)>1
 );
 */
DELETE p 
FROM Person p
INNER JOIN Person q ON q.email=p.email 
WHERE p.Id>q.Id 