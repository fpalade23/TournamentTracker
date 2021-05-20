CREATE PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT e.*
	FROM [dbo].[MatchupEntries] e
	INNER JOIN [dbo].[Matchups] m ON e.MatchupId = m.id
	WHERE m.Id = @MatchupId
END
