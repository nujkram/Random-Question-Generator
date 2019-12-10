DROP DATABASE IF EXISTS cc5_db;

CREATE DATABASE cc5_db;

CREATE TABLE cc5_db.category(
	id			INT(6) NOT NULL AUTO_INCREMENT,
	name 		VARCHAR(24) NOT NULL,
				PRIMARY KEY(id)
    );
    
CREATE TABLE cc5_db.questions(
	id			INT(6) NOT NULL AUTO_INCREMENT,
    question	VARCHAR(1024) NOT NULL,
    is_active	BOOLEAN DEFAULT True,
    category_id	INT(6) DEFAULT NULL,
				PRIMARY KEY(id),
				FOREIGN KEY(category_id) REFERENCES cc5_db.category(id)
	);
    
INSERT INTO cc5_db.category(name) VALUES
('Easy'),
('Average'),
('Hard');

INSERT INTO cc5_db.questions(question, category_id) VALUES 
('Write a query to display the names (first_name, last_name) using alias name “First Name", "Last Name" from DATABASE northwind TABLE employees.', 1), -- 1
('Write a query to get unique department ID from DATABASE northwind TABLE employees.', 1), -- 2
('Write a query to get all employee details from DATABASE northwind TABLE employees order by first name, descending.', 1), -- 3
('Write a SQL statement to insert a record with your own value into the TABLE countries against each columns. DATABASE northwind TABLE countries Columns: country_id VARCHAR(2), country_name VARCHAR(40), REGION_ID Decimal(10, 0)', 1), -- 4
('Write a SQL statement to insert one row into the table countries against the column country_id and country_name. DATABASE northwind TABLE countries Columns: country_id VARCHAR(2), country_name VARCHAR(40), REGION_ID Decimal(10, 0)', 1), -- 5
('Write a SQL statement to insert 3 rows by a single insert statement. DATABASE northwind TABLE countries Columns: country_id VARCHAR(2), country_name VARCHAR(40), REGION_ID Decimal(10, 0)', 1), -- 6
('Write a query to get the employee ID, names (first_name, last_name), salary in ascending order of salary from DATABASE northwind TABLE employees.', 1), -- 7
('Write a query to get the total salaries payable to employees from DATABASE northwind TABLE employees.', 1), -- 8
('Write a query to get the number of employees working with the company from DATABASE northwind TABLE employees.', 1), -- 9
('Write a query to get the number of jobs available from DATABASE northwind TABLE employees.', 1), -- 10
('Write a query get all first name from DATABASE northwind TABLE employees in upper case.', 1), -- 11
('Write a query to calculate 171*214+625 AS Result.', 1), -- 12
('Write a query to get the names (for example Ellen Abel, Sundar Ande etc.) of all the employees from DATABASE northwind TABLE employees', 1), -- 13
('Write a query to select first 10 records from DATABASE northwind TABLE employees.', 1), -- 14
('Write a query to get all employees working as Programmer from DATABASE northwind TABLE employees.', 1), -- 15
('Write a SQL statement to insert a member. DATABASE library_db TABLE members COLUMN: first_name, middle_name, last_name, street, province, city, zip.', 1), -- 16
('Write a SQL statement to insert a book. DATABASE library_db TABLE books COLUMN: isbn, title, abstract, category_id, publisher_id', 1), -- 17
('Write a SQL statement to insert a category. DATABASE library_db TABLE category COLUMN: name.', 1), -- 18
('Write a SQL statement to insert a publisher. DATABASE library_db TABLE publishers COLUMN: first_name, middle_name, last_name.', 1), -- 19
('Write a SQL statement to insert a author. DATABASE library_db TABLE publishers COLUMN: first_name, middle_name, last_name.', 1), -- 20

