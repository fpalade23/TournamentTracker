CREATE PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT p.*
	FROM [dbo].[TeamMembers] m
	INNER JOIN [dbo].[People] p ON m.PersonId = p.Id
	WHERE m.TeamId = @TeamId
END
