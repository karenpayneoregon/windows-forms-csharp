
SELECT 
	FORMAT(GETDATE(), 'MM/dd/yyyy') AS 'MM/dd/yyyy',  
	CONVERT(VARCHAR(10), GETDATE(), 103) AS 'dd/MM/yyyy',
	FORMAT(GETDATE(),'MM/dd/yyyy hh:mm:s tt') 'With am/pm',
	CONVERT(varchar, GETDATE(), 22) AS 'Date and Time',
	CONVERT(VARCHAR(10), GETDATE(), 104) AS  German;




