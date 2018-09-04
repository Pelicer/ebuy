drop database if exists `db_eBuy`;
create database db_eBuy;
use db_eBuy;

drop table if exists `tbl_house`;
create table tbl_house(
house_id int (1)not null,
house_name varchar (30) not null,
primary key(house_id)
);

drop table if exists `tbl_user`;
create table tbl_user(
user_id int not null auto_increment,
user_name varchar (100),
user_sirName varchar (100),
user_account varchar (100) not null,
user_password varchar(30) not null,
user_email varchar (60) not null,
user_credit double,
user_creditSpent double,
user_creditAvaliable double,
house_id int (1) not null,
primary key(user_id),
foreign key(house_id) references tbl_house(house_id)
);

drop table if exists `tbl_priority`;
create table tbl_priority(
priority_id int not null,
priority_description varchar(30) not null,
primary key(priority_id)
);

drop table if exists `tbl_product`;
create table tbl_product(
product_id int not null auto_increment,
product_name varchar (100) not null,
product_status boolean not null,
product_type varchar (30) not null,
product_description varchar (300) not null,
product_link varchar(100),
product_store varchar(30) not null,
product_price double not null,
product_buyingDate DateTime,
user_id int not null,
priority_id int not null,
primary key(product_id),
foreign key(user_id) references tbl_user(user_id),
foreign key(priority_id) references tbl_priority(priority_id)
);

drop table if exists `tbl_record`;
create table tbl_record(
record_id int not null auto_increment,
product_id int not null,
user_id int not null,
primary key(record_id),
foreign key(product_id) references tbl_product(product_id),
foreign key(user_id) references tbl_user(user_id)
);

-- inserting Harry Potter houses --
insert into tbl_house(house_id, house_name) values (0, '');
insert into tbl_house(house_id, house_name) values (1, 'Gryffindor');
insert into tbl_house(house_id, house_name) values (2, 'Slythering');
insert into tbl_house(house_id, house_name) values (3, 'Hufflepuff');
insert into tbl_house(house_id, house_name) values (4, 'Ravenclaw');

-- inserting priority levels --
insert into tbl_priority(priority_id, priority_description) values (1, 'Lowest');
insert into tbl_priority(priority_id, priority_description) values (2, 'Low');
insert into tbl_priority(priority_id, priority_description) values (3, 'Normal');
insert into tbl_priority(priority_id, priority_description) values (4, 'High');
insert into tbl_priority(priority_id, priority_description) values (5, 'Highest');

