use AdventureWorks2014

--Query1
select FirstName,LastName
from Person.Person
where Title is not null

--Query2
select FirstName,LastName
from Person.Person
where FirstName like '%a' or LastName like '%a'

--Query3
select cur.CurrencyCode,Name
from Sales.Currency cur
join Sales.CountryRegionCurrency coun
on cur.CurrencyCode=coun.CurrencyCode

--Query4

select * into HR_dept
from HumanResources.Department
select * from HR_dept



--Query5
create table Tbl_1
(
Sno int identity(1,1),
FName varchar(20),
LName varchar(20),
Gender varchar(10),
MobileNo varchar(20)
)

insert into Tbl_1
values('Anandha','Kumar','M','9962714878')
insert into Tbl_1
values('Adesh','K','M','9962714578')
insert into Tbl_1
values('Harish','A','M','9962714878')
insert into Tbl_1
values('Thangam','K','F','9962714878')
insert into Tbl_1
values('Mugesh','Raj','M','9962714878')
insert into Tbl_1
values('Isaac','samuel','M','9962714878')
insert into Tbl_1
values('arjun','sathish','M','9962714878')
insert into Tbl_1
values('john','ricky','M','9962714878')
insert into Tbl_1
values('venkat','sidd','M','9962714878')
insert into Tbl_1
values('giri','dharan','M','9962714878')
insert into Tbl_1
values('Ajay','Kanna','M','9962714878')
insert into Tbl_1
values('Harish','war','M','9962714878')
insert into Tbl_1
values('Abdul','A','M','9962714878')
insert into Tbl_1
values('Dinesh','Kumar','M','9962714878')
insert into Tbl_1
values('Dinesh','J','M','9962714878')
insert into Tbl_1
values('deepak','K','M','9962714878')
insert into Tbl_1
values('Balaji','R','M','9962714878')
insert into Tbl_1
values('koushik','K','M','9962714878')
insert into Tbl_1
values('santhosh','Kumar','M','9962714878')
insert into Tbl_1
values('Surya','P','M','9962714878')

select * from Tbl_1

--Query6

select BusinessEntityID,AddressTypeID
from Person.BusinessEntityAddress

--Query7

select distinct GroupName
from HumanResources.Department

--Query8

select PCH.standardcost, sum(listprice) Lstprice,sum(PCH.standardcost) Stdcost
from Production.Product PCH
join Production.ProductCostHistory prod
on PCH.ProductID=prod.ProductID
group by PCH.StandardCost





--Query9

select DATEDIFF(YY,startdate,EndDate) as Yearsonrole
from HumanResources.EmployeeDepartmentHistory


--Query10

select sum(salesquota) SalesQuota
from sales.SalesPersonQuotaHistory 
where SalesQuota>5000 and SalesQuota<100000
group by SalesQuota


--Query11

select max(TaxRate) as Max_taxrate
from Sales.SalesTaxRate

--Query12

select dept.DepartmentID,emp.BusinessEntityID,ShiftID,BirthDate
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory depth
on emp.BusinessEntityID=depth.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=depth.DepartmentID
select birthdate,getdate() as currentdate,datediff(YY,birthdate,getdate()) as age
from HumanResources.Employee

--Query13

create view Nameage
as
select birthdate,getdate() as currentdate,datediff(YY,birthdate,getdate()) as age
from HumanResources.Employee
go
select * from Nameage

--Query14

select count(*) as noofrows
from HumanResources.Employee,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory,HumanResources.JobCandidate

--Query15
 
 select max(rate) as Maxsalary,Name
 from HumanResources.EmployeePayHistory pay
 join HumanResources.EmployeeDepartmentHistory dhis
 on pay.BusinessEntityID=dhis.BusinessEntityID
 join HumanResources.Department dept
 on dept.DepartmentID=dhis.DepartmentID
 group by Name


--Query16

select FirstName,MiddleName,Title,AddressTypeID,Busen.BusinessEntityID
from Person.Person per
left join person.BusinessEntityAddress BusEn
on per.BusinessEntityID=Busen.BusinessEntityID
where Title is not null

--Query17

select ProductID,LocationID,Shelf
from Production.ProductInventory
where ProductID>300 and ProductID<350 and Shelf='E'

--Query18

select prod.LocationID,Shelf,Name
from production.ProductInventory prod
join Production.Location loc
on prod.LocationID=loc.LocationID

--Query19

select AddressID,AddressLine1,AddressLine2,sta.StateProvinceID,StateProvinceCode,CountryRegionCode
from person.StateProvince sta
join Person.Address ad
on sta.StateProvinceID=ad.StateProvinceID


--Query20

select sum(SubTotal),sum(TaxAmt)
from sales.CountryRegionCurrency orr
join sales.SalesTerritory ter
on orr.CountryRegionCode=ter.CountryRegionCode
join sales.SalesOrderHeader coun
on ter.TerritoryID=coun.TerritoryID
group by ter.TerritoryID







