/* Write your T-SQL query statement below */
SELECT name FROM Customer
where ISNULL(referee_id,0)<>2;