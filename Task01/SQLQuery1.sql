--•	Create a schema named "Sales" within the "CompanyDB" database.
create schema Sales
go
--•	Create a table named "employees" with columns: employee_id (INT), 
--first_name (VARCHAR), last_name (VARCHAR), and salary (DECIMAL) within the "Sales" schema.
--identity
create table Sales.employees(
employee_id int identity primary key,
first_name varchar(30) ,
last_name  varchar(30),
salary  decimal
);
--•	Alter the "employees" table to add a new column named "hire_date" with the data type DATE.
alter table Sales.employees
add hire_date date
--DATA MANIPULATION 
--•	Select all columns from the "employees" table.
select * from Sales.employees
--•	Retrieve only the "first_name" and "last_name" columns from the "employees" table.
select employees.first_name,employees.last_name  from Sales.employees
--•	Retrieve “full name” as a one column from "first_name" and "last_name" columns from the "employees" table
select employees.first_name+' '+employees.last_name as'full name'  from Sales.employees
--•	Show the average salary of all employees.
select AVG(salary) as 'average salary '  from Sales.employees
--•	Select employees whose salary is greater than 50000.
select * from Sales.employees where salary>50000
--•	Retrieve employees hired in the year 2020
select * from sales.employees where Year(hire_date)=2020 --2020 not existed in my db
--•	List employees whose last names start with 'S.'
select * from Sales.employees where last_name like 'S%'
--•	Display the top 10 highest-paid employees.
select top 10 employee_id , first_name+' '+last_name as 'FullName' ,salary from Sales.employees order by salary desc
--•	Find employees with salaries between 40000 and 60000.
select * from sales.employees where salary>40000 and salary<60000
--•	Show employees with names containing the substring 'man.'
select * from Sales.employees where first_name like '%man%' or last_name like '%man%' --not existed in my db 