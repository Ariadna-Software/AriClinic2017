#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using AriCliModel;

namespace AriCliModel	
{
	public partial class ServiceCategory
	{
		private int serviceCategoryId;
		public virtual int ServiceCategoryId
		{
			get
			{
				return this.serviceCategoryId;
			}
			set
			{
				this.serviceCategoryId = value;
			}
		}
		
		private string name;
		public virtual string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		
		private int oftId;
		public virtual int OftId
		{
			get
			{
				return this.oftId;
			}
			set
			{
				this.oftId = value;
			}
		}
		
		private IList<Service> services = new List<Service>();
		public virtual IList<Service> Services
		{
			get
			{
				return this.services;
			}
		}
		
		private IList<ServiceSubCategory> serviceSubCategories = new List<ServiceSubCategory>();
		public virtual IList<ServiceSubCategory> ServiceSubCategories
		{
			get
			{
				return this.serviceSubCategories;
			}
		}
		
	}
}
#pragma warning restore 1591