/* Write your T-SQL query statement below */
SELECT DISTINCT t1.id,
CASE 
    WHEN t1.p_id IS NULL THEN 'Root'
    WHEN t1.id=t2.p_id  THEN 'Inner'
    WHEN t2.id IS NULL THEN 'Leaf'
END
    AS type
from Tree t1
LEFT JOIN Tree t2 on t1.id=t2.p_id