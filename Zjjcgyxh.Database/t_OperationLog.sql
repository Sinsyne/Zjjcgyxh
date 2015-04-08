CREATE TABLE [dbo].[t_OperationLog]
(
	[Id] bigint identity not null,							-- 日志编号，内码
	[OperateTime] datetime default(getdate()) not null,		-- 操作时间
	[OperationType] int not null,							-- 操作类型
	[Operator] varchar(32),									-- 操作者
	[OperateObject] varchar(128),							-- 操作对象
	[OperateIp] bigint default(0) not null,					-- 操作来源Ip
	[IsSuccess] bit default(0) not null,					-- 操作是否成功
	
	[OperationDetail] varchar(max),							-- 操作日志详情
)
