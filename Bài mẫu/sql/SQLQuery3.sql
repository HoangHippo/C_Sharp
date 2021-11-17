create database b3
go
use b3
MaCD, MaPhuong, TenCD, CMND, GioiTinh, NamSinh, SoDienThoai
create table congdan (
	macd varchar(20) primary key,
	tencd nvarchar(50), 
	CMND varchar(20),
	gioitinh varchar(20),
	namsinh varchar(20),
	sdt varchar(20)
)

