/* Write your T-SQL query statement below */
SELECT stock_name,(SellAmount+BuyAmount) AS capital_gain_loss
FROM
(SELECT stock_name,
SUM(CASE When operation ='Buy' Then 0-price Else 0 End ) as BuyAmount,
SUM(CASE When operation='Sell' Then price Else 0 End ) as SellAmount
FROM Stocks
GROUP BY stock_name)x