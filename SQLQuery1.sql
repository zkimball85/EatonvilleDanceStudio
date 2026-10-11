USE [master];
GO

ALTER AUTHORIZATION ON DATABASE::[EatonvilleDanceStudioDb] TO [sa];
GO

SELECT
	name AS EatonvilleDanceStudioDb,
	suser_sname(owner_sid) AS OwnerName
FROM sys.databases
WHERE name = 'EatonvilleDanceStudioDb';