﻿/* Write your T-SQL query statement below */


(
    SELECT employee_id  FROM Employees
    EXCEPT 
    SELECT employee_id FROM Salaries
)
UNION
(
    SELECT employee_id  FROM Salaries
    EXCEPT 
    SELECT employee_id FROM Employees
)