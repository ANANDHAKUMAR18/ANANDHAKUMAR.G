use trail
go

create table emp_reggg
(
Sno int identity(100,1),
fName varchar(20),
LName varchar(20),
Gender char(1),
Mobilenumber varchar(20),
CollegeName varchar(20),
Qualification varchar(20),
TenthMark int,
TwelvethMark int,
Department char(20),
Nationality char(10),
Passoutyear varchar(20),
Mailid varchar(40),
Anyarrears char(20),
Ifyeshowmany int,
programmingskills varchar(20),
constraint Pk_Akkk check (Department='ECE'),
constraint arggg check (Nationality='INDIAN')
)


select * from emp_reggg

insert  emp_reggg
values('ANAND','GANESAN','M','9932734911','SJCE','B.E',420,950,'ECE','INDIAN','2020','anandhsandy.g@gmail.com','Yes',1,'AUTOCADD')
insert emp_reggg
values('SIDD','VENKAT','M','9432735913','SJCE','B.E',463,1050,'CSE','INDIAN','2020','venkatsidd@gmail.com','NO',0,'C++')
insert emp_reggg
values('JOHN','RICKY','M','8932765951','SJCE','B.E',440,1020,'EEE','INDIAN','2020','rickyjohn@gmail.com','NO',0,'C')
insert emp_reggg
values('GIRI','DHARAN','M','8832485923','SJCE','B.E',436,1030,'CSE','INDIAN','2020','giridharan@gmail.com','NO',0,'C++')


