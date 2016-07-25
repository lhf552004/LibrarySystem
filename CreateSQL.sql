/*
use master
if exists(select * from sysdatabases where name = 'LibraryDatabase')
drop database LibraryDatabase
create database LibraryDatabase
on 
(
	name = LibraryDatabase,
	filename = 'E:\图书管理系统\LibraryDatabase.mdf',
	size =10,
	filegrowth =20%
)
log on
(
	name = 'LibraryDatabase_log',
	filename = 'E:\图书管理系统\LibraryDatabase_log.ldf',
	size = 3,
	maxsize =20,
	filegrowth = 10%
	
);
*/

/*创建Administrator*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Administrator')
drop table Administrator
create table Administrator
(
	ID int identity(1,1) not null,--标识列
	[Name] varchar(15) not null,--管理员姓名
	[Password] varchar(10) not null,--密码
	email varchar(20),--邮箱
	Sex bit not null,
	[Level] int, --等级
	RegDate datetime not null, --注册日期
	remark varchar(20) not null,-- 备注
	[State] int null,--状态
	primary key(ID)
	
)
;
*/

/*
alter table Administrator

	add	constraint DF_Password default(888888) for [Password],
	constraint DF_Sex default(1) for Sex,
	constraint DF_RegDate default(getdate()) for RegDate,
	constraint DF_State default(0) for [State],
	constraint CK_Email check(email like '%@%'),
	constraint CK_password check(len([Password])>=6)
*/

/*创建Book*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Book')
drop table Book
create table Book
(
	ID int identity(1,1) not null,--标识列
	[Name] varchar(15) not null,--书名
	Publisher varchar(20),--出版社
	anchor varchar(20),--作者
	PublishDate datetime, --出版日期
	Flag bit,--是否可以借书标识
	primary key(ID)
	
);
*/

--创建Student
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Student')
drop table Student
create table Student
(
	SID int identity(1,1) not null,--标识列
	Sno varchar(15) not null,--学号
	SName varchar(15) not null,--姓名
	[Password] varchar(10) not null,--密码
	MaxNumber int,--最大借书量
	MaxDays int,--最大天数
	RemainNumber int, --已借书量
	RegDate datetime, --注册日期
	remark varchar(20), --备注
	[State] int, --状态
	Sex bit --性别
	primary key(SID)
	
);
*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'BS')
drop table BS
create table BS
(
	SID int not null,--学生学号
	ID int not null,--书号
	BeginDate datetime, --借书日期
	primary key(ID),
	foreign key(SID) references Student(SID),
	foreign key(ID) references Book(ID)
);
*/
--use LibraryDatabase
--if exists(select * from sysobjects where name = 'BS_History')
--drop table BS_History;
--create table BS_History
--(
--	HID int identity(1,1) not null,--记录编号
--	SID int not null,--学生编号
--	BID int not null,--书籍编号
--	BeginDate datetime not null,--借书日期
--	ReturnDate datetime,--还书日期
--
--);

--alter table Book add Price money
--alter table Student add Debt money
--alter table BS_History add BS int not null
--alter table BS_History drop column HID
--alter table BS_History 
--add primary key(BS),
--foreign key(SID) references Student(SID),
--foreign key(BID) references Book(ID)
--select b.BeginDate,s.MaxNumber from BS b  join Student s on b.SID = s.SID where b.ID = 2
--select Name from sys.foreign_key_columns f join sys.objects o on f.constraint_object_id = o.object_id
--where f.parent_object_id =object_id(BS_History)
--alter table BS_History
--drop FK__BS_History__BID__1920BF5C
alter table BS_History alter  column BID varchar(20) not null