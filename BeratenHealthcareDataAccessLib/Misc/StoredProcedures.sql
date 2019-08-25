DROP PROCEDURE IF EXISTS [dbo].[GetNextClientNumber]
DROP PROCEDURE IF EXISTS [dbo].[GetNextCaseNumber]
GO

CREATE PROCEDURE [dbo].[GetNextClientNumber]
@p nvarchar(100) output
AS
BEGIN
	DECLARE  @NextNum int
	DECLARE  @NextCode nvarchar(100)
	Select @NextNum = Max(Right(MedicalRecordNumber,5))  From Clients 
	IF @NextNum is null 
		SET @NextCode = Right(Year(getDate()),2) + '-' + Format(Month(getdate()),'00') + '-MR000001'

	ELSE
		SET @NextCode = Right(Year(getDate()),2) + '-' + Format(Month(getdate()),'00') + '-MR' +  REPLICATE('0',6 - len(@NextNum + 1)) + CONVERT(VARCHAR,@NextNum +1)

		SELECT @p =  @NextCode;  
	END
GO

CREATE PROCEDURE [dbo].[GetNextCaseNumber]
@p nvarchar(100) output
AS
BEGIN
	DECLARE  @NextNum int
	DECLARE  @NextCode nvarchar(100)
	Select @NextNum = Max(Right(CaseNumber,4))  From CaseIntakes Where Left(CaseNumber,7)  = Format(Year(getdate()),'0000') + '-' + Format(Month(getdate()),'00')
	IF @NextNum is null 
		SET @NextCode = Format(Year(getdate()),'0000') + '-' + Format(Month(getdate()),'00') + '-C0001'
	ELSE
		SET @NextCode = Format(Year(getdate()),'0000') + '-' + Format(Month(getdate()),'00') + '-C' + REPLICATE('0',4 - len(@NextNum + 1)) + CONVERT(VARCHAR,@NextNum +1) 

		SELECT @p =  @NextCode;  
	END
GO