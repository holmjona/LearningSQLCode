
CREATE PROCEDURE sprocPeopleGetAll
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM People
	--SET NOCOUNT OFF
END
GO

CREATE PROCEDURE sprocPersonGet
@PersonID int
AS
BEGIN
	SET NOCOUNT ON
	SELECT * FROM People WHERE PersonID = @PersonID
END
GO

ALTER PROCEDURE sproc_PersonAdd
	@PersonID int OUTPUT
	,@FirstName nvarchar(40)
	,@LastName nvarchar(40)
	,@DateOfBirth datetime
	,@IsManager bit 
	,@Prefix nvarchar(6)
	,@Postfix nvarchar(8)
	,@Phone nvarchar(15) 
	,@Email nvarchar(250)
	,@Homepage nvarchar(400)
AS
BEGIN
	INSERT INTO People (FirstName,LastName,DateOfBirth,IsManager,Prefix,Postfix,Phone,Email,Homepage)
		VALUES (@FirstName,@LastName,@DateOfBirth,@IsManager,@Prefix,@Postfix,@Phone,@Email,@Homepage)
		SET @PersonID = @@IDENTITY
END
GO


-------------------Person-----------------
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Add a new  Person to the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_PersonAdd
@PersonID int OUTPUT,
@FirstName nvarchar(40),
@LastName nvarchar(40),
@DateOfBirth datetime,
@IsManager bit,
@Prefix nvarchar(6),
@Postfix nvarchar(8),
@Phone nvarchar(15),
@Email nvarchar(250),
@Homepage nvarchar(400)
AS
     INSERT INTO People(FirstName,LastName,DateOfBirth,IsManager,Prefix,Postfix,Phone,Email,Homepage)
               VALUES(@FirstName,@LastName,@DateOfBirth,@IsManager,
               @Prefix,@Postfix,@Phone,@Email,@Homepage)
               
     SET @PersonID = @@IDENTITY
GO

GRANT EXECUTE ON dbo.sproc_PersonAdd TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Update Person in the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_PersonUpdate
@PersonID int,
@FirstName nvarchar(40),
@LastName nvarchar(40),
@DateOfBirth datetime,
@IsManager bit,
@Prefix nvarchar(6),
@Postfix nvarchar(8),
@Phone nvarchar(15),
@Email nvarchar(250),
@Homepage nvarchar(400)
AS
     UPDATE People
          SET
               FirstName = @FirstName,
               LastName = @LastName,
               DateOfBirth = @DateOfBirth,
               IsManager = @IsManager,
               Prefix = @Prefix,
               Postfix = @Postfix,
               Phone = @Phone,
               Email = @Email,
               Homepage = @Homepage
          WHERE PersonID = @PersonID
GO

GRANT EXECUTE ON dbo.sproc_PersonUpdate TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve specific Person from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocPersonGet
@PersonID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM People
     WHERE PersonID = @PersonID
END
GO

GRANT EXECUTE ON dbo.sprocPersonGet TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all People from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocPeopleGetAll
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM People
END
GO

GRANT EXECUTE ON dbo.sprocPeoplesGetAll TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Remove specific Person from the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_PersonRemove
@PersonID int
AS
BEGIN
     DELETE FROM People
          WHERE PersonID = @PersonID

     -- Return -1 if we had an error
     IF @@ERROR > 0
     BEGIN
          RETURN -1
     END
     ELSE
     BEGIN
          RETURN 1
     END
END
GO

GRANT EXECUTE ON dbo.sproc_PersonRemove TO sqlEditor
GO
-------------------ProjectType-----------------
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Add a new  ProjectType to the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectTypeAdd
@ProjectTypeID int OUTPUT,
@Name nvarchar(200)
AS
     INSERT INTO ProjectTypes(Name)
               VALUES(@Name)
     SET @ProjectTypeID = @@IDENTITY
GO

GRANT EXECUTE ON dbo.sproc_ProjectTypeAdd TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Update ProjectType in the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectTypeUpdate
@ProjectTypeID int,
@Name nvarchar(200)
AS
     UPDATE ProjectTypes
          SET
               Name = @Name
          WHERE ProjectTypeID = @ProjectTypeID
GO

GRANT EXECUTE ON dbo.sproc_ProjectTypeUpdate TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve specific ProjectType from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectTypeGet
@ProjectTypeID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectTypes
     WHERE ProjectTypeID = @ProjectTypeID
END
GO

GRANT EXECUTE ON dbo.sprocProjectTypeGet TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all ProjectTypes from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectTypesGetAll
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectTypes
END
GO

GRANT EXECUTE ON dbo.sprocProjectTypesGetAll TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Remove specific ProjectType from the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectTypeRemove
@ProjectTypeID int
AS
BEGIN
     DELETE FROM ProjectTypes
          WHERE ProjectTypeID = @ProjectTypeID

     -- Return -1 if we had an error
     IF @@ERROR > 0
     BEGIN
          RETURN -1
     END
     ELSE
     BEGIN
          RETURN 1
     END
