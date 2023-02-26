/* Write your T-SQL query statement below */

SELECT patient_id,patient_name,conditions from Patients p
CROSS APPLY STRING_SPLIT(p.conditions, ',')  AS G
WHERE conditions LIKE 'DIAB1%' OR  conditions LIKE '% DIAB1%'