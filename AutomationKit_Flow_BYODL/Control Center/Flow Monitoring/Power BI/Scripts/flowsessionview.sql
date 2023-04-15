-- Create a new schema named "reports"
CREATE SCHEMA reports

-- Drop the view if it already exists
DROP VIEW IF EXISTS reports.flowsessionview;
GO

-- Create a new view named "flowsessionView" within the "reports" schema
CREATE VIEW reports.flowsessionView AS 

-- Select data from the "flowsession" table and join it with data from the "flowmachinegroup", "flowmachine", and "StatusMetadata" tables
SELECT top 100
  [flowsessionid], 
  [$flowsession].[createdon], 
  [$flowsession].[statuscode], 
  [$flowsession].[name], 
  [context], 
  [completedon], 
  [errorcode], 
  [startedon], 
  [regardingobjectid], 
  [machinegroupid], 
  [machineid], 
  [regardingobjectidname], 
  [machineidname], 
  [machinegroupidname], 

  -- Convert "completedon" to a date format and rename the column as "reportingdate"
  CONVERT(date, [completedon]) as [reportingdate], 

  -- Derive the run mode of the flow session based on the "context" column, and rename the column as "runmode"
  CASE 
    WHEN [context] LIKE '%"attendedMode":"Attended"%' THEN 'Attended' 
    WHEN [context] LIKE '%"attendedMode":"Unattended"%' THEN 'Unattended' 
    ELSE 'Local' 
  END AS [runmode], 
  
  -- Conditionally rename the "name" columns from the "flowmachine" and "flowmachinegroup" tables
  CASE 
    WHEN [$flowmachine].hostingtype = 1 AND [$flowmachine].[hostingtype] IS NOT NULL THEN NULL 
    ELSE [$flowmachine].[name] 
  END AS [reportingmachinename], 
  CASE 
    WHEN [$flowmachinegroup].[flowgrouptype] = 545940002 AND [$flowmachinegroup].[flowgrouptype] IS NOT NULL THEN NULL 
    ELSE [$flowmachinegroup].[name] 
  END AS [reportingmachinegroupname], 

  -- Retrieve the localized label for the "statuscode" column from the "StatusMetadata" table, and rename the column as "statuscodename"
  [$statusmetadata].LocalizedLabel AS [statuscodename] 
FROM 
  [dbo].[flowsession] AS [$flowsession] 
  LEFT OUTER JOIN [dbo].[flowmachinegroup] AS [$flowmachinegroup] ON (
    [$flowsession].[machinegroupid] = [$flowmachinegroup].[flowmachinegroupid]
  ) 
  LEFT OUTER JOIN [dbo].[flowmachine] AS [$flowmachine] ON (
    [$flowsession].[machineid] = [$flowmachine].[flowmachineid]
  ) 
  LEFT OUTER JOIN [dbo].StatusMetadata AS [$statusmetadata] ON (
    [$flowsession].statuscode = [$statusmetadata].[Status] 
    AND [$statusmetadata].EntityName = 'flowsession'
  )
   
-- Filter the rows based on the statuscode
WHERE 
  [$flowsession].[statuscode] <> 3  -- exclude flowsession with status "Canceled"
  AND [$flowsession].[statuscode] <> 2  -- exclude flowsession with status "Active"

-- End of script
