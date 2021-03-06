/* Create DataBase */
create database ERP_BookStores

/*  Create 2 Tables (Authors , Books) */
use ERP_BookStores
go
create table Authors 
(
	ID int IDENTITY(1,1) not null primary key,
	Author_Name varchar(30) not null
)
create table Books 
(
	ID int IDENTITY(1,1) not null primary key,
	Book_Name varchar(30) not null,
	AuthorID int 
	FOREIGN KEY (AuthorID) REFERENCES Authors(ID)
)
go

/* insert Records Authors */
use ERP_BookStores
go

insert into Authors (Author_Name) values('Ahmed')
insert into Authors (Author_Name) values('Sara')
insert into Authors (Author_Name) values('Essam')
go

/* insert Records Books based on AuthorID */
use ERP_BookStores
go

insert into Books (Book_Name,AuthorID) values('Book 1' , 4)
insert into Books (Book_Name,AuthorID) values('Book 2' , 4)
insert into Books (Book_Name,AuthorID) values('Book 33' , 5)
insert into Books (Book_Name,AuthorID) values('Book 85' , 5)
insert into Books (Book_Name,AuthorID) values('Book 820' , 4)
insert into Books (Book_Name,AuthorID) values('Book 10' , 4)
insert into Books (Book_Name,AuthorID) values('Book 36' , 4)

go
/* Seach All Authors are owners Books = id->4
//  Here  I used “ Explict Join ” */
use ERP_BookStores
go

select
	 Author_Name,Book_Name 
from 
	Books
Inner join
	Authors
on
	Books.AuthorID = Authors.ID
where
	Authors.ID = 4
	
go