END
GO

GRANT EXECUTE ON dbo.sproc_ProjectTypeRemove TO sqlEditor
GO
-------------------Project-----------------
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Add a new  Project to the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectAdd
@ProjectID int OUTPUT,
@Name nvarchar(200),
@ProjectTypeID int,
@DateStarted datetime,
@DateEnded datetime
AS
     INSERT INTO Projects(Name,ProjectTypeID,DateStarted,DateEnded)
               VALUES(@Name,@ProjectTypeID,@DateStarted,@DateEnded)
               
     SET @ProjectID = @@IDENTITY
GO

GRANT EXECUTE ON dbo.sproc_ProjectAdd TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Update Project in the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectUpdate
@ProjectID int,
@Name nvarchar(200),
@ProjectTypeID int,
@DateStarted datetime,
@DateEnded datetime
AS
     UPDATE Projects
          SET
               Name = @Name,
               ProjectTypeID = @ProjectTypeID,
               DateStarted = @DateStarted,
               DateEnded = @DateEnded
          WHERE ProjectID = @ProjectID
GO

GRANT EXECUTE ON dbo.sproc_ProjectUpdate TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve specific Project from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectGet
@ProjectID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM Projects
     WHERE ProjectID = @ProjectID
END
GO

GRANT EXECUTE ON dbo.sprocProjectGet TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all Projects from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectsGetAll
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM Projects
END
GO

GRANT EXECUTE ON dbo.sprocProjectsGetAll TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Remove specific Project from the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectRemove
@ProjectID int
AS
BEGIN
     DELETE FROM Projects
          WHERE ProjectID = @ProjectID

     -- Return -1 if we had an error
     IF @@ERROR > 0
     BEGIN
          RETURN -1
     END
     ELSE
     BEGIN
          RETURN 1
     END
END
GO

GRANT EXECUTE ON dbo.sproc_ProjectRemove TO sqlEditor
GO
-------------------ProjectPeople-----------------
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Add a new  ProjectPeople to the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectPeopleAdd
@ProjectPersonID int OUTPUT,
@ProjectID int,
@PersonID int,
@DateAssigned datetime
AS
     INSERT INTO ProjectPeople(ProjectID,PersonID,DateAssigned)
               VALUES(@ProjectID,@PersonID,@DateAssigned)
     SET @ProjectPersonID = @@IDENTITY
	 -- Should also deal with already existing data.
GO

GRANT EXECUTE ON dbo.sproc_ProjectPeopleAdd TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Update ProjectPeople in the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectPeopleUpdate
@ProjectPersonID int,
@ProjectID int,
@PersonID int,
@DateAssigned datetime
AS
     UPDATE ProjectPeople
          SET
               ProjectID = @ProjectID,
               PersonID = @PersonID,
               DateAssigned = @DateAssigned
          WHERE ProjectPersonID = @ProjectPersonID
GO

GRANT EXECUTE ON dbo.sproc_ProjectPeopleUpdate TO sqlEditor
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve specific ProjectPeople from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectPeopleGet
@ProjectPersonID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectPeople
     WHERE ProjectPersonID = @ProjectPersonID
END
GO

GRANT EXECUTE ON dbo.sprocProjectPeopleGet TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all ProjectPeoples from the database.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectPeoplesGetAll
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectPeople
END
GO

GRANT EXECUTE ON dbo.sprocProjectPeoplesGetAll TO sqlReader
GO
-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Remove specific ProjectPeople from the database.
-- =============================================
CREATE PROCEDURE dbo.sproc_ProjectPeopleRemove
@ProjectPersonID int
AS
BEGIN
     DELETE FROM ProjectPeople
          WHERE ProjectPersonID = @ProjectPersonID

     -- Return -1 if we had an error
     IF @@ERROR > 0
     BEGIN
          RETURN -1
     END
     ELSE
     BEGIN
          RETURN 1
     END
END
GO

GRANT EXECUTE ON dbo.sproc_ProjectPeopleRemove TO sqlEditor
GO


-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all ProjectPeople from the database for a given project.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectPeopleGetForProject
@ProjectID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectPeople pp
	 JOIN People p ON pp.PersonID = p.PersonID
END
GO

GRANT EXECUTE ON dbo.sprocProjectPeoplesGetForProject TO sqlReader
GO


-- =============================================
-- Author:		Jon Holmes
-- Create date:	28 Nov 2018
-- Description:	Retrieve all ProjectPeople from the database for a given project.
-- =============================================
CREATE PROCEDURE dbo.sprocProjectPeopleGetForPerson
@PersonID int
AS
BEGIN
     -- SET NOCOUNT ON added to prevent extra result sets from
     -- interfering with SELECT statements.
     SET NOCOUNT ON;

     SELECT * FROM ProjectPeople pp
	 JOIN Projects p ON pp.ProjectID = p.ProjectID
END
GO

GRANT EXECUTE ON dbo.sprocProjectPeoplesGetForPerson TO sqlReader
GO


