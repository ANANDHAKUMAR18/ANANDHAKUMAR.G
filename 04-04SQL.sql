--Query3
create table tbl_student
(
Sno int,
StuName varchar(20),
StuAge int
)

alter table tbl_student
add Gender char(1)

select * from tbl_student

alter table tbl_student
add MobileNO varchar(20)

insert into tbl_student values(1,'anand',22,'M','8430073475')
select * from tbl_student


go
create view task1
as
select Sno,StuName,StuAge
from tbl_student
go
select * from task1
insert into tbl_student1 values(2,'yaz',18,'F','9607732615')

--Query7

select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name


--Query6
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--Query5
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

--Query2
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Dollar 
from HumanResources.EmployeePayHistory

--Query4
select * from dbo.tbl_just
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'anand','M'
create proc taskup_sp
@sno int,
@age int,
@name varchar(50)
as
update tbl_just set sno=@sno,age=@age where name = @name

task1_sp 1,19,'anand'
create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1

--Query1
select  COUNT([StandardCost]) Totnorow
from [Production].[ProductCostHistory]
--USING SUM()
select SUM([StandardCost]) SC
from [Production].[ProductCostHistory]
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2002/12/18') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,102.77);
--USING LEFT()
SELECT LEFT('Yazhini', 3) AS ExtractString;
--USING LEN()
select LEN('ANAND')
--using Reverse()
select REVERSE('Arjun')