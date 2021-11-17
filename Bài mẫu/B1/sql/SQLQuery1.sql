Create database DieuTraDS
go 
use DieuTraDS

go

create table CongDan(
	MaCD varchar(20) primary key, 
	TenCD nvarchar(50), 
	CMND varchar(20), 
	GioiTinh varchar(20), 
	NamSinh int, 
	SDT varchar(20)
)

insert into CongDan values ('CD01', 'Nguyen Van Kien', '123', 'nu', 1996, '123'),
							('CD02', 'Nguyen Van Nam', '456', 'nu', 2000, '456'),
							('CD03', 'Nguyen Thi Nam', '010', 'nam', 1996, '222'),
							('CD04', 'Nguyen Abca', '789', 'nam', 2000, '111')

							 
select * from congdan order by tencd 