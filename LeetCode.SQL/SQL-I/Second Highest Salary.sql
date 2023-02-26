/* Write your T-SQL query statement below */
SELECT ISNULL((
SELECT TOP 1 salary AS SecondHighest
FROM Employee WHERE salary<(SELECT MAX(salary) FROM Employee)
ORDER BY salary DESC),NULL) AS SecondHighestSalary
