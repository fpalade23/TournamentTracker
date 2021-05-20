CREATE PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT p.*
	FROM [dbo].[Teams] p
	INNER JOIN [dbo].[TournamentEntries] t ON p.id = t.TeamId
	WHERE t.TournamentId = @TournamentId
END
