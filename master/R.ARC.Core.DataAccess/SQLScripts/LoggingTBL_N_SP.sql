USE [RARC]
GO

/****** Object:  Table [dbo].[tRolesTuru]    Script Date: 29.01.2019 11:47:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [RARC]
GO

CREATE TABLE dbo.tLogging
(
    [ID]        int identity(1, 1)  NOT NULL,
    [LogLevel]  varchar(24)         NOT NULL,
    [Category]  varchar(256)        NULL,
    [LogTime]   datetime            NOT NULL,
    [EventID]   int                 NULL,
    [EventName] varchar(256)        NULL,
    [Scope]     varchar(4000)       NULL,
    [Message]   varchar(4000)       NOT NULL,
	[UserName]  varchar(100)         NULL,
	[IpAddress] varchar(50)         NULL,
	[MacAddress] varchar(50)        NULL,
	[HostName]   varchar(50)          NULL,
	[RequestUrl] varchar(256)       NULL,
	[RequestBody] varchar(4000)     NULL,
    [Exception] varchar(max)        NULL,
	[AppName]	varchar(20)	NULL
    

    CONSTRAINT PK_dboLogging PRIMARY KEY CLUSTERED (ID ASC)
        WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = ON, IGNORE_DUP_KEY = OFF, 
            ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
) ON [PRIMARY];


USE [RARC]
GO

CREATE PROCEDURE dbo.LogRecordInsert
(
	@appName	varchar(20) = NULL,
    @eventID    int = NULL,
    @eventName  varchar(256) = NULL,
    @logLevel   varchar(24),
    @category   varchar(256) = NULL,
    @scope      varchar(4000) = NULL,
    @message    varchar(4000),
    @logTime    datetime,
	@userName   varchar(100) = NULL,
	@ipAddress  varchar(50) = NULL,
	@macAddress varchar(50) = NULL,
	@hostName   varchar(50) = NULL,
	@requestUrl varchar(256) = NULL,
	@requestBody varchar(4000) = NULL,
    @exception  varchar(8000) = NULL
)
AS
    SET NOCOUNT ON;
    INSERT INTO [dbo].[tLogging]
    (
        [EventID],  
        [EventName],    
        [LogLevel], 
        [Category], 
        [LogTime],  
        [Scope],  
        [Message],  
		[UserName],
		[IpAddress],
		[MacAddress], 
		[HostName],   
		[RequestUrl], 
		[RequestBody],
        [Exception],
		[AppName]
    )
    VALUES
    (
        @eventID,
        @eventName,
        @logLevel,
        @category,
        @logTime,
        @scope,
        @message,
		@userName,   
		@ipAddress,  
		@macAddress, 
		@hostName,   
		@requestUrl, 
		@requestBody,
        @exception,
		@appName
    );



