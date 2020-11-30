Create Database HRM
go

Use HRM
go

Create Table Account
(
	Username nvarchar(20) Primary Key not null,
	DisplayName NVARCHAR(100) NOT NULL,
	Password nvarchar(100) not null,
	Acctype int not null,
)
Create Table Department
(
	DepId int identity Primary Key,
	DepName nvarchar(20) not null
)

Create Table Position
(
	PosId int identity Primary Key,
	PosName nvarchar(20) not null,
	DeId int,
	FOREIGN KEY (Deid) REFERENCES Department(DepId)
)

Create Table Employee
(
	EmpId varchar(10) Primary Key not null,
	Image nvarchar(max) null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	Email varchar(20) null,
	Gender nvarchar(5) not null,
	Address nvarchar(max) not null,
	Religion varchar(50) null,
	City varchar(50) null,
	State varchar(50) null,
	Dob date not null,
	Nationality varchar(50) null,
	Maritalstatus varchar(50) not null,
	Phone varchar(50) not null,
	Highschool varchar(100) null,
	University varchar(100) null,
	College varchar(100) null,
	
	DepaName varchar(50) not null,
	PosiName varchar(50) not null,
	PosiId int not null,	
	FOREIGN KEY (PosiId) REFERENCES Position(PosId)
)

Create Table Salary
(
	SalId int identity Primary Key,
	EmpId nvarchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	DepaName varchar(50) not null,
	PosiName varchar(50) not null,
	SalBase int default 0,
	AllType varchar(50),
	Allamount int,
	SalFomula nvarchar(max) default 'empty',
	AllowanceId int	
)


Create Table Allowance
(
	AllId int Primary Key,
	AllName nvarchar(20) not null,
	AllTax int,
	Amount int,
	AllFormulaName nvarchar(200),
	AllFormula nvarchar(100),
	Result int default 0
)

Create Table AllowanceFormula
(
	FormulaId int Primary Key,
	FormulaName nvarchar(200) not null,
	Formula nvarchar(100)
)

Create Table SalaryFormula
(
	SformulaId int Primary Key,
	SformulaName nvarchar(200) not null,
	SformulaDes nvarchar(100),
	Sformula nvarchar(100)
)



Create Table Adjustment
(
	AdjustmentId int Primary Key,
	AdjustmentType nvarchar(50) not null,
	AdjustmentDes nvarchar(100) not null,
	AdjustmentAmount int default 0
)

Create Table SalaryAdjustment
(
	EmpId varchar(10) Primary Key,
	EmpName varchar(50) not null,
	AdjustmentType nvarchar(50) not null,
	AdjustmentAmount int default 0,
	SalaryPercent int default 0,
	ApplytoMonth int,
	AdjustmentYear int,
	Description varchar(100),	 
)

Create Table WorkShift
(
	ShiftId int Primary Key,
	ShiftName nvarchar(200) not null,	
	colorId nvarchar(200) not null,
)

Create Table ShiftSchedule
(
	ScheduleId int identity Primary Key,
	Days varchar(20) not null,
	OTBeforeFrom time default '00:00:00' not null,
	OTBeforeTo time default '00:00:00' not null,
	ClockIn time default '00:00:00' not null,
	ClockOut time default '00:00:00' not null,
	StartBreak time default '00:00:00' not null,
	EndBreak time default '00:00:00' not null,
	OTAfterFrom time default '00:00:00' not null,
	OTAfterTo time default '00:00:00' not null,
	ShiftId int,
	ShiftName varchar(20) not null,

	FOREIGN KEY (ShiftId) REFERENCES WorkShift(ShiftId)	
)

Create Table Timekeeping
(
	TKid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	ShiftName nvarchar(20) not null,
	Workday date not null,	
	DateIn date not null,
	ClockIn time default null,
	DateOut date not null,	
	ClockOut time default null,
	AbsenceTypes varchar(20) default null,
	Status varchar(20),		
)

Create Table ShiftEmployee
(
	SEid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	ShiftName nvarchar(20) not null,
	DateStart date not null,
	DateEnd date not null,
	ShiftId int not null,

	FOREIGN KEY (ShiftId) REFERENCES WorkShift(ShiftId)	
)

