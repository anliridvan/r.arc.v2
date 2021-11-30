-- public."Logging" definition

-- Drop table

-- DROP TABLE public."Logging";

CREATE TABLE public."Logging" (
	"ID" uuid NOT NULL DEFAULT uuid_generate_v4(),
	"LogLevel" varchar(24) NOT NULL,
	"Category" varchar(256) NULL,
	"LogTime" date NOT NULL,
	"EventID" int4 NULL,
	"EventName" varchar(256) NULL,
	"Scope" varchar(4000) NULL,
	"Message" varchar(4000) NOT NULL,
	"UserName" varchar(100) NULL,
	"IpAddress" varchar(50) NULL,
	"MacAddress" varchar(50) NULL,
	"HostName" varchar(50) NULL,
	"RequestUrl" varchar(256) NULL,
	"RequestBody" varchar(4000) NULL,
	"Exception" varchar NULL,
	"AppName" varchar(20) NULL,
	CONSTRAINT pk_dbologging PRIMARY KEY ("ID")
);



CREATE OR REPLACE PROCEDURE public.logrecordinsert(IN appname text, IN eventid integer, IN eventname text, IN loglevel text, IN category text, IN scope text, IN message text, IN logtime timestamp with time zone, IN username text, IN ipaddress text, IN macaddress text, IN hostname text, IN requesturl text, IN requestbody text, IN exception text)
 LANGUAGE plpgsql
AS $procedure$
begin
    INSERT INTO "Logging"
    (
        "EventID",  
        "EventName",    
        "LogLevel", 
        "Category", 
        "LogTime",  
        "Scope",  
        "Message",  
		"UserName",
		"IpAddress",
		"MacAddress", 
		"HostName",   
		"RequestUrl", 
		"RequestBody",
        "Exception",
		"AppName"
    )
    VALUES
    (
        eventID,
        eventName,
        logLevel,
        category,
        logTime,
        scope,
        message,
		userName,   
		ipAddress,  
		macAddress, 
		hostName,   
		requestUrl, 
		requestBody,
        exception,
		appName
    );

    commit;
end;$procedure$
;

