CREATE PROCEDURE [dbo].[spTeams_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT t.*
	FROM [dbo].[Teams] t
	INNER JOIN [dbo].[TournamentEntries] e ON t.id = e.TeamId
	WHERE e.TournamentId = @TournamentId
END
