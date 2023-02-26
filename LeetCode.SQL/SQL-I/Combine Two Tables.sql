/* Write your T-SQL query statement below */

select distinct firstName,lastName,city,state from Person p
LEFT JOIN Address a on p.personId=a.personId;