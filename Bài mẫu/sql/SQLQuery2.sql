create database b2
use b2
MaCD, TenCD, CMND, GioiTinh, NamSinh, SoDienThoa
create table CongDan(
	macd varchar(20) primary key,
	tencd nvarchar(50), 
	cmnd varchar(50),
	gioitinh varchar(20),
	namsinh int,
	sdt varchar(20)
)

insert into CongDan values('1','1','1','nam','2001', '123'), ('2','3','1','nam','2001', '123')