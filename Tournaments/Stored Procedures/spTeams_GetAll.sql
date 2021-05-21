CREATE PROCEDURE [dbo].[spTeams_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Teams];
END
GO
