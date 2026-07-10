USE EmployeeManagementSystem;
GO

CREATE OR ALTER PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO
EXEC sp_GetEmployeesByDepartment 5;
USE EmployeeManagementSystem;
GO

PRINT '===== Employees Table =====';

SELECT
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
FROM Employees;

PRINT '===== Stored Procedure Output (DepartmentID = 3) =====';

EXEC sp_GetEmployeesByDepartment 3;