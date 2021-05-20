CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAdress nvarchar(200),
	@CellphoneNumber varchar(20),
	@id int = 0 output

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[People] (FirstName, LastName, EmailAdress, CellphoneNumber)
	VALUES (@FirstName, @LastName, @EmailAdress, @CellphoneNumber)

	SELECT @id = SCOPE_IDENTITY();
END
GO
