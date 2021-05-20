CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT p.*
	FROM [dbo].[TeamMembers] p
	INNER JOIN [dbo].[Teams] t ON p.TeamId = t.Id
	WHERE p.TeamId = @TeamId
END
