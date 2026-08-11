--محمود ناصر محمد خليل 

use Diamond;

--top
select top 3 * from Employees;
select top 3 * from Employees order by Salary asc;
select top 3 * from Employees order by Salary desc;

--==========================================================================================================================

--distinct
select distinct Country from Employees;
select distinct Position from Employees;
select distinct Country, Position from Employees;

--==========================================================================================================================


--Aggregate Functions (SUM, COUNT, AVG, MAX, MIN)
--sum()
select sum(Salary) as [Total Salaries] from Employees;
select sum(Salary) as 'Egypt Salaries' from Employees where Country = 'Egypt';
select sum(Salary) as 'Less than 10000 Salaries' from Employees where Salary < 10000;

insert into Employees values('Ashraf Sayed Taha', '55944933922919', '1999/10/29', '2024/09/19 09:00:00', 'Secretary', 'Egypt', 11000, 1, null, null);
insert into Employees values('Medhat Omar Mahmoud', '55244233222212', '1992/12/22', '2024/02/12 09:00:00', 'Guard', 'Egypt', 8000, 1, null, null);

--count() -> number/count of non-null values
update Employees set Salary = null where Id in(1070, 1120);
select count(Salary) as [Number of Salaries] from Employees;
select count(Salary) as 'Less than 10000 Salaries' from Employees where Salary < 10000;
select count(DepartmentId) as 'Number of Department Employees' from Employees;
select count(Id) as 'Number of All Employees' from Employees; --Slower
select count(*) as 'Number of All Employees' from Employees; --Faster

--avg()
select avg(Salary) as [Average Salary] from Employees;
select avg(Salary) as 'Egypt Average Salary' from Employees where Country = 'Egypt';

--max()
select max(Salary) as [Maximum Salary] from Employees;

--min()
select min(Salary) as 'Minimum Salary' from Employees;

--==========================================================================================================================

--Grouping -> group by
select Country, count(*) as [Number of Employees] from Employees group by Country;
select Position, count(*) as 'Number of Employees' from Employees group by Position;

--where must precede group by clause
select Position, count(*) as 'Number of Employees' from Employees where Position like '%Developer%' group by Position;

--having must follow group by clause
select Position, count(*) as 'Number of Employees' from Employees group by Position having count(*) > 1;

--multiple grouping
select Country, Position, count(*) as 'Number of Employees' from Employees group by Country, Position order by Country asc;

--==========================================================================================================================


--(1) Outer Joins [Left Outer Join - Right Outer Join - Full Join]
--1.1. Left Outer Join
select * from Employees left outer join Departments on Employees.DepartmentId = Departments.Id;
select * from Departments left outer join Employees on Departments.Id = Employees.DepartmentId;

--1.2. Right Outer Join
select * from Employees right outer join Departments on Employees.DepartmentId = Departments.Id;
select * from Departments right outer join Employees on Departments.Id = Employees.DepartmentId;

--1.3. Full Outer Join
select * from Employees full outer join Departments on Employees.DepartmentId = Departments.Id;

--==========================================================================================================================

--(1)Inner Join
select * from Employees Inner join Departments on Employees.DepartmentId = Departments.Id;
select * from Departments Inner join Employees on Departments.Id =  Employees.DepartmentId;

--==========================================================================================================================

--(3) Cross Join
create table Plants
(
    Id int primary key identity(10, 10),
    Name nvarchar(50) not null unique
);

insert into Plants values('Plant 01'), ('Plant 02'), ('Plant 03');
select * from Plants;

create table Chemicals
(
    Id int primary key identity(100, 100),
    Name nvarchar(50) not null unique
);

insert into Chemicals values('Chemical 01'), ('Chemical 02'), ('Chemical 03');
select * from Chemicals;

select Chemicals.Name as Chemical, Plants.Name as Plant, '' as Notes from Chemicals cross join Plants order by Chemicals.Name asc;

--==========================================================================================================================


--Sub-query
select Id from Departments where Name = 'QA'; --120
select * from Employees where DepartmentId = (select Id from Departments where Name = 'QA'); --DepartmentId = 120

select Id from Departments where Name in('TM', 'QA'); --100, 120
select * from Employees where DepartmentId in(select Id from Departments where Name in('TM', 'QA')); --DepartmentId in(100, 120)

--==========================================================================================================================


--Join -> better performance        --Sub-query -> more readable
--select * from Employees left outer join Departments on Employees.DepartmentId = Departments.Id;
select *,
(select Id from Departments where Id = DepartmentId) as Id,
(select Name from Departments where Id = DepartmentId) as Name,
(select Description from Departments where Id = DepartmentId) as Description
from Employees;

--==========================================================================================================================

--View
create view KuwaitEmployees as
select Id, FullName, NationalId, BirthDate, Country
from Employees where Country = 'Kuwait';

exec sp_help KuwaitEmployees;

insert into KuwaitEmployees
values('Ali Sayed Mamdouh', '10120230340455', '1998/2/13 00:00:00', 'Kuwait');

update KuwaitEmployees set FullName = 'Ashraf Salah Sayed' where Id = 1180;

delete from KuwaitEmployees where Id = 1180;

select * from Employees;
select * from KuwaitEmployees;

--==========================================================================================================================

--clustering
create table Sectors
(
	Code int,
	Name nvarchar(50),
	Budget int
);

exec sp_help Sectors

insert into Sectors values(70, 'First Sector', 35),
                           (90, 'Second Sector', 25),
                           (30, 'Third Sector', 40),
                           (80, 'Fourth Sector', 20);

select * from Sectors;

create clustered index ix_sectors_name_asc on Sectors(Name asc);

insert into Sectors values(40, 'Fifth Sector', 20), (10, 'Sixth Sector', 30);

exec sp_helpindex Sectors;
select * from Sectors;