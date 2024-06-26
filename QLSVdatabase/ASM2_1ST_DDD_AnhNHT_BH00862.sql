USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 3/28/2024 8:43:38 AM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLSV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLSV]
GO
USE [QLSV]
GO
/****** Object:  Sequence [dbo].[StudentSeq]    Script Date: 3/28/2024 8:43:39 AM ******/
CREATE SEQUENCE [dbo].[StudentSeq] 
 AS [bigint]
 START WITH 1100
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLCourse]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCourse](
	[Course_ID] [int] IDENTITY(1,1) NOT NULL,
	[Teacher_ID] [int] NOT NULL,
	[Subject_ID] [int] NOT NULL,
	[Name_Course] [nvarchar](150) NULL,
 CONSTRAINT [PK_TBLCourse] PRIMARY KEY CLUSTERED 
(
	[Course_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLScore]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLScore](
	[Datecreated] [datetime] NULL,
	[Maker] [varchar](30) NULL,
	[Update_day] [datetime] NULL,
	[Updater] [varchar](30) NULL,
	[Student_ID] [varchar](50) NOT NULL,
	[Course_ID] [int] NOT NULL,
	[First_test_score] [float] NULL,
	[Second_test_score] [float] NULL,
 CONSTRAINT [PK_TBLScore] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Course_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLStudent]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLStudent](
	[Datecreated] [datetime] NULL,
	[Maker] [varchar](30) NULL,
	[Update_day] [datetime] NULL,
	[Updater] [varchar](30) NULL,
	[Student_ID] [varchar](50) NOT NULL,
	[Last_name] [nvarchar](50) NOT NULL,
	[First_name] [nvarchar](50) NOT NULL,
	[Date_of_birth] [date] NULL,
	[Sex] [tinyint] NULL,
	[Home_town] [nvarchar](150) NULL,
	[Address] [nvarchar](150) NULL,
	[Phone_number] [nvarchar](30) NULL,
	[Email] [varchar](150) NULL,
 CONSTRAINT [PK_TBLStudent] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSubject](
	[Datecreated] [datetime] NULL,
	[Maker] [varchar](30) NULL,
	[Update_day] [datetime] NULL,
	[Updater] [varchar](30) NULL,
	[Subject_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_subject] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_TBLSubject] PRIMARY KEY CLUSTERED 
