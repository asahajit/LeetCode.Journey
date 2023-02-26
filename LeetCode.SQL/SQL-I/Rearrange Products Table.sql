/* Write your T-SQL query statement below */

SELECT * from 
(SELECT product_id,'store1' AS store,store1 as price from Products s1
UNION ALL
SELECT product_id,'store2' AS store,store2 as price from Products s2
UNION ALL
SELECT product_id,'store3' AS store,store3 as price from Products s3)X
WHERE X.price IS NOT NULL

