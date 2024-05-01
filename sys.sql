alter session set current_schema = sys;
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
alter session set container = PDB_ATBMHTTT;
alter pluggable database PDB_ATBMHTTT open READ WRITE;


SELECT VALUE FROM v$option WHERE parameter = 'Oracle Label Security'; 
SELECT status FROM dba_ols_status WHERE name = 'OLS_CONFIGURE_STATUS'; 
EXEC LBACSYS.CONFIGURE_OLS;

ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

--DROP USER ad cascade;

CREATE user ad IDENTIFIED by 123;
GRANT CREATE SESSION TO ad container = current;
Grant SYSDBA TO AD;

CONNECT ad/123;

show con_name;

GRANT EXECUTE ANY PROCEDURE TO ad; 
GRANT ALL PRIVILEGES TO ad;

--select * from dba_users where username = 'AD';

grant execute on sys.DBMS_RLS to ad; -- to add policy

GRANT INHERIT PRIVILEGES ON USER sys TO ad; -- to create function