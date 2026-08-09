
-- محمود ناصر محمد خليل 
create database Gem ;
alter database Gem modify name = GemCo ;

-- system/pre-defined/buily-in stored procedure
exec sp_renamedb GemCo , GemTrade ;

use master
alter database GemTrade set single_user with rollback immediate;
drop database [GemTrade] ;

--============================================================
-- محمود ناصر محمد خليل 
create database Diamond ;
use Diamond ;
create table Branches 
(
	code int,
	Name nvarchar (30),
	city nvarchar(20),
	Address nvarchar (max)
);

execute sp_help Branches

exec sp_rename [dbo.Branches] , LocalBranches ;
execute sp_help  LocalBranches




-- محمود ناصر محمد خليل 
alter table LocalBranches add Budget int ;
execute sp_help  LocalBranches ;



-- محمود ناصر محمد خليل 

exec sp_rename [LocalBranches.Budget] , AnnualBudget;

alter table LocalBranches alter column AnnualBudget decimal(18, 2);

alter table LocalBranches drop column city

execute sp_help  LocalBranches ;



-- محمود ناصر محمد خليل 
drop table LocalBranches

execute sp_help  LocalBranches ;





-- محمود ناصر محمد خليل 

create table LocalBranches
(
	Code int,
	Name nvarchar(30),
	Address nvarchar(max),
	AnnualBudget decimal(18, 2)
);

execute sp_help  LocalBranches ;

insert into LocalBranches (Code, Name, Address, AnnualBudget )
values (1000, 'cario 1', '37 Alzhoor', 175000)

select * from LocalBranches
