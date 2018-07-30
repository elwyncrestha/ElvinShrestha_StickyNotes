create database ElvinShrestha_StickyNote;
use ElvinShrestha_StickyNote;

create table UserType_tbl
(
	userTypeId int not null identity,
	userTypeName varchar(20) not null,
	constraint pk_UserType_tbl primary key(userTypeId)
);


create table User_tbl
(
	userId int not null identity,
	userFName varchar(50),
	userLName varchar(50),
	userDOB date,
	userAddress varchar(50),
	userContact varchar(15),
	userEmail varchar(50),
	userUsername varchar(50),
	userPassword varchar(75),
	userTypeId int not null,
	userActivationStatus bit,
	constraint fk_UserType_tbl foreign key(userTypeId) references UserType_tbl(userTypeId) on delete cascade,
	constraint pk_User_tbl primary key(userId)
);


create table Category_tbl
(
	categoryId int not null identity,
	categoryName varchar(50),
	userId int,
	constraint fk_User_tbl foreign key(userId) references User_tbl(userId) on delete cascade,
	constraint pk_Category_tbl primary key(categoryId)
);


create table StickyNote_tbl
(
	noteId int not null identity,
	noteDate date not null,
	noteTitle varchar(50),
	noteContent varchar(300),
	noteCompletionStatus bit,
	noteStickyStatus bit,
	userId int,
	categoryId int,
	constraint fk_User_tbl_StickyNote_tbl foreign key (userId) references User_tbl (userId), /*no on delete cascade action because two on delete action is not allowed, so this problem is solved through C# codes*/
	constraint fk_Category_tbl foreign key (categoryId) references Category_tbl (categoryId) on delete cascade,
	constraint pk_StickNote_tbl primary key (noteId)
);

select * from User_tbl;
select * from UserType_tbl;
select * from Category_tbl;
select * from StickyNote_tbl;