Create Database WiproSampleDB

Use WiproSampleDB


create table Employee(Empid int not null,Empanme varchar(20),EmpLoc varchar(40))

insert into Employee Values(1,'sai','hyd')

alter table Employee add salary decimal(8,2)

alter table Employee alter column Empid varchar(30)

select * from Employee

alter table Employee alter column Empid int not null

insert into Employee values(2,'sathwik','blg',50000),
                           (3,'vignesh','hyd',40000),
						   (4,'shiva','hyd',30000);

select * from Employee

update Employee set salary=60000 where Empid=1


delete from Employee where Empid=4


exec sp_rename 'Employee','EmployeeWipro'

select * from EmployeeWipro

truncate table EmployeeWipro

drop table EmployeeWipro


create table employee_wipro(Empid int not null,Empanme varchar(20),DeptId int not null, DeptName varchar(40))


insert into employee_wipro values(1,'sai',101,'coding'),
                                  (2,'sathwik',101,'coding'),
								  (3,'vignesh',103,'HR'),
								  (4,'shiva',104,'tester');

select * from employee_wipro

select * from employee_wipro where DeptId<=102
select * from employee_wipro where DeptId<=102 or DeptName='coding'

select * from employee_wipro where DeptId in('coding','tester')

exec sp_rename 'employee_wipro.Empanme','EmpName','COLUMN'

select * from employee_wipro where EmpName like '[s-z]%' 


















                           