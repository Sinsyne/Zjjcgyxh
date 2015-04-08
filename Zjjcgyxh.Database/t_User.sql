CREATE TABLE [dbo].[t_User]
(
	[Id] varchar(32) not null,					-- 用户编号，内码
	[Name] nvarchar(32) not null,				-- 用户名，唯一
	[Password] varchar(128) not null,			-- 登录密码
	[Email] varchar(1024),						-- 邮箱，用于找回密码
	[UserGroup] int default(0) not null,		-- 所在用户组，0的话属于默认用户组，即普通用户

	[LastLoginTime] datetime,					-- 最后一次登录时间
	[LastLoginIp] bigint,						-- 最后一次登录的IP地址
	[FailLoginTimes] int default(0),			-- 连续失败登录次数，连续失败5次，锁定15分钟，解除锁定时，将此字段设为0即可
	[LatestFailLoginTime] datetime,				-- 最后一次失败登录的时间

	[Creator] int default(0) not null,							-- 创建者
	[CreateTime] datetime default(getdate()) not null,			-- 创建时间
	[LatestUpdateBy] int not null,								-- 最后修改者
	[LatestUpdateTime] datetime default(getdate()) not null, 
    CONSTRAINT [PK_t_User] PRIMARY KEY ([Id]) 
-- 最后修改时间
)
