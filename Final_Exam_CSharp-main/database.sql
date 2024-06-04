create database db_BTLC#
go 
use db_BTLC#
go 
create table linhvuchoatdong (
	malvhd varchar(10) primary key not null, 
	linhvuchoatdong varchar(50) not null
)

create table khachhang (
	makh varchar(10) primary key not null,
	tenkh varchar(50) not null,
	diachi varchar(100) not null,
	dienthoai varchar(10) not null,
	email varchar(50),
	malvhd varchar(10) not null,
	constraint fk_kh_lvhd foreign key (malvhd) references linhvuchoatdong(malvhd)
)

create table phongban (
	mapb varchar(10) primary key not null,
	phongban varchar(30) not null
)

create table chucvu (
	macv varchar(10) primary key not null,
	chucvu varchar(30) not null
)

create table chuyenmon (
	macm varchar(10) primary key not null,
	chuyenmon varchar(30) not null
)

create table trinhdo (
	matd varchar(10) primary key not null,
	trinhdo varchar(30) not null
)

create table nhanvien (
	manv varchar(10) primary key not null,
	tennv varchar(50) not null,
	gioitinh varchar(5) not null,
	diachi varchar(100) not null,
	dienthoai varchar(10) not null,
	email varchar(50),
	ngaysinh date not null,
	macm varchar(10) not null,
	constraint fk_nv_cm foreign key (macm) references chuyenmon(macm),
	matd varchar(10) not null,
	constraint fk_nv_td foreign key (matd) references trinhdo(matd),
	macv varchar(10) not null,
	constraint fk_nv_cv foreign key (macv) references chucvu(macv),
	mapb varchar(10) not null,
	constraint fk_nv_pb foreign key (mapb) references phongban(mapb)
)

create table quangcao (
	maqc varchar(10) primary key not null,
	manv varchar(10) not null,
	makh varchar(10) not null,
	ngayky date not null,
	tongtien float not null,
	constraint fk_qc_nv foreign key (manv) references nhanvien(manv),
	constraint fk_qc_kh foreign key (makh) references khachhang(makh)
)

create table baiviet (
	mabv varchar(10) primary key not null,
	manv varchar(10) not null,
	makh varchar(10) not null,
	ngayky date not null,
	constraint fk_bv_nv foreign key (manv) references nhanvien(manv),
	constraint fk_bv_kh foreign key (makh) references khachhang(makh)
)

create table bao (
	mabao varchar(10) primary key not null,
	tenbao varchar(100) not null,
	diachi varchar(100) not null,
	sdt varchar(10) not null,
	email varchar(50) not null
)

create table theloai (
	matheloai varchar(10) primary key not null,
	theloai varchar(10) not null
)

create table dichvu (
	madv varchar(10) primary key not null,
	dichvu varchar(30) not null
)

create table chitietquangcao (
	maqc varchar(10) not null,
	constraint fk_ctqc_qc foreign key (maqc) references quangcao(maqc),
	madv varchar(10) not null,
	constraint fk_ctqc_dv foreign key (madv) references dichvu(madv),
	mabao varchar(10) not null,
	constraint fk_ctqc_bao foreign key (mabao) references bao(mabao),
	constraint pk_ctqc primary key (maqc, madv, mabao),
	noidung varchar(500) not null,
	ngaybd date not null,
	ngaykt date not null,
	dongia float not null
)

create table chitietbaiviet (
	mabv varchar(10) not null,
	constraint fk_ctbv_bv foreign key (mabv) references baiviet(mabv),
	mabao varchar(10) not null,
	constraint fk_ctbv_bao foreign key (mabao) references bao(mabao),
	matheloai varchar(10) not null,
	constraint fk_ctbv_theloai foreign key (matheloai) references theloai(matheloai),
	constraint pk_ctbv primary key (mabv, mabao, matheloai),
	tieude varchar(500) not null,
	noidung text not null,
	ngaydang date not null,
	nhuanbut float not null
)