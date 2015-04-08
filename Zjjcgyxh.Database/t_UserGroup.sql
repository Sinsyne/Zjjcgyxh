CREATE TABLE [dbo].[t_UserGroup]
(
		[Id] int identity not null,			-- 组编号，内码
		[Name] nvarchar(64) not null,		-- 组名称，唯一
		[Desctiption] nvarchar(512),		-- 组说明
		[IsAdmin] bit default(0) not null,	-- 是否管理员组，说明：管理员组只能放置管理员

		[Creator] int default(0) not null,							-- 创建者
		[CreateTime] datetime default(getdate()) not null,			-- 创建时间
		[LatestUpdateBy] int not null,								-- 最后修改者
		[LatestUpdateTime] datetime default(getdate()) not null, 
    CONSTRAINT [PK_t_UserGroup] PRIMARY KEY ([Id]),	-- 最后修改时间
)
