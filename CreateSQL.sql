/*
use master
if exists(select * from sysdatabases where name = 'LibraryDatabase')
drop database LibraryDatabase
create database LibraryDatabase
on 
(
	name = LibraryDatabase,
	filename = 'E:\ͼ�����ϵͳ\LibraryDatabase.mdf',
	size =10,
	filegrowth =20%
)
log on
(
	name = 'LibraryDatabase_log',
	filename = 'E:\ͼ�����ϵͳ\LibraryDatabase_log.ldf',
	size = 3,
	maxsize =20,
	filegrowth = 10%
	
);
*/

/*����Administrator*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Administrator')
drop table Administrator
create table Administrator
(
	ID int identity(1,1) not null,--��ʶ��
	[Name] varchar(15) not null,--����Ա����
	[Password] varchar(10) not null,--����
	email varchar(20),--����
	Sex bit not null,
	[Level] int, --�ȼ�
	RegDate datetime not null, --ע������
	remark varchar(20) not null,-- ��ע
	[State] int null,--״̬
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

/*����Book*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Book')
drop table Book
create table Book
(
	ID int identity(1,1) not null,--��ʶ��
	[Name] varchar(15) not null,--����
	Publisher varchar(20),--������
	anchor varchar(20),--����
	PublishDate datetime, --��������
	Flag bit,--�Ƿ���Խ����ʶ
	primary key(ID)
	
);
*/

--����Student
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'Student')
drop table Student
create table Student
(
	SID int identity(1,1) not null,--��ʶ��
	Sno varchar(15) not null,--ѧ��
	SName varchar(15) not null,--����
	[Password] varchar(10) not null,--����
	MaxNumber int,--��������
	MaxDays int,--�������
	RemainNumber int, --�ѽ�����
	RegDate datetime, --ע������
	remark varchar(20), --��ע
	[State] int, --״̬
	Sex bit --�Ա�
	primary key(SID)
	
);
*/
/*
use LibraryDatabase
if exists(select * from sysobjects where name = 'BS')
drop table BS
create table BS
(
	SID int not null,--ѧ��ѧ��
	ID int not null,--���
	BeginDate datetime, --��������
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
--	HID int identity(1,1) not null,--��¼���
--	SID int not null,--ѧ�����
--	BID int not null,--�鼮���
--	BeginDate datetime not null,--��������
--	ReturnDate datetime,--��������
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