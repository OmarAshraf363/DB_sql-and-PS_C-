create schema hr
go
--Regions table 
create table hr.REGIONS(
REGION_ID int primary key ,
REGION_NAME VARCHAR(25)
);
--COUNTRIES TABLE 
CREATE TABLE hr.COUNTRIES(
COUNTRY_ID INT PRIMARY KEY,
COUNTRY_NAME VARCHAR(40),
REGION_ID INT ,
FOREIGN KEY (REGION_ID) REFERENCES hr.REGIONS(REGION_ID),
);
--LOCATIONS TABLE 
CREATE TABLE hr.LOCATIONS(
LOCATION_ID INT PRIMARY KEY,
STREET_ADDRESS VARCHAR(25),
POSTAL_CODE VARCHAR(12),
CITY VARCHAR(30),
STATE_PROVINCE VARCHAR(12),
COUNTRY_ID INT ,
FOREIGN KEY (COUNTRY_ID) REFERENCES hr.COUNTRIES(COUNTRY_ID),
);
--JOBS TABLE 
CREATE TABLE hr.JOBS(
JOB_ID VARCHAR(10) PRIMARY KEY ,
JOB_TITLE VARCHAR(25),
MIN_SALARY INT ,
MAX_SALARY INT ,
);
--JOB_GRADES TABLE 
CREATE TABLE hr.JOB_GRADES(
GRADE_LEVEL VARCHAR(2) PRIMARY KEY,
LOWEST_SAL INT ,
HIGHEST_SAL INT ,
);
CREATE TABLE hr.DEPARTMENTS(
DEPARTMENT_ID INT PRIMARY KEY,
DEPARTMENT_NAME VARCHAR(30),
MANGER_ID INT ,
LOCATION_ID INT,
FOREIGN KEY (LOCATION_ID) REFERENCES hr.LOCATIONS(LOCATION_ID),

);
--EMPLOYEE TABLE 
CREATE TABLE hr.EMPLOYEES(
EMPLOYEE_ID INT PRIMARY KEY,
FIRST_NAME VARCHAR(20),
LAST_NAME VARCHAR(25),
EMAIL  VARCHAR(25),
PHONE_NUMBER  VARCHAR(20),
HIRE_DATE DATE,
JOB_ID VARCHAR(10),
SALARY INT,
COMMISION_PCT INT ,
MANGER_ID INT ,
DEPARTMENT_ID INT ,
FOREIGN KEY (JOB_ID) REFERENCES hr.JOBS(JOB_ID),
FOREIGN KEY (MANGER_ID) REFERENCES hr.EMPLOYEES(EMPLOYEE_ID),
FOREIGN KEY (DEPARTMENT_ID) REFERENCES hr.DEPARTMENTS(DEPARTMENT_ID),



);
--JOB_HISTORY TABLE 
CREATE TABLE hr.JOP_HISTORY(
EMPLOYEE_ID INT,
START_DATE DATE,
END_DATE DATE,
JOB_ID VARCHAR(10),
DEPARTMENT_ID INT ,
PRIMARY KEY(EMPLOYEE_ID,START_DATE),
FOREIGN KEY (JOB_ID) REFERENCES hr.JOBS(JOB_ID),
FOREIGN KEY (DEPARTMENT_ID) REFERENCES hr.DEPARTMENTS(DEPARTMENT_ID),

);
