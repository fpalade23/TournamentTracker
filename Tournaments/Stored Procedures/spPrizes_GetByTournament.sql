CREATE PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT p.*
	FROM [dbo].[Prizes] p
	INNER JOIN [dbo].[TournamentPrizes] t ON p.id = t.PrizeId
	WHERE t.TournamentId = @TournamentId
END