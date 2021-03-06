﻿namespace SqlSchemer.Parser.Oracle.Tests.TestCases
{
    public class SingleTableWithIndex
    {
        public const string SCRIPT = @"
        BEGIN
            EXECUTE IMMEDIATE 'DROP TABLE PREFIX.TABLE1 CASCADE CONSTRAINTS';
            EXCEPTION WHEN OTHERS THEN NULL;
        END;
        /

        --creating table
        CREATE TABLE PREFIX.TABLE1 (
              COLUMN1 NUMBER(10) PRIMARY KEY NOT NULL,
              COLUMN2 VARCHAR2(5) NOT NULL,
              COLUMN3 VARCHAR2(16) NOT NULL,

              CONSTRAINT SK_TABLE1 UNIQUE(COLUMN2, COLUMN3)
        );

        --create indexeds
        --CREATE INDEX PREFIX.COLUMN1X ON PREFIX.TABLE1 (COLUMN2, COLUMN3) TABLESPACE SYSPREFIX_DATA;

        --checking if sequence already exists
        BEGIN
            EXECUTE IMMEDIATE 'DROP SEQUENCE PREFIX.TABLE1_SEQ';
            EXCEPTION WHEN OTHERS THEN NULL;
        END;
";
    }
}
