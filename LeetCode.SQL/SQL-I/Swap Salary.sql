﻿/* Write your T-SQL query statement below */

update Salary 
set sex=CASE 
            WHEN sex='f' THEN 'm'
            WHEN sex='m' THEN 'f'
            END;

