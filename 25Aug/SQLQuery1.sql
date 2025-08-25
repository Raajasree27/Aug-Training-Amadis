create table student(Name varchar(20),regno Int);
insert into student(Name,regno) values('Raaja',101);
select * from student;



-- Create the Employees table
CREATE TABLE Employees (
    employeeID INT PRIMARY KEY Identity(1,1),
    firstName VARCHAR(50),
    lastName VARCHAR(50),
    salary DECIMAL(10, 2),
    department VARCHAR(50),
    email VARCHAR(100)
);

-- Insert 10 sample employee records
INSERT INTO Employees (firstName, lastName, salary, department, email) VALUES
('Alice', 'Johnson', 75000.00, 'Engineering', 'alice.johnson@example.com'),
('Bob', 'Smith', 68000.00, 'Marketing', 'bob.smith@example.com'),
('Carol', 'Anderson', 82000.00, 'Engineering', 'carol.anderson@example.com'),
('David', 'Lee', 60000.00, 'Sales', 'david.lee@example.com'),
('Eva', 'Martinez', 90000.00, 'Finance', 'eva.martinez@example.com'),
('Frank', 'Wright', 72000.00, 'IT', 'frank.wright@example.com'),
('Grace', 'Kim', 67000.00, 'Human Resources', 'grace.kim@example.com'),
('Henry', 'Brown', 88000.00, 'Engineering', 'henry.brown@example.com'),
('Ivy', 'Wilson', 59000.00, 'Sales', 'ivy.wilson@example.com'),
('Jack', 'Davis', 94000.00, 'Finance', 'jack.davis@example.com');

select * from Employees;

ALTER TABLE Employees
ADD JoiningDate DATE;

UPDATE Employees SET JoiningDate = '2015-06-01' WHERE employeeID = 1;
UPDATE Employees SET JoiningDate = '2018-03-15' WHERE employeeID = 2;
UPDATE Employees SET JoiningDate = '2012-11-10' WHERE employeeID = 3;
UPDATE Employees SET JoiningDate = '2020-01-25' WHERE employeeID = 4;
UPDATE Employees SET JoiningDate = '2010-09-01' WHERE employeeID = 5;
UPDATE Employees SET JoiningDate = '2017-05-18' WHERE employeeID = 6;
UPDATE Employees SET JoiningDate = '2016-07-04' WHERE employeeID = 7;
UPDATE Employees SET JoiningDate = '2013-02-20' WHERE employeeID = 8;
UPDATE Employees SET JoiningDate = '2019-08-12' WHERE employeeID = 9;
UPDATE Employees SET JoiningDate = '2008-12-30' WHERE employeeID = 10;


 


create function dbo.fn_GetDetails()
returns @Results Table
(
    employeeId int,
    firstName varchar(20),
    salary decimal(10,2),
    status varchar(20)
)
as
begin
    insert into @Results(employeeId,firstName,salary,status)
    select employeeId, FirstName, salary,
        case
            when salary<20000 then 'low'
            when salary between 20001 and 70000 then 'Medium'
            else 'High'
        end as status
    from employees;
    return;
end;

DROP FUNCTION IF EXISTS dbo.fn_GetDetails;


SELECT e.FirstName,e.LastName, e.Salary, g.status
FROM Employees e
JOIN  dbo.fn_GetDetails()  g ON e.EmployeeID = g.EmployeeID;


CREATE PROCEDURE usp_TransferMoney
    @FromAcc INT,
    @ToAcc INT,
    @Amount DECIMAL(10,2)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Step 1: Check if source account has enough balance
        IF (SELECT Balance FROM Accounts WHERE AccountID = @FromAcc) < @Amount
        BEGIN
            THROW 50001, 'Insufficient Balance in Source Account.', 1;
        END

        -- Step 2: Deduct from source account
        UPDATE Accounts
        SET Balance = Balance - @Amount
        WHERE AccountID = @FromAcc;

        -- Step 3: Create a SAVEPOINT before adding to destination
        SAVE TRANSACTION BeforeCredit;

        -- Step 4: Add to destination account
        UPDATE Accounts
        SET Balance = Balance + @Amount
        WHERE AccountID = @ToAcc;

        -- Optional: Introduce artificial error (uncomment to test rollback)
        -- UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountID = 99;

        COMMIT TRANSACTION;
        PRINT 'Transfer Completed Successfully!';
    END TRY
    BEGIN CATCH
        -- Rollback to savepoint if available, otherwise rollback full transaction
        IF XACT_STATE() <> 0
        BEGIN
            ROLLBACK TRANSACTION;
        END
        PRINT 'Transaction Failed: ' + ERROR_MESSAGE();
    END CATCH
END;



CREATE TABLE Accounts (
    accountID INT PRIMARY KEY,
    accountHolderName VARCHAR(100),
    balance DECIMAL(10, 2)
);


INSERT INTO Accounts (accountID, accountHolderName, balance) VALUES
(1, 'Alice Johnson', 5000.00),
(2, 'Bob Smith', 12000.50),
(3, 'Carol Anderson', 300.00),
(4, 'David Lee', 4500.75),
(5, 'Eva Martinez', 9800.00),
(6, 'Frank Wright', 20000.00),
(7, 'Grace Kim', 100.00),
(8, 'Henry Brown', 7500.00),
(9, 'Ivy Wilson', 1500.25),
(10, 'Jack Davis', 6000.00);


select * from accounts;

