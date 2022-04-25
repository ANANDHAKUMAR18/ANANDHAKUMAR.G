use Sql15
go



create table product_table
(
ProdId int identity(100,1),
ProdName varchar(20),
Price int,
ManDate  date default getdate(),
Expirydate date default getdate()
)

select * from product_table


insert product_table
values('Munch',20,GETDATE(),DATEADD(m,1,getdate()))

insert product_table
values('Dairymilk',50,GETDATE(),DATEADD(m,3,getdate()))

insert product_table
values('Soap',100,GETDATE(),DATEADD(YYYY,4,getdate()))

insert product_table
values('Biscuit',120,GETDATE(),DATEADD(m,1,getdate()))


create table Customer_Table1
(
CustId int identity(2000,1),
Name varchar(20),
Gender char(2),
DoB varchar(20),
ContactNo varchar(20),
EmailId varchar(20),
City varchar(20)
)

select * from Customer_Table1

insert Customer_Table1
values('Anand','M','18-08-2000','9962714918','some@gmail.com','Chennai')


insert Customer_Table1
values('sidd','M','5-07-2000','8962714918','sidd@gmail.com','Mumbai')


insert Customer_Table1
values('jo','M','6-04-2000','9962715918','jo@gmail.com','Trichy')


insert Customer_Table1
values('Koushik','M','02-02-2000','772714918','wow@gmail.com','ooty')

create table Purchase_Tableee
(
BillNo int identity(401,1),
CustId int,
Name varchar(20),
total int
)

select * from Purchase_Tableee