-- Average
('Write a query to get the names (first_name, last_name), salary, PF of all the employees (PF is calculated as 15% of salary) from DATABASE northwind TABLE employees.', 2), -- 1
('Write a query to get the average salary and number of employees from DATABASE northwind TABLE employees. ', 2), -- 2
('Write a query to get monthly salary (round 2 decimal places) of each and every employee from DATABASE northwind TABLE employees.', 2), -- 3
('Write a query to get the maximum and minimum salary from DATABASE northwind TABLE employees.', 2), -- 4
('Write a query to display the name (first_name, last_name) and department ID of all employees in departments 30 or 100 in ascending order from DATABASE northwind TABLE employees.', 2), -- 5
('Write a query to display the first_name of all employees who have both "b" and "c" in their first name from DATABASE northwind TABLE employees.', 2), -- 6
('Write a query to display the last name of employees whose names have exactly 6 characters from DATABASE northwind TABLE employees.', 2), -- 7
('Write a query to display the last name of employees having "e" as the third character. from DATABASE northwind TABLE employees.', 2), -- 8
('Write a query to select all record from employees where last name in "BLAKE", "SCOTT", "KING" and "FORD" from DATABASE northwind TABLE employees.', 2), -- 9
('Write a query to get the minimum salary from DATABASE northwind TABLE employees.', 2), -- 10
('Write a query to get the maximum salary of an employee working as a Programmer from DATABASE northwind TABLE employees.', 2), -- 11
('Write a query to get the average salary and number of employees working the department 90 from DATABASE northwind TABLE employees.', 2), -- 12
('Write a query to get the highest, lowest, sum, and average salary of all employees from DATABASE northwind TABLE employees.', 2), -- 13
('Write a query to display the isbn, title and category name of all book from DATABASE library_db TABLE books.', 2), -- 14
('Write a query to display the first name and last name of the authors of book "Database Management System" from DATABASE library_db TABLE book_authors and authors.', 2), -- 15

-- Hard
('Write a query to display the name (first_name, last_name) and salary for all employees whose salary is not in the range $10,000 through $15,000 and are in department 30 or 100 from DATABASE northwind TABLE employees.', 3), -- 1
('Write a query to display the name (first_name, last_name) and hire date for all employees who were hired in 1987 from DATABASE northwind TABLE employees.', 3), -- 2
('Write a query to display the last name, job, and salary for all employees whose job is that of a Programmer or a Shipping Clerk, and whose salary is not equal to $4,500, $10,000, or $15,000 from DATABASE northwind TABLE employees.', 3), -- 3
('Write a query to find the name (first_name, last name), department ID and department name of all the employees from DATABASE northwind TABLE employees and departments.', 3), -- 4
('Write a query to find the name (first_name, last_name), job, department ID and name of the employees who works in London from DATABASE northwind TABLE employees, departments and locations.', 3), -- 5
('Write a query to find the employee id, name (last_name) along with their manager_id and name (last_name) from DATABASE northwind TABLE employees.', 3), -- 6
('Write a query to find the name (first_name, last_name) and hire date of the employees who was hired after "Jones" from DATABASE northwind TABLE employees.', 3), -- 7
('Write a query to get the department name and number of employees in the department from DATABASE northwind TABLE employees and departments.', 3), -- 8
('Write a query to display the department ID and name and first name of manager from DATABASE northwind TABLE employees and departments.', 3), -- 9
('Write a query to display the department name, manager name, and city from DATABASE northwind TABLE employees, departments and locations.', 3), -- 10
('Write a query to display the job history that were done by any employee who is currently drawing more than 10000 of salary from DATABASE northwind TABLE employees and job_history.', 3), -- 11
('Write a query to diplay the isbn, title, category name and publisher first name and last name as Full Name from DATABASE library_db TABLE books, category and publishers.', 3), -- 12
('Write a query to display the first name and last name of the authors of book "Database Management System" from DATABASE library_db TABLE book_authors and authors.', 3), -- 13
('Write a SQL statement to update the admin password to "N3wPassWord" (must be encrypted) from DATABASE library_db TABLE accounts.', 3) -- 14




