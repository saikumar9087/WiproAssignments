create table college(std_id int not null, std_name varchar(40),dept_id int not null)
create table clg_dept(dept_id int not null, dept_name varchar(40),presnet_absent varchar(30))

alter table college add std_marks varchar(20)

alter table clg_dept drop column presnet_absent


select * from college
select * from clg_dept


insert into college values(1,'sai',101,80),
                           (2,'sathwik',101,60),
						   (3,'shiva',102,70),
						   (4,'vignesh',102,50),
						   (5,'aashrit',103,40);


insert into clg_dept values(101,'CSE'),
                            (102,'IT'),
							(103,'ECE');



alter table college add primary key(std_id)
alter table clg_dept add foreign key references college(dept_id)

select count(*) as "No.of students" from college;



alter table college alter column std_marks int;

select avg(std_marks) as "Overall Avg" from college;


select count(*),std_name from college group by dept_id


select SYSDATETIME() AS currentdate

select * from college where std_id%2=0

create function GetCountStudent()
returns int
as
begin
   declare @noofstd int;
   select @noofstd=count(*) from college;
   return @noofstd;
end;

select dbo.GetCountStudent()