Create Table EarlyAndLate
(
	ELid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	ShiftName nvarchar(20) not null,
	Workday date not null,
	ClockIn time not null,
	ClockOut time not null,
	LateIn int not null default 0,
	ConfirmedLateIn int not null default 0,
	EarlyOut int not null default 0,
	ConfirmedEarlyOut int not null default 0			
)

Create Table Overtime
(
	OTid int identity Primary Key,
	EmpId varchar(20) not null,
	FullName nvarchar(20) not null,	
	ShiftName nvarchar(20) not null,
	Workday date not null,
	OvertimeType varchar(20) not null default 'empty',
	OvertimeValue int not null default 0,
	OvertimeFrom time not null default '00:00:00',
	OvertimeTo time not null default '00:00:00',
	OvertimeHours int not null default 0,
	ConfirmedHours int not null default 0,				
)

Create Table OvertimeType
(
	Typeid int identity Primary Key,
	OvertimeType varchar(20) not null,
	Value  int not null				
)

Create Table PersonalSummary
(
	ptid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	BaseSalary int not null,
	Attendance int not null default 0,
	Absence int not null default 0,
	SalaryFormula nvarchar(50) not null, 
	Month int	not null,
	Year int not null
)

Create Table OvertimeSummary
(
	osid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	OvertimeType nvarchar(20) not null,
	OvertimeHours int null,
	BaseSalary int not null,
	Amount int not null,
	Month int not null,
	Year int not null		
)

Create Table AllowanceSummary
(
	asid int identity Primary Key,
	EmpId varchar(20) not null,
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null,
	AllowanceType nvarchar(20) not null,
	AllowanceAmount int null,
	AllFormula nvarchar(30) not null,	
	Month int not null,
	Year int not null		
)

exec USP_LoadAllSummary 'ds2', '11', '2020', '2020-11-01' , '2020-11-30'  

drop procedure USP_LoadOTSummary


CREATE PROC USP_LoadAllSummary
@empid as varchar(30), @month as int, @year as int 
AS
BEGIN
	SELECT  asid, EmpId,
	CONCAT(FirstName, ' ', LastName) AS 'Fullname', 
	AllowanceType, AllowanceAmount, AllFormula, Month, Year
	FROM AllowanceSummary WHERE EmpId = @empid and Month = @month and Year = @year
END
GO

CREATE PROC USP_CountOT
@type AS varchar(30)
AS
BEGIN
	SELECT SUM(ConfirmedHours)
	FROM Overtime
	WHERE OvertimeType = @type;
END
GO

CREATE PROC USP_LoadOTSummary
@empid as varchar(30), @month as int, @year as int 
AS
BEGIN
	SELECT  osid, EmpId,
	CONCAT(FirstName, ' ', LastName) AS 'Fullname', 
	OvertimeType, OvertimeHours, BaseSalary, Amount, Month, Year
	FROM OvertimeSummary WHERE EmpId = @empid and Month = @month and Year = @year
END
GO

CREATE PROC USP_LoadSummary
@empid as varchar(30), @month as int, @year as int 
AS
BEGIN
	SELECT  ptid, EmpId as 'EmployeeId',
	CONCAT(FirstName, ' ', LastName) AS 'Fullname', 
	BaseSalary, Attendance, Absence, SalaryFormula, Month, Year
	FROM PersonalSummary WHERE EmpId = @empid and Month = @month and Year = @year
END
GO

CREATE PROC USP_CountAttAbs
@from AS date, @to  AS date, @empid as varchar(30)
AS
BEGIN
	SELECT count(*) FROM Timekeeping 
	WHERE AbsenceTypes IS NULL and ClockIn IS NOT NULL and ClockOut IS NOT NULL and Status IS NULL and [Workday] >= @from AND [Workday] <= @to and EmpId = @empid
END
GO

CREATE PROC USP_CountAbsence
@from AS date, @to  AS date, @empid as varchar(30)
AS
BEGIN
	SELECT count(*) FROM Timekeeping 
	WHERE Status IS NULL and AbsenceTypes IS NOT NULL or ClockIn IS NULL or ClockOut IS NULL and [Workday] >= @from AND [Workday] <= @to and EmpId = @empid  
END
GO



