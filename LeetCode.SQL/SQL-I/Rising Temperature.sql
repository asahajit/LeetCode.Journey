/* Write your T-SQL query statement below */
select w1.id from Weather w1,Weather w2 
WHERE  w1.recordDate = DATEADD(day, 1, w2.recordDate) and w1.temperature>w2.temperature