(
	[Subject_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBLTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLTeacher](
	[Datecreated] [datetime] NULL,
	[Maker] [varchar](30) NULL,
	[Update_day] [datetime] NULL,
	[Updater] [varchar](30) NULL,
	[Teacher_ID] [int] IDENTITY(1,1) NOT NULL,
	[Last_name] [nvarchar](50) NOT NULL,
	[First_name] [nvarchar](50) NOT NULL,
	[Sex] [tinyint] NULL,
	[Date_of_birth] [date] NULL,
	[Phone_number] [varchar](30) NULL,
	[Email] [varchar](150) NULL,
 CONSTRAINT [PK_TBLTeacher] PRIMARY KEY CLUSTERED 
(
	[Teacher_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBLScore] ADD  CONSTRAINT [DF_TBLScore_Datecreated]  DEFAULT (getdate()) FOR [Datecreated]
GO
ALTER TABLE [dbo].[TBLScore] ADD  CONSTRAINT [DF_TBLScore_Maker]  DEFAULT ('admin') FOR [Maker]
GO
ALTER TABLE [dbo].[TBLScore] ADD  CONSTRAINT [DF_TBLScore_Update_day]  DEFAULT (getdate()) FOR [Update_day]
GO
ALTER TABLE [dbo].[TBLScore] ADD  CONSTRAINT [DF_TBLScore_Updater]  DEFAULT (getdate()) FOR [Updater]
GO
ALTER TABLE [dbo].[TBLStudent] ADD  CONSTRAINT [DF_TBLStudent_Datecreated]  DEFAULT (getdate()) FOR [Datecreated]
GO
ALTER TABLE [dbo].[TBLStudent] ADD  CONSTRAINT [DF_TBLStudent_Maker]  DEFAULT ('admin') FOR [Maker]
GO
ALTER TABLE [dbo].[TBLStudent] ADD  CONSTRAINT [DF_TBLStudent_Update_day]  DEFAULT (getdate()) FOR [Update_day]
GO
ALTER TABLE [dbo].[TBLStudent] ADD  CONSTRAINT [DF_TBLStudent_Updater]  DEFAULT ('admin') FOR [Updater]
GO
ALTER TABLE [dbo].[TBLSubject] ADD  CONSTRAINT [DF_TBLSubject_Datecreated]  DEFAULT (getdate()) FOR [Datecreated]
GO
ALTER TABLE [dbo].[TBLSubject] ADD  CONSTRAINT [DF_TBLSubject_Maker]  DEFAULT ('admin') FOR [Maker]
GO
ALTER TABLE [dbo].[TBLSubject] ADD  CONSTRAINT [DF_TBLSubject_Update_day]  DEFAULT (getdate()) FOR [Update_day]
GO
ALTER TABLE [dbo].[TBLSubject] ADD  CONSTRAINT [DF_TBLSubject_Updater]  DEFAULT ('admin') FOR [Updater]
GO
ALTER TABLE [dbo].[TBLTeacher] ADD  CONSTRAINT [DF_TBLTeacher_Datecreated]  DEFAULT (getdate()) FOR [Datecreated]
GO
ALTER TABLE [dbo].[TBLTeacher] ADD  CONSTRAINT [DF_TBLTeacher_Maker]  DEFAULT ('admin') FOR [Maker]
GO
ALTER TABLE [dbo].[TBLTeacher] ADD  CONSTRAINT [DF_TBLTeacher_Update_day]  DEFAULT (getdate()) FOR [Update_day]
GO
ALTER TABLE [dbo].[TBLTeacher] ADD  CONSTRAINT [DF_TBLTeacher_Updater]  DEFAULT ('admin') FOR [Updater]
GO
ALTER TABLE [dbo].[TBLCourse]  WITH CHECK ADD  CONSTRAINT [FK_TBLCourse_TBLSubject] FOREIGN KEY([Subject_ID])
REFERENCES [dbo].[TBLSubject] ([Subject_ID])
GO
ALTER TABLE [dbo].[TBLCourse] CHECK CONSTRAINT [FK_TBLCourse_TBLSubject]
GO
ALTER TABLE [dbo].[TBLCourse]  WITH CHECK ADD  CONSTRAINT [FK_TBLCourse_TBLTeacher] FOREIGN KEY([Teacher_ID])
REFERENCES [dbo].[TBLTeacher] ([Teacher_ID])
GO
ALTER TABLE [dbo].[TBLCourse] CHECK CONSTRAINT [FK_TBLCourse_TBLTeacher]
GO
ALTER TABLE [dbo].[TBLScore]  WITH CHECK ADD  CONSTRAINT [FK_TBLScore_TBLCourse] FOREIGN KEY([Course_ID])
REFERENCES [dbo].[TBLCourse] ([Course_ID])
GO
ALTER TABLE [dbo].[TBLScore] CHECK CONSTRAINT [FK_TBLScore_TBLCourse]
GO
ALTER TABLE [dbo].[TBLScore]  WITH CHECK ADD  CONSTRAINT [FK_TBLScore_TBLStudent] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[TBLStudent] ([Student_ID])
GO
ALTER TABLE [dbo].[TBLScore] CHECK CONSTRAINT [FK_TBLScore_TBLStudent]
GO
/****** Object:  StoredProcedure [dbo].[AddnewStudent]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddnewStudent]
		
	@Last_name nvarchar(10),
	@First_name nvarchar(20),
	@Date_of_Birth date,
	@Sex tinyint,
	@Home_town nvarchar(150),
	@Address nvarchar(150),
	@Phone_number varchar(30),
	@Email varchar(150)

AS
BEGIN
	INSERT INTO TBLStudent
	(
		Student_ID,
		Last_name,First_name,
		Date_of_birth,Sex,
		Home_town,Address,
		Phone_number,Email)

	VALUES 
	( 'BH00' + CAST(NEXT VALUE FOR StudentSeq as varchar(30)),
		@Last_name,@First_name,
		@Date_of_Birth,
		@Sex,
		@Home_town,@Address,
		@Phone_number,@Email
	);

	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;

END
GO
/****** Object:  StoredProcedure [dbo].[getListCourse]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getListCourse]
	@keyword nvarchar(30)
AS
BEGIN
	SELECT concat(tt.First_name,' ', tt.Last_name) AS First_name,
	ts.Name_subject, 
	tc.Course_ID, 
	tt.Teacher_ID,
	ts.Subject_ID, 
	tc.Name_Course 
	FROM TBLCourse tc

	LEFT JOIN TBLTeacher tt ON tc.Teacher_ID = tt.Teacher_ID

	LEFT JOIN TBLSubject ts ON tc.Subject_ID = ts.Subject_ID

	WHERE tt.First_name like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(tt.Last_name) like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(tc.Name_Course) like '%' + LOWER(trim(@keyword)) + '%'

END

EXEC [dbo].[getListCourse] @keyword ='Nam';

GO
/****** Object:  StoredProcedure [dbo].[getListScore]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getListScore]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@courseID nvarchar(50),
	@nameCourse nvarchar(150)
AS
BEGIN
	SELECT
	s.Student_ID as studentID ,
	s.Course_ID as courseID , 
	s.First_test_score as firstTestScore , 
	s.Second_test_score as secondTestScore,
	CONCAT(st.Last_name, ' ', st.First_name) AS fullName,
	co.Name_Course as nameCourse
	
	from TBLScore s 
	 LEFT JOIN TBLStudent st ON st.Student_ID = s.Student_ID
	 LEFT JOIN TBLCourse co ON co.Course_ID = s.Course_ID
	 WHERE 
	 LOWER(st.Last_name) like '%' + LOWER(trim(@lastName)) + '%'
	 and LOWER(co.Name_Course) like '%' + LOWER(trim(@nameCourse)) + '%'
	 and LOWER(st.First_name) like '%' + LOWER(trim(@firstName)) + '%'
	 and LOWER(s.Course_ID) like '%' + LOWER(trim(@courseID)) + '%'

	--and (
    --          (@courseID IS NULL) OR
    --         (s.Course_ID = @courseID)
    --      )

	 --lastName = 'NAMabc123' sau khi LOWER lastName = 'namabc123'
	 --@lastName = 'Na' sau khi LOWER thì @lastName ='na'
	 --@lastName2 = 'abc123    ' sau khi trim thì @lastName2 'abc123'

END
GO
/****** Object:  StoredProcedure [dbo].[getListSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getListSubject]
AS
BEGIN
    SELECT Subject_ID, Name_subject FROM TBLSubject
END
GO
/****** Object:  StoredProcedure [dbo].[getListTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getListTeacher]
AS
BEGIN
    SELECT Teacher_ID, First_name FROM [dbo].[TBLTeacher]
END
GO
/****** Object:  StoredProcedure [dbo].[insertCourse]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertCourse]
	@Teacher_ID int,
	@Subject_ID int,
	@Name_Course nvarchar(50)
	
AS
BEGIN
	INSERT INTO TBLCourse
	(
		Teacher_ID,
		Subject_ID,
		Name_Course
	)VALUES(
		@Teacher_ID,
		@Subject_ID,
		@Name_Course
	)
	if @@ROWCOUNT > 0 begin return 1 end 
	else begin return end;
END
GO
/****** Object:  StoredProcedure [dbo].[insertSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertSubject]
	@Maker varchar(30),
	@Name_subject varchar(150)

AS
BEGIN
	INSERT INTO TBLSubject
	(
		Maker,
		Name_subject
	)VALUES
	(
		@Maker,
		@Name_subject
	);

	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;

END
GO
/****** Object:  StoredProcedure [dbo].[InsertTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertTeacher]
	@Maker varchar(30),
	@Last_name nvarchar(10),
	@First_name nvarchar(10),
	@Sex tinyint,
	@Date_of_birth date,
	@Phone_number varchar(30),
	@Email varchar(150)
	

AS
BEGIN
	INSERT INTO TBLTeacher
	(
		Maker,
		Last_name,First_name,
		Sex,Date_of_birth,
		Phone_number,Email
	)Values(
		@Maker,
		@Last_name,@First_name,
		@Sex,@Date_of_birth,
		@Phone_number,@Email
	
	);


	if @@ROWCOUNT > 0 begin return 1 end 
	else begin return end;

END
GO
/****** Object:  StoredProcedure [dbo].[Loginaccount]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Loginaccount]
@Username varchar(50),
@Password varchar(50)
as
begin
		select * from Account

		where Username = @Username
		and Password = @Password;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllStudent]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllStudent] 
	@keyword nvarchar(50)



AS

select  
	Student_ID,
	case 
		when LEN(Last_name) > 0 then	
			CONCAT(Last_name,' ',First_name)
	end as fullname,
	CONVERT(varchar(10),Date_of_birth,103) as Date_of_birth,
	case 
		when sex = 1 then N'Male'
		else N'Female'
	end as sex,
	Home_town,
	Address,
	Phone_number,
	Email
from TBLStudent
where 
	LOWER(Last_name) like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(First_name) like '%' + LOWER(trim(@keyword)) + '%'
	or Phone_number like '%' + LOWER(trim(@keyword)) + '%'
order by Last_name;
GO
/****** Object:  StoredProcedure [dbo].[selectAllSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllSubject]
	@keyword nvarchar(30)
AS
BEGIN
	select 
		Subject_ID,
		Name_subject
	from TBLSubject
	where Subject_ID like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(Name_subject) like '%' + LOWER(trim(@keyword)) + '%'
	order by Name_subject;
END
GO
/****** Object:  StoredProcedure [dbo].[selectAllTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAllTeacher]
		@keyword nvarchar(50)
AS
BEGIN
	select
		Teacher_ID,
		case 
			when len(Last_name) >0 then CONCAT(Last_name,' ',First_name)
		else CONCAT(Last_name,' ',First_name)
		end as fullname,
		case when Sex = 1 then 'Male'
		else 'Female' end as sex,
		Phone_number,
		Date_of_birth,
		Email
		
	from TBLTeacher
	where 
	Lower(CONCAT(Last_name,' ', First_name)) like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(Last_name) like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(First_name) like '%' + LOWER(trim(@keyword)) + '%'
	or Phone_number like '%' + LOWER(trim(@keyword)) + '%'
	or cast(Teacher_ID as varchar(30)) like '%' + LOWER(trim(@keyword)) + '%'
	or LOWER(Email) like '%' + LOWER(trim(@keyword)) + '%'
	order by Last_name;
END
GO
/****** Object:  StoredProcedure [dbo].[selectStudent]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectStudent]
		@Student_ID varchar(50)
AS
BEGIN
	SELECT 
		Last_name,First_name,CONVERT(varchar(10),Date_of_birth,103) as Date_of_Birth,
		Sex,
		Home_town,Address,Phone_number,Email
		FROM TBLStudent
		WHERE Student_ID = @Student_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[selectSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectSubject]
	@Subject_ID int
AS
BEGIN
	SELECT 
		Name_subject
	from TBLSubject
	where Subject_ID = @Subject_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[selectTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectTeacher]
	@Teacher_ID int
AS
BEGIN
	SELECT
		Last_name,
		First_name,
		sex,
		CONVERT(varchar(10),Date_of_birth,103) as Date_of_birth,
		Phone_number,
		Email
	from TBLTeacher
	where Teacher_ID = @Teacher_ID;
END
GO
/****** Object:  StoredProcedure [dbo].[updateCourse]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateCourse]
	@Teacher_ID int,
	@Subject_ID int,
	@Name_Course nvarchar(50),
	@Course_ID int
AS
BEGIN
	UPDATE TBLCourse
	SET 
		Teacher_ID = @Teacher_ID,
		Subject_ID = @Subject_ID,
		Course_ID = @Course_ID,
		Name_Course = @Name_Course
	WHERE Course_ID = @Course_ID;
	if @@ROWCOUNT > 0 begin return 1 end 
	else begin return end;
END
GO
/****** Object:  StoredProcedure [dbo].[updateStudent]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[updateStudent]
		@Student_ID varchar(50),
		@Last_name nvarchar(10),
		@First_name nvarchar(10),
		@Date_of_birth date,
		@Sex tinyint,
		@Home_town nvarchar(150),
		@Address nvarchar(150),
		@Phone_number varchar(30),
		@Email varchar(150)

	AS
	BEGIN 
		UPDATE TBLStudent
		SET 
			Last_name = @Last_name,
			First_name = @First_name,
			Date_of_birth = @Date_of_birth,
			Sex = @Sex,
			Home_town = @Home_town,
			Address = @Address,
			Phone_number = @Phone_number,
			Email = @Email
		WHERE Student_ID = @Student_ID;
		IF @@ROWCOUNT > 0 BEGIN RETURN 1 END 
		ELSE BEGIN RETURN 0 END;
	END
GO
/****** Object:  StoredProcedure [dbo].[updateSubject]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateSubject]
	@Updater varchar(30),
	@Subject_ID int,
	@Name_subject nvarchar(150)

AS
BEGIN
	UPDATE TBLSubject
	SET 
		Updater = @Updater,
		Update_day = GETDATE(),
		Name_subject = @Name_subject
	WHERE Subject_ID = @Subject_ID;

	IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
	ELSE BEGIN RETURN 0 END;
END
GO
/****** Object:  StoredProcedure [dbo].[updateTeacher]    Script Date: 3/28/2024 8:43:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateTeacher]
	@Updater varchar(30),
	@Teacher_ID int,
	@Last_name nvarchar(10),
	@First_name nvarchar(10),
	@Sex tinyint,
	@Date_of_birth date,
	@Phone_number varchar(30),
	@Email varchar(150)
AS
BEGIN
	UPDATE TBLTeacher
	SET 
		Updater = @Updater,
		Update_day = GETDATE(),
		Last_name = @Last_name, First_name = @First_name,
		Sex = @Sex, Date_of_birth = @Date_of_birth,
		Phone_number = @Phone_number, Email = @Email
	WHERE Teacher_ID = @Teacher_ID;
END
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
