--Select
select ContactName,CompanyName,City from Customers

Select * from Customers where City = 'London'

select * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>10

select * from Products where CategoryID=1 order by UnitPrice asc --ascending (artan)   --descending (azalan)

select count(*) Adet from Products where CategoryID=2

select categoryId, count(*) from products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products  left join [Order Details] on Products.ProductID = [Order Details].ProductID inner join Orders o on o.OrderID= [Order Details].OrderID 

select * from Customers c left join Orders o on c.CustomerID= o.CustomerID where o.CustomerID is null