﻿/* Write your T-SQL query statement below */
SELECT name,population,area from world
where area>=3000000 or population>=25000000
order by 1;