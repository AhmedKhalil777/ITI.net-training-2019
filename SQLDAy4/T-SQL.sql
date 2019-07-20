--schema creation

create schema hr
 
 alter schema hr transfer [Ins_Course]


 select st_fname ,st_lname ,st_age  from student
  select *  from student where st_age>20












--Select Statment
--ServerName.DatabaseName.Schema.Object



Select * From  "DESKTOP-1DAFTR2".dotnetg3.[dbo].department



select st_fname +' ' + st_lname as [fullname]  , st_age+1 as age from student

--alias name and dealing with space in the column names
Select St_fname+' '+st_lname as 'full name' from Student


Select * from student


select * from student where st_age is  not null




select * from Student where st_lname is not null

--is null and IS NOT NULL with where clause
select * from Course
where Crs_Duration = null    --null is not a value

select * from Course
where Crs_Duration is  null

--Null Function
--ISNULL function 
select isnull( st_fname,' ') ,ISNULL( st_lname ,' ' ), isnull(st_age ,0) from Student
 
select ISNULL(st_age,100) , ISNULL(St_Fname ,' ') from Student



--operators > , < ,()
-- or, and, and not
Select St_fname,st_lname from Student
where St_Age>25 or St_Age <30

Select St_fname,st_lname from Student
--where St_Age=25 or St_Age =30 or st_age =28 or st_age=26
where st_age in (25,30,28,26)

--where St_Age in (25 ,26,27)
--In Statment

insert into topic2(top_name)
select top_name from topic where top_id <11


select *
into topic4
 from topic where  1=2


insert into topic 
select * from topic2


insert into student3([full name] ,st_age)
select st_fname +' '+st_lname as'full name' ,st_age from student 
where st_age >20


Select St_fname,st_lname from Student
where St_Age in(25,26,27)


--insert base on select

insert into [hr].[Topic]
select * from [dbo].[test]



--select into
select st_fname as name,st_age  as age
into student4
from Student
where St_Age >20

select st_fname+' ' +St_Lname  as [full name]
into test4
from Student
where 1=2

--like
Select St_fname,st_lname from Student
where st_fname like 'A%'

Select St_fname,st_lname from Student
where st_fname like '_A%'

Select St_fname,st_lname from Student
where st_fname like '[_]A%'

Select St_fname,st_lname from Student
where st_fname like '___' 



--order by desc asc (default asc)
--Order by can by followed by numbers not column names [order by 1 Asc,2 Desc]
select * from Student
order by st_age desc ,st_fname 

--order by 5 desc ,2
--order by St_Age desc ,St_Fname 



select * from Student
order by newID() 

--we can sort with more than one column

--Between

select * from Student
where St_Age between 25 and 45

--joins 
	--joins is faster than subqueries if the number of tables is smaller
	--and if there is indexes
--cross join
--Cross join or Cartsian product

--A Cartesian Product
select s.st_fname,d.dept_name
from student s , department d
where s.Dept_Id=d.Dept_Id

select s.St_Fname ,s.St_Lname ,d.Dept_Name
from student s full outer join Department d 
on s.Dept_Id=d.dept_id

select s.St_Fname ,d.Dept_Name ,i.Ins_Name
from student s inner join department d on s.Dept_Id=d.Dept_Id
inner join hr.Instructor i on d.Dept_Id=i.Dept_Id
where s.Dept_Id >30


select 
from student s , Department d ,hr.Instructor i
where s.Dept_Id=d.Dept_Id and d.Dept_Id=i.Dept_Id and s.Dept_Id






--Inner join and equi join
select st_fname,dept_name
from student s inner join department d
on s.dept_id=d.dept_id
where s.St_Age >25



select s.St_Fname ,d.Dept_Name
from Student s ,Department d,hr.Instructor i
where s.Dept_Id=d.Dept_Id and d.Dept_Id=i.Dept_Id



select s.St_Fname ,d.Dept_Name

from Student s full outer join Department d
on s.Dept_Id=d.Dept_Id






--==
select s.St_Fname ,d.Dept_Name
from Student s ,Department d
where s.Dept_Id=d.Dept_Id and s.St_Age>25





