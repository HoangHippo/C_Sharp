create database b1
go 
use b1
go
create table nguoidung
(
	tk varchar(20) primary key,
	mk varchar(50),
)

insert into nguoidung values ('admin', 'admin'), ('123', '123')