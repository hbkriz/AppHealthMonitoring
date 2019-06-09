if object_id('ServiceUser', 'U') is not null
	begin
		drop table [dbo].[ServiceUser]
	end

if object_id('User', 'U') is not null
	begin
		drop table [dbo].[User]
	end

if object_id('ServiceOwner', 'U') is not null
	begin
		drop table [dbo].[ServiceOwner]
	end

if object_id('Owner', 'U') is not null
	begin
		drop table [dbo].[Owner]
	end

if object_id('ServiceStatus', 'U') is not null
	begin
		drop table [dbo].[ServiceStatus]
	end

if object_id('ServiceStatusLog', 'U') is not null
	begin
		drop table [dbo].[ServiceStatusLog]
	end

if object_id('ServiceWatcher', 'U') is not null
	begin
		drop table [dbo].[ServiceWatcher]
	end
	
if object_id('Service', 'U') is not null
	begin
		drop table [dbo].[Service]
	end

if object_id('ServiceCategory', 'U') is not null
	begin
		drop table [dbo].[ServiceCategory]
	end
go

create table [dbo].[EnvironmentCategory]
(
	[EnvironmentCategoryID] int not null identity(1, 1),
	[EnvironmentCategoryName] varchar(100) not null
)

create table [dbo].[ServiceCategory]
(
	[ServiceCategoryID] int not null identity(100, 100),
	[Description] varchar(max) null
)

create table [dbo].[Service]
(
	[ServiceID] int not null identity(1, 1),
	[ServiceCategoryID] int not null,
	[Name] varchar(max) not null
)

create table [dbo].[ServiceWatcher]
(
	[ServiceWatcherID] int not null identity(1, 1),
	[ServiceID] int not null,
	[TypeName] varchar(255) null,
	[Description] varchar(max) null
)

create table [dbo].[ServiceEnvironment]
(
	[ServiceEnvironmentID] int not null identity(1, 1),
	[ServiceID] int not null,
	[EnvironmentCategoryID] int not null,
	[Interval] int not null,
	[Url] varchar(max) null,
	[Address] varchar(max) null,
	[ConnectionString] varchar(max) null,
	[Description] varchar(max) null,
	[Active] bit not null
)

create table [dbo].[ServiceEnvironmentStatus]
(
	[ServiceEnvironmentStatusID] int not null identity(1, 1),
	[ServiceEnvironmentID] int not null,
	[Success] bit not null,
	[WatchCount] int not null,
	[LastWatch] datetime not null
)

create table [dbo].[ServiceEnvironmentStatusLog]
(
	[ServiceEnvironmentStatusLogID] int not null identity(1, 1),
	[ServiceEnvironmentStatusID] int not null,
	[Target] varchar(255) null,
	[ActionName] varchar(50) null,
	[Success] bit not null,
	[Message] varchar(max) null,
	[StackTrace] varchar(max) null,
	[Date] datetime not null
)

create table [dbo].[Owner]
(
	[OwnerID] int not null identity(1, 1),
	[UserName] varchar(50) null,
	[EmployeeID] int null
)

create table [dbo].[ServiceOwner]
(
	[ServiceOwnerID] int not null identity(1, 1),
	[ServiceID] int not null,
	[OwnerID] int not null
)

create table [dbo].[User]
(
	[UserID] int not null identity(1, 1),
	[UserName] varchar(50) not null,
	[EmployeeID] int null
)

create table [dbo].[ServiceUser]
(
	[ServiceUserID] int not null identity(1, 1),
	[ServiceID] int not null,
	[UserID] int not null
)
go