CREATE PROC USP_LoadSummary
AS
BEGIN
	INSERT INTO PersonalSummary (EmpId, FirstName, LastName, BasicSalary, SalaryFormula)
	SELECT  EmpId, FirstName, LastName, SalBase, SalFomula
	FROM    Salary
END
GO

CREATE PROC USP_LoadEarlyAndLate
@from AS date, @to  AS date
AS
BEGIN
	INSERT INTO EarlyAndLate (EmpId, FirstName, LastName, ShiftName, Workday, ClockIn, ClockOut)
	SELECT  EmpId, FirstName, LastName, ShiftName, Workday, ClockIn, ClockOut
	FROM    Timekeeping where [Workday] >= @from AND [Workday] <= @to
END
GO

CREATE PROC USP_LoadOvertime
@from AS date, @to  AS date
AS
BEGIN
	INSERT INTO Overtime (EmpId, FirstName, LastName, ShiftName, Workday, OvertimeTo)
	SELECT  EmpId, FirstName, LastName, ShiftName, Workday, ClockOut
	FROM    Timekeeping where [Workday] >= @from AND [Workday] <= @to
END
GO

CREATE PROC USP_FilteredOvertime
@from AS date, @to  AS date
AS
BEGIN
	SELECT  *
	FROM Overtime where [Workday] >= @from AND [Workday] <= @to
END
GO

CREATE PROC USP_DeleteOvertime
@from AS date, @to  AS date
AS
BEGIN
	DELETE FROM Overtime
	WHERE [Workday] >= @from AND [Workday] <= @to
END
GO

CREATE PROC USP_FilteredEarlyAndLate
@from AS date, @to  AS date
AS
BEGIN
	SELECT  *
	FROM EarlyAndLate where [Workday] >= @from AND [Workday] <= @to
END
GO
 
CREATE PROC USP_DeleteEarlyAndLate
@from AS date, @to  AS date
AS
BEGIN
	DELETE FROM EarlyAndLate
	WHERE [Workday] >= @from AND [Workday] <= @to
END
GO

CREATE PROC USP_LoadSalaryAdjustment
AS
BEGIN
	SELECT  EmpId as 'Employee Id', EmpName as 'Employee Name', AdjustmentType as 'Adjustment Type', ApplytoMonth, AdjustmentYear,
	CONCAT(ApplytoMonth, ' - ', AdjustmentYear) AS 'Apply to Month', 
	AdjustmentAmount as 'Amount', SalaryPercent as 'Salary percentage', Description  
	FROM SalaryAdjustment
END
GO

CREATE PROC USP_LoadTimekeeping

AS
BEGIN
	SELECT  TKid, EmpId as 'EmployeeId',
	CONCAT(FirstName, ' ', LastName) AS 'Fullname', 
	ShiftName, Workday, DateIn, ClockIn, DateOut, ClockOut,  AbsenceTypes, Status
	FROM Timekeeping
END
GO

CREATE PROC USP_FilteredTimekeepingByDate
@from AS date, @to  AS date
AS
BEGIN
	SELECT  TKid, EmpId as 'EmployeeId',
	CONCAT(FirstName, ' ', LastName) AS 'Fullname', 
	ShiftName, Workday, DateIn, ClockIn, DateOut, ClockOut,  AbsenceTypes, Status
	FROM Timekeeping where [Workday] >= @from AND [Workday] <= @to
END
GO




CREATE PROC USP_LoadSalary
AS
BEGIN
	INSERT INTO Salary (EmpId, FirstName, LastName, DepaName, PosiName, AllType, Allamount, AllowanceId)
	SELECT  EmpId, FirstName, LastName, DepaName, PosiName, AllName, Amount, Allid
	FROM    Allowance, Employee
END
GO


CREATE PROC USP_Upadate_SalaryAllowance
AS
BEGIN
	UPDATE Salary 
	SET AllType=(SELECT AllName FROM Allowance WHERE Salary.AllowanceId=Allowance.Allid);
END
GO

