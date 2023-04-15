CREATE SCHEMA reports

DROP VIEW IF EXISTS reports.flowsessionview;
GO

CREATE view reports.flowsessionView as 
SELECT 
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
CONVERT(date, [completedon]) as [reportingdate], -- convert completedon to date format
  CASE WHEN [context] LIKE '%"attendedMode":"Attended"%' THEN 'Attended' 
       WHEN [context] LIKE '%"attendedMode":"Unattended"%' THEN 'Unattended' 
       ELSE 'Local' 
  END AS [runmode], 
  
  CASE WHEN [$flowmachine].hostingtype = 1 AND [$flowmachine].[hostingtype] IS NOT NULL THEN NULL 
       ELSE [$flowmachine].[name] 
  END AS [reportingmachinename], 
  CASE WHEN [$flowmachinegroup].[flowgrouptype] = 545940002 AND [$flowmachinegroup].[flowgrouptype] IS NOT NULL THEN NULL 
       ELSE [$flowmachinegroup].[name] 
  END AS [reportingmachinegroupname], 
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
   WHERE 
[$flowsession].[statuscode] <> 3  AND [$flowsession].[statuscode] <> 2 