CREATE TABLE [dbo].[MONDAY] (
    [trno]       INT         NOT NULL,
    [arrtime]    TIME NOT NULL,
    [deptime]    TIME NULL,
    [stations]   TEXT        NOT NULL,
    [actdeact]   NCHAR (20)  NOT NULL,
    [classes]    NCHAR (100) NOT NULL,
    [facilities] TEXT        NOT NULL,
    PRIMARY KEY CLUSTERED ([trno] ASC)
);

