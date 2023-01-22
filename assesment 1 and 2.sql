CREATE database TrainingDB;

use TrainingDB;

CREATE table dept
(deptno int primary key,
dname varchar(20) not null,
loc varchar(20));

create table emp
(empno int primary key,
ename varchar(20)not null,
job varchar(20),
mgr_id int,
hiredate date,
sal float,
comm int,
deptno int references dept(deptno));

insert into dept values
(10,'accounting','new york'),
(20,'research','dallas'),
(30,'sales','chicago'),
(40,'operations','boston');
select * from dept;
select * from emp;
insert into emp values
(7369,'smith','clerk',7902,'1980-12-17',800,null,20),
(7499,'allen','salesman',7698,'1981-02-20',1600,300,30),
(7521,'ward','salesman',7698,'1981-02-22',1250,500,30),
(7566,'jones','manager',7839,'1981-05-02',2975,null,20),
(7654,'martin','salesman',7698,'1981-08-28',1250,1400,30),
(7698,'black','manager',7839,'1981-05-01',2850,null,30),
(7782,'clerk','manager',7839,'1981-06-09',2450,null,10),
(7788,'scott','analyst',7566,'1987-04-19',3000,null,20),
(7839,'king','president',null,'1981-11-17',5000,null,10),
(7844,'turner','salsman',7698,'1981-09-07',1500,0,30),
(7876,'adams','clerk',7788,'1987-05-23',1100,null,20),
(7900,'james','clerk',7698,'1981-12-12',950,null,30),
(7902,'ford','analyst',7566,'1981-12-03',3000,null,20),
(7934,'miller','clerk',7782,'1982-01-23',1300,null,10);

/* -----------------ASSESSMENT 1-----------------*/

-- 1. List all employees whose name begins with 'A'. 
select * from emp where ename like 'A%' ;

-- 2. Select all those employees who don't have a manager. 
select * from emp where mgr_id is null;

-- 3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 
select ename,empno,sal from emp where sal between 1200 and 1400 ;

-- 4. Give all the employees in the RESEARCH department a 10% pay rise.
--  Verify that this has been done by listing all their details before and after the rise.)
select * , (1.1* sal) as new_sal from emp join dept on emp.deptno = dept.deptno where dname = 'research';

-- 5. Find the number of CLERKS employed. Give it a descriptive heading. 
select count(job) as 'no of clerks' from emp where job='clerk' ; 

-- 6. Find the average salary for each job type and the number of people employed in each job. 
select job , avg(sal) as avg_salary, count(job) as num_of_jobs from emp group by job;

-- 7. List the employees with the lowest and highest salary. 
select max(sal),min(sal) as maximum_salary from emp ;

-- 8. List full details of departments that don't have any employees. 
select dept.deptno from dept  join emp on dept.deptno not in (select deptno from emp group by deptno) group by dept.deptno;

-- 9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. 
-- Sort the answer by ascending order of name. 
select ename,sal from emp where job = 'analyst' and deptno = 20 group by ename , sal having sal>1200 order by ename;

-- 10. For each department, list its name and number together with the
-- total salary paid to employees in that department. 
select d.dname,d.deptno,sum(e.sal) as 'total salary' from emp e join dept d 
on e.deptno=d.deptno group by d.deptno,d.dname;


-- 11. Find out salary of both MILLER and SMITH.
select ename, sal from emp where ename in('smith','miller');

-- 12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 
-- [] does not work in MYSQL.
select * from emp where ename like '[AM]%';

-- 13. Compute yearly salary of SMITH. 
select ename,12*sal as annual_sal from emp where ename = 'smith';

-- 14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 
select ename ,sal from emp where sal not between 1500 and 2850;

/*------------------ASSESMENT 2---------------------*/

-- 1. Retrieve a list of MANAGERS. 
select e1.ename from emp e1 inner join emp e2 on e1.empno = e2.mgr_id group by e1.ename;

-- 2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename , sal from emp where sal>1000;

-- 3. Display the names and salaries of all employees except JAMES. 
select ename , sal from emp where ename <> 'james';

-- 4. Find out the details of employees whose names begin with ‘S’. 
select * from emp where ename like 's%';

-- 5. Find out the names of all employees that have ‘A’ anywhere in their name.
select ename from emp where ename like '%a%' ;

-- 6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select ename from emp where ename like '__l%' ;

-- 7. Compute daily salary of JONES. 
select ename ,(sal/30) as daily_sal from emp where ename = 'jones' ;

-- 8. Calculate the total monthly salary of all employees. 
select sum(sal) from emp ;

-- 9. Print the average annual salary . 
select (12* sal)/count(empno) as avg_annual_sal from emp ;

-- 10. Select the name, job, salary, department number of all employees except 
-- SALESMAN from department number 30.
select ename ,job,sal,deptno from emp where job <> 'salesman' or deptno = 30 ;

-- 11. List unique departments of the EMP table. 
select distinct(dname) from dept join emp on dept.deptno = emp.deptno  ;

-- 12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
-- Label the columns Employee and Monthly Salary respectively.
select ename , sal from emp where sal>1500 and deptno in (10,30) ;

-- 13. Display the name, job, and salary of all the employees whose job is MANAGER or 
-- ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename , job , sal from emp where job in ('manager','analyst') and sal not in (1000,3000,5000) ;

-- 14. Display the name, salary and commission for all employees whose commission 
-- amount is greater than their salary increased by 10%. 
select ename , sal , comm from emp where comm > (1.1*sal) ;

-- 15. Display the name of all employees who have two Ls in their name and are in 
-- department 30 or their manager is 7782. 
select ename from emp where ename like '%l%l%' and deptno = 30 or mgr_id=7782;

-- 16. Display the names of employees with experience of over 30 years and under 40 yrs.
 -- Count the total number of employees.
 -- (MYSQL) formate
-- select ename from emp where datediff(2023-01-21,hiredate) >30*365 and datediff(2023-01-21,hiredate) <40*365;
-- (SQL) formate
select ename from emp where datediff(yy,hiredate,'2023-01-21')>30 and datediff(yy,hiredate,'2023-01-21')<40;

-- 17. Retrieve the names of departments in ascending order and their employees in 
-- descending order. 
select dept.dname , emp.ename from emp join dept on emp.deptno = dept.deptno order by dname asc,ename desc;

-- 18. Find out experience of MILLER. 
select datediff(curdate(),hiredate) from emp where ename = 'MILLER';

