-- محمود ناصر محمد خليل 
insert into LocalBranches (Code, Name, Address, AnnualBudget )
values (1000, 'cario 1', '37 Alzhoor', 175000)

insert into LocalBranches values(2000, 'Hurghada 1', '15 Ahmed Farid st', 165000);

insert into LocalBranches values(3000, 'Giza 1', '25 Alshorouk st.', 172000),
                                (4000, 'Aswan', '12 Alnasr st.', 197000),
                                (5000, 'Cairo 2', '19 Algomohoria st.', 235000),
                                (null, 'Giza 2', null, 22500);

insert into LocalBranches values(7000, 'القاهرة 3', '49 ش محمد سعيد', 245000);
-- N -> Unicode
insert into LocalBranches values(7000, N'القاهرة 3', N'49 ش محمد سعيد', 245000);

update LocalBranches set Code = 6000, Address = '32 Alahram st.' where Name = 'Giza 2';
delete from LocalBranches where Code = 7000;
select * from LocalBranches;

--======================================================================================

create table Departments
(
    --identity(seed, increment)
    Id int primary key identity(100, 10), --unique & not null
    Name nvarchar(60) not null,
    Description nvarchar(max)
);

exec sp_help Departments;

insert into Departments values('TM', 'Top Management'),
                        ('WD', 'Web Development'),
                        ('QA', 'Quality Assurance'),
                        ('BA', 'Business Analysis'),
                        ('HR', 'Human Resources');

select * from Departments;

--======================================================================================

create table Employees
(
	Id int primary key identity(1010, 10),
	FullName nvarchar(60) not null,
	NationalId nvarchar(14) unique,
	BirthDate datetime2,
	HiringDateAndTime datetime2,
	Position nvarchar(30),
	Country nvarchar(25) default 'Egypt',
	Salary decimal(18,2) check(Salary >= 6000 and Salary <= 72000),
	AnnualSalary as (Salary * 12),
	IsActive bit,
	DepartmentId int foreign key references Departments(Id) on delete no action,
	ManagerId int foreign key references Employees(Id) on delete no action
);

-- datetime2
-- (Date Range): from 0001-01-01 to 9999-12-31

-- (Time Range): from 00:00:00 to 23:59:59.9999999

exec sp_help Employees;
drop table Employees ;


insert into Employees(FullName, NationalId, BirthDate, HiringDateAndTime, Position, Salary, IsActive, DepartmentId, ManagerId) 
values('Omar Hussain Ali', '10020030040055', '1980/2/25', '2005/10/15 09:00:00', 'CEO', 49500.75, 1, 100, null);

truncate table Employees;
insert into Employees(FullName, NationalId, BirthDate, HiringDateAndTime, Position, Salary, IsActive, DepartmentId, ManagerId) values('Omar Hussain Ali', '10020030040055', '1980/2/25', '2005/10/15 09:00:00', 'CEO', 49500.75, 1, 100, null);
insert into Employees values('Bahaa Mahmoud Farid', '60005000400033', '1980/5/16', '2009/11/22 09:30:00', 'CTO', 'Egypt', 42000.25, 1, 110, 1010);
insert into Employees values('Ziyad Hassan Wahid', '10203040506070', '1985/10/27', '2012/12/24 09:00:00','Team Leader', 'Egypt', 22500, 1, 120, 1020);
insert into Employees values('Hossam Ahmed Ali', '11122233344455', '1991/10/15', '2011/11/22 09:00:00', 'Team Leader', 'Egypt', 21500.25, 1, 130, 1020);
insert into Employees values('Baraa Ashraf Essam', '10002000300044', '1993/12/29', '2012/12/24 09:00:00', 'Senior Tester', 'Kuwait', 12500.25, 1, 130, 1040);
insert into Employees values('Mostafa Mohammed Hassan', '11022033044055', '1992/11/27', '2022/07/17 9:00:00', 'Senior Developer', 'Kuwait', 15000.75, 1, 120, 1030);
insert into Employees values('Amr Ayman Aly', '11002200330044', '1997/10/15', '2021/05/25 09:00:00', 'Developer', 'Egypt', 9200, 1, 120, 1030);
insert into Employees values('Usama Mostafa Omar', '30002000100099', '1998/11/25', '2019/10/20 09:00:00', 'Tester', 'Kuwait', 6400, 1, 130, 1040);
insert into Employees values('Samir Ahmed Taha', '90008000700066', '1988/10/27', '2017/09/18 09:00:00', 'Developer', 'Kuwait', 10500, 1, 120, 1030);
insert into Employees values('Mahmoud Ashraf Saad', '90007000500033', '1994/7/20', '2020/11/03 09:00:00', 'Developer', 'Egypt', 11750, 1, 120, 1030);
insert into Employees values('Osama Omar Talaat', '20004000600088', '1990/3/15', '2010/10/30 09:00:00', 'Developer', 'Oman', 12500, 1, 120, 1030);
insert into Employees values('Bassam Hassan Allam', '99988877766655', '1987/12/13', '2024/02/12 09:00:00', 'Tester', 'Egypt', 12500, 1, 130, 1040);
insert into Employees values('Nael Amr Othman', '10102020303044', '1986/11/20', '2020/12/24 9:00:00','Senior Developer', 'Kuwait', 17250, 1, 120, 1030);
insert into Employees values('Ayman Mostafa Sallam', '90807060504030', '1995/5/27', '2023/08/28 09:00:00','Tester', 'Oman', 19500, 1, 130, 1040);
insert into Employees values('Wael Mostafa Farid', '55544433322211', '1998/10/23', '2024/03/13 09:00:00','Tester', 'Egypt', 9500, 1, 130, 1040);

select * from Employees;


--======================================================================================

create table Regions
(
	Id int primary key identity(10, 10),
	Name nvarchar(max),
	Description nvarchar(max)
);

insert into Regions values('Reg. A', 'Region A'), ('Reg. B', 'Region B'), ('Reg. C', 'Region C');
select * from Regions;
delete from Regions;

insert into Regions values('Region A', 'First Region'), ('Region B', 'Second Region'), ('Region C', 'Third Region');
select * from Regions;

truncate  table Regions
insert into Regions values('Region A', 'First Region'), ('Region B', 'Second Region'), ('Region C', 'Third Region');
select * from Regions;

--======================================================================================

--Specific Columns/Fields

select FullName, Position, Country from Employees;
--alias SqureBracket for space
select FullName as [Full Name], Position as Job, Country from Employees;
select FullName as 'Full Name', Position as Job, Country from Employees;

--All columns/fields
select * from Employees;

--======================================================================================


--Filtering
--SQL is case-insensitive
select * from Employees where Position = 'Developer';
select FullName, Position, Salary, Country from Employees where Position = 'Developer';

--not equal: != or <>
select * from Employees where position != 'Developer';
select * from Employees where position <> 'Developer';

--and
select * from Employees where Position = 'Developer' and Country = 'Egypt';
select * from Employees where Salary >= 10500 and Salary <= 12500;

--between
select * from Employees where Salary between 10500 and 12500;
select * from Employees where Salary not between 10500 and 12500;

--or
select * from Employees where Country = 'Kuwait' or Country = 'Oman';

--in
select * from Employees where Country in('Kuwait', 'Oman');
select * from Employees where Country not in('Kuwait', 'Oman');

--======================================================================================

--Wild Cards

-- % -> zero or more characters
--Zero character
select * from Employees where FullName like '%Amr Ayman Aly';
select * from Employees where FullName like 'Amr Ayman Aly%';

--More than zero character
select * from Employees where FullName like 'Ba%';
select * from Employees where FullName like '%an';
select * from Employees where FullName like '%am%';

-- _ -> Underscore -> One character
select * from Employees where FullName like '_sama Mostafa Omar';
select * from Employees where FullName like 'Amr Ayman Al_';

--[] -> any character
select * from Employees where FullName like '[mowz]%';
select * from Employees where FullName not like '[mowz]%';
--[^] -> ^ caret (Shift + 6) -> Not any character
select * from Employees where FullName like '[^mowz]%';

--======================================================================================


--Sorting/Ordering

select * from Employees order by FullName asc; --ascending
select * from Employees order by FullName; --ascending (default)
select * from Employees order by FullName desc; --descending

select * from Employees order by Salary asc;
select * from Employees order by Salary desc;

--Multiple Sorting/Ordering
select * from Employees order by Country asc, FullName asc;
select * from Employees order by Country asc, Salary desc;