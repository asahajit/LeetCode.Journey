/* Write your T-SQL query statement below */
SELECT sell_date,count(distinct product) as num_sold,
(
        SELECT STRING_AGG(U.product, ',')
        FROM 
        (
            SELECT DISTINCT T.product
            FROM Activities AS T
            WHERE 
                T.sell_date = A.sell_date
        ) AS U
    ) AS products
FROM Activities as A
GROUP BY  sell_date
