create database db;

create table db.data(
username varchar(50),
password varchar(50)
);

insert into db.data values("admin","1234");

insert into db.data values("employee","1234");

select * from db.data;


create table db.user1(
u_id varchar(20),
u_name varchar(30),
seat_id varchar(20),
emp_id varchar(20),
Due_bill int,
pay_status varchar(20),
primary key(u_id)
);

insert db.user1 values("123","mukut","202/A","employee",1000,"not paid");


create table db.employee(
emp_id varchar(20),
emp_pass varchar(20),
emp_name varchar(50),
salary int,
admin_id varchar(20),
u_id varchar(20),
primary key(emp_id)
);


create table db.admin(
admin_id varchar(50),
admin_pass varchar(50),
seat_id varchar(20),
primary key(admin_id)
);


create table db.seat(
seat_id varchar(20),
avalability varchar(20),
emp_id varchar(20),
primary key(seat_id)
);


create table db.payment(
payment_id varchar(20),
u_name varchar(20),
total_amount int,
seat_id varchar(20),
primary key(payment_id)
);





