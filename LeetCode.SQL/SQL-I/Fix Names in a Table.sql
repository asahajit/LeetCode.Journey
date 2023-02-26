/* Write your T-SQL query statement below 


update Users
SET name = (UPPER(SUBSTRING(name,1,1))+LOWER(SUBSTRING(name,2,LEN(name)-1)))

*/

SELECT user_id,(UPPER(SUBSTRING(name,1,1))+LOWER(SUBSTRING(name,2,LEN(name)-1))) AS name from Users ORDER BY user_id;