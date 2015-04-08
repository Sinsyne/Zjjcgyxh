﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.0
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zjjcgyxh.WebUI.DataClasses
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KitTools.Zjjcgyxh.Test")]
	public partial class dcCategoryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    partial void Insertt_Category(t_Category instance);
    partial void Updatet_Category(t_Category instance);
    partial void Deletet_Category(t_Category instance);
    #endregion
		
		public dcCategoryDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["KitTools_Zjjcgyxh_TestConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcCategoryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCategoryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCategoryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcCategoryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<t_Category> t_Category
		{
			get
			{
				return this.GetTable<t_Category>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.t_Category")]
	public partial class t_Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Description;
		
		private int _ParentId;
		
		private string _FullPath;
		
		private bool _IsSystem;
		
		private bool _IsDelete;
		
		private int _Creator;
		
		private System.DateTime _CreateTime;
		
		private int _LatestUpdateBy;
		
		private System.DateTime _LatestUpdateTime;
		
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnParentIdChanging(int value);
    partial void OnParentIdChanged();
    partial void OnFullPathChanging(string value);
    partial void OnFullPathChanged();
    partial void OnIsSystemChanging(bool value);
    partial void OnIsSystemChanged();
    partial void OnIsDeleteChanging(bool value);
    partial void OnIsDeleteChanged();
    partial void OnCreatorChanging(int value);
    partial void OnCreatorChanged();
    partial void OnCreateTimeChanging(System.DateTime value);
    partial void OnCreateTimeChanged();
    partial void OnLatestUpdateByChanging(int value);
    partial void OnLatestUpdateByChanged();
    partial void OnLatestUpdateTimeChanging(System.DateTime value);
    partial void OnLatestUpdateTimeChanged();
    #endregion
		
		public t_Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(512)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentId", DbType="Int NOT NULL")]
		public int ParentId
		{
			get
			{
				return this._ParentId;
			}
			set
			{
				if ((this._ParentId != value))
				{
					this.OnParentIdChanging(value);
					this.SendPropertyChanging();
					this._ParentId = value;
					this.SendPropertyChanged("ParentId");
					this.OnParentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullPath", DbType="VarChar(128) NOT NULL", CanBeNull=false)]
		public string FullPath
		{
			get
			{
				return this._FullPath;
			}
			set
			{
				if ((this._FullPath != value))
				{
					this.OnFullPathChanging(value);
					this.SendPropertyChanging();
					this._FullPath = value;
					this.SendPropertyChanged("FullPath");
					this.OnFullPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsSystem", DbType="Bit NOT NULL")]
		public bool IsSystem
		{
			get
			{
				return this._IsSystem;
			}
			set
			{
				if ((this._IsSystem != value))
				{
					this.OnIsSystemChanging(value);
					this.SendPropertyChanging();
					this._IsSystem = value;
					this.SendPropertyChanged("IsSystem");
					this.OnIsSystemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsDelete", DbType="Bit NOT NULL")]
		public bool IsDelete
		{
			get
			{
				return this._IsDelete;
			}
			set
			{
				if ((this._IsDelete != value))
				{
					this.OnIsDeleteChanging(value);
					this.SendPropertyChanging();
					this._IsDelete = value;
					this.SendPropertyChanged("IsDelete");
					this.OnIsDeleteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Creator", DbType="Int NOT NULL")]
		public int Creator
		{
			get
			{
				return this._Creator;
			}
			set
			{
				if ((this._Creator != value))
				{
					this.OnCreatorChanging(value);
					this.SendPropertyChanging();
					this._Creator = value;
					this.SendPropertyChanged("Creator");
					this.OnCreatorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LatestUpdateBy", DbType="Int NOT NULL")]
		public int LatestUpdateBy
		{
			get
			{
				return this._LatestUpdateBy;
			}
			set
			{
				if ((this._LatestUpdateBy != value))
				{
					this.OnLatestUpdateByChanging(value);
					this.SendPropertyChanging();
					this._LatestUpdateBy = value;
					this.SendPropertyChanged("LatestUpdateBy");
					this.OnLatestUpdateByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LatestUpdateTime", DbType="DateTime NOT NULL")]
		public System.DateTime LatestUpdateTime
		{
			get
			{
				return this._LatestUpdateTime;
			}
			set
			{
				if ((this._LatestUpdateTime != value))
				{
					this.OnLatestUpdateTimeChanging(value);
					this.SendPropertyChanging();
					this._LatestUpdateTime = value;
					this.SendPropertyChanged("LatestUpdateTime");
					this.OnLatestUpdateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