CREATE PROC USP_PivotSalary
AS
BEGIN
	DECLARE @cols AS NVARCHAR(MAX), @query  AS NVARCHAR(MAX);
	SET @cols = STUFF((SELECT distinct ',' + QUOTENAME(c.AllType) 
				FROM dbo.Salary c
				FOR XML PATH(''), TYPE
				).value('.', 'NVARCHAR(MAX)') 
			,1,1,'')
 
	set @query = 'SELECT EmpId, FirstName, LastName, DepaName as "Department name", PosiName as "Position name", SalBase as "Base salary", SalFomula as "Salary formula", ' + @cols + ' from 
				(
					select EmpId, FirstName, LastName, DepaName, PosiName, SalBase, SalFomula, AllType, Allamount
					from Salary
			   ) x
				pivot 
				(
					 sum(Allamount)
					FOR AllType IN (' + @cols + ')
				) p '
	execute(@query)
END
GO

CREATE PROC USP_SeacrhSalaryByEmpName
(
@id nvarchar(20)
)
AS
BEGIN
	DECLARE @cols NVARCHAR(MAX), @query NVARCHAR(MAX);
	SET @cols = STUFF((SELECT distinct ',' + QUOTENAME(c.AllType) 
				FROM dbo.Salary c
				FOR XML PATH(''), TYPE
				).value('.', 'NVARCHAR(MAX)') 
			,1,1,'');
 
	set @query = N'SELECT EmpId, FirstName, LastName, DepaName as "Department name", PosiName as "Position name", SalBase as "Base salary", SalFomula as "Salary formula", ' + @cols + ' from 
				(
					select EmpId, FirstName, LastName, DepaName, PosiName, SalBase, SalFomula, AllType, Allamount
					from Salary where EmpId LIKE ''%'' + @id + ''%''
			   ) x
				pivot 
				(
					 sum(Allamount)
					FOR AllType IN (' + @cols + ')
				) p ';
	execute sp_executesql @query, N'@id nvarchar(20)', @id;
END
GO

CREATE PROC USP_SeacrhSalaryByDepaName
(
@depart nvarchar(20)
)
AS
BEGIN
	DECLARE @cols NVARCHAR(MAX), @query NVARCHAR(MAX);
	SET @cols = STUFF((SELECT distinct ',' + QUOTENAME(c.AllType) 
				FROM dbo.Salary c
				FOR XML PATH(''), TYPE
				).value('.', 'NVARCHAR(MAX)') 
			,1,1,'');
 
	set @query = N'SELECT EmpId, FirstName, LastName, DepaName as "Department name", PosiName as "Position name", SalBase as "Base salary", SalFomula as "Salary formula", ' + @cols + ' from 
				(
					select EmpId, FirstName, LastName, DepaName, PosiName, SalBase, SalFomula, AllType, Allamount
					from Salary where DepaName LIKE ''%'' + @depart + ''%''
			   ) x
				pivot 
				(
					 sum(Allamount)
					FOR AllType IN (' + @cols + ')
				) p ';
	execute sp_executesql @query, N'@depart nvarchar(20)', @depart;
END
GO

CREATE PROC USP_SeacrhSalaryByPosiName
(
@posi nvarchar(20)
)
AS
BEGIN
	DECLARE @cols NVARCHAR(MAX), @query NVARCHAR(MAX);
	SET @cols = STUFF((SELECT distinct ',' + QUOTENAME(c.AllType) 
				FROM dbo.Salary c
				FOR XML PATH(''), TYPE
				).value('.', 'NVARCHAR(MAX)') 
			,1,1,'');
 
	set @query = N'SELECT EmpId, FirstName, LastName, DepaName as "Department name", PosiName as "Position name", SalBase as "Base salary", SalFomula as "Salary formula", ' + @cols + ' from 
				(
					select EmpId, FirstName, LastName, DepaName, PosiName, SalBase, SalFomula, AllType, Allamount
					from Salary where PosiName LIKE ''%'' + @posi + ''%''
			   ) x
				pivot 
				(
					 sum(Allamount)
					FOR AllType IN (' + @cols + ')
				) p ';
	execute sp_executesql @query, N'@posi nvarchar(20)', @posi;
END
GO



IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[USP_Upadate_SalaryAllowance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE USP_CountAbsence
GO

CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO


CREATE PROC USP_GetAccount
@Username nvarchar(20)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = @Username
END
GO


CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO


