
--Indexing Type (clustering) 
--الـ Data نفسها مرتبة مع الـ Index.
--An index that determines the physical order of data in a table, making data retrieval faster 
--only on clustered index on one table
--i select one column that search on it alot to make clustering and to enhance performance
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

--1.1 non unique clustered index
create clustered index ix_sectors_name_asc on Sectors(Name asc);

insert into Sectors values(40, 'Fifth Sector', 20), (10, 'Sixth Sector', 30);

exec sp_helpindex Sectors;
select * from Sectors;



--1.2. Unique Clustered Index
drop index Sectors.ix_sectors_name_asc;
exec sp_helpindex Sectors;

delete from Sectors where Code = 20;
select * from Sectors;
create unique clustered index ix_sectors_unique_name_asc on Sectors(Name asc);
insert into Sectors values(20, 'Second Sector', 55);

exec sp_helpindex Departments;

exec sp_helpindex Sectors;



--محمود ناصر محمد خليل 
--2. Non-clustered index
--الـ Index منفصل وبيحتوي على pointer/reference للبيانات.
--2.1. Non-unique Non-clustered Index
create nonclustered index ix_departments_Name_asc on Departments(Name asc);

--2.2. Unique Non-clustered Index
create unique nonclustered index ix_plants_Name_asc on Plants(Name asc);

exec sp_helpindex Departments;
exec sp_helpindex Plants;

--Clustered Index stores data in the index order,
--while Non-Clustered Index stores the index separately and points to the actual data.
--Clustered = faster data access, but only one.
--Non-Clustered = more flexible, and you can have multiple.