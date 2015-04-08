CREATE TABLE [dbo].[t_Category]
(
	[Id] int identity not null,				-- 编号
	[Name] nvarchar(64) not null,			-- 名称，要求唯一
	[Description] nvarchar(512),			-- 备注说明
	[ParentId] int default(0) not null,		-- 上级编号
	[FullPath] varchar(128) not null,		-- 全路径，比如：1.22
	[IsSystem] bit default(0) not null,		-- 是否系统分类，所有系统分类不允许逻辑删除
	[IsDelete] bit default(0) not null,		-- 是否已经物理删除，对于所有系统分类此字段无效且不能修改

	[Creator] int default(0) not null,							-- 创建者
	[CreateTime] datetime default(getdate()) not null,			-- 创建时间
	[LatestUpdateBy] int  default(0) not null,								-- 最后修改者
	[LatestUpdateTime] datetime default(getdate()) not null, 
    CONSTRAINT [PK_t_Category] PRIMARY KEY ([Id]),	-- 最后修改时间
)
