create database b8

go 

use b8
LopHoc: MaLop, TenLop
create table Lop(
	MaLop varchar(20) primary key,
	TenLop varchar(20)
)
create table BeNgoan (
	MaBN varchar(20) primary key, 
	MaLop varchar(20), TenBeNgoan varchar(20), NgaySinh varchar(20), GioiTinh varchar(20), HoTenBo varchar(20), HoTenMe varchar(20), 
DiaChi varchar(20)
)
 
 insert into lop values('1', '1'), ('2', '2'), ('3', '3')
 
 insert into BeNgoan(MaBN, MaLop, TenBeNgoan) values ('B1', '1', 'B1'), ('B2', '2', 'B2'), 
 ('B3', '1', 'B3'), ('B4', '1', 'B4'), ('B5', '2', 'B5')


 select * from lop