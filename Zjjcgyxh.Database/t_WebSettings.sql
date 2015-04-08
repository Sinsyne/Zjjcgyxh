CREATE TABLE [dbo].[t_WebSettings]
(
	[Category] varchar(32) not null,			-- 配置分类
	[Key] varchar(128) not null,				-- 键
	[Value] varchar(max) not null,				-- 值
	[Description] varchar(max), 
    CONSTRAINT [PK_t_WebSettings] PRIMARY KEY ([Key]),				-- 备注说明
)
