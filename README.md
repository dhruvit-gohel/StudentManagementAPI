# StudentManagementAPI
#Features
=>Get all students
=>Add new student
=>Update student
=>Delete student
=>JWT Authentication
=>Global Exception Handling (Middleware)
=>Logging using Serilog
=>Swagger API Documentation
=>Layered Architecture (Controller, Service, Repository)

#Technologies Used
=>ASP.NET Core Web API
=>Entity Framework Core
=>SQL Server
=>JWT Authentication
=>Serilog
=>Swagger

Student Table:
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Age] [int] NULL,
	[Course] [nvarchar](100) NULL,
	[CreatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Students] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