select st_fname,dept_name
from student s,department d
where s.dept_id=d.dept_id

--inner with 3 tables
select st_fname,dept_name,ins.ins_name
from student s inner join department d
on s.dept_id=d.dept_id inner join instructor ins
on ins.dept_id=d.dept_id
order by ins_name

--Outer join ===> left, right and full


select st_fname,dept_name
from student s left outer join department d
on s.dept_id=d.dept_id

select st_fname,dept_name
from student s right outer join department d
on s.dept_id=d.dept_id

select st_fname,dept_name
from student s full outer join department d
on s.dept_id=d.dept_id



--Self join(recursive relation)





select stud.st_fname,super.st_fname as "supervisor Name"
from student super,student stud
where super.st_id=stud.st_super
 
--aggregate functions
--used in select, having
select coalesce(salay ,part,hours) as salary ,name 
from employee

--count avg sum max min

select avg(isnull(st_age,0)) from student
select MAX(crs_duration) from Course

select COUNT(st_fname) from student
 
select COUNT(*) from student

SELECT AVG(ST_AGE) FROM Student
 
SELECT AVG(ISNULL(ST_AGE,0)) FROM Student



select count(isnull(st_age,0)) as avg ,St_super,Dept_Id 
from student

group by Dept_Id,St_super
having count(st_id)>2

--group by
select COUNT(st_id),Dept_Id from Student
group by Dept_Id


--having
select COUNT(st_id),Dept_Id from Student
group by Dept_Id
having COUNT(st_id)>2

--having without group by 
--u should use aggregate in select close
select COUNT(*) from student
having avg(St_Age)<25


--sub queries
--the problem
Select St_fname,st_lname from Student
where St_Age> AVG(st_age)


--solusion
Select St_fname,st_lname from Student
where St_Age> (select AVG(st_age) from Student)

Select ins_name 
from instructor
where Ins_Id in (select dept_manager from Department where Dept_Manager is not null)
--inner query returns true or false
--no date returned or processed


--Joins Vs Subqueries
--Joins are performed faster by SQL Server than subqueries
--Subqueries can often be rewritten as joins
--SQL Server 2008 query optimizer is intelligent enough to covert a subquery into a join if it can be done

--Distinct
select distinct st_fname ,St_Lname
from Student

--If a query contains more than one column, distinct filters out only the rows in which the entire combination of values appears more than once

--Top
select Top 5 * 
from student

--Top with order
select Top 4 * 
from student
order by St_Age desc

--Top randomized
SELECT TOP(5) *
FROM student
ORDER BY NEWID();



--Union [all] AND Rules
select St_Fname from Student
union  
select Ins_Name from hr.Instructor

-----------------------------------

----Stored procedure----

--1-parsing 2-optimization 3-query tree 4-query plan
----Stored procedure is not precompiled but it is complied with first run

allst
create proc studentByAge (@age int=10 ,)
as
select * from student where St_Age> @age

studentByAge 25

create proc allst
as
select * from student where St_Age> 20


stud
 
 create proc stud
 as
 select * from student where St_Age =25

 stud_age 
 
 create proc stud_age (@age int =10)
 as 
 select * from student where St_Age =@age
 



create proc p1
as
select ins_name,salary
from instructor where ins_id=10


 p1


 --input parameters



create proc deptname
(@fname varchar(40), @lname varchar(20)=NULL)
	as
	  select d_name
		from student s,department d
		where st_fname = @fname
		and st_lname = @lname
		and s.d_id=d.d_id
	


	

deptname 'ahmed','kariem'




------------------------------

SELECT DB_NAME() AS 'database'    
--select name of the current Database


--Retrieve Info about all objects
sp_help

--Retrieving Info about all dbs
sp_helpdb

--Retrieving Info about a specific db
sp_helpdb iti

--To retrieve info. about a specific Table (schema,columns,keys,indexes)
sp_help student

--To retrieve info. about a specific DataType
sp_help nvarchar


--Returns one row for each column of an object that contains columns
--(for example, a table or a view)a row of each column in that table
--columns of the same table will have the same obj_id
select * 
from sys.columns

select * 
from sys.tables

select * 
from sys.schemas