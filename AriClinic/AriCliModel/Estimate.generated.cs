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
	public partial class Estimate
	{
		private int estimateId;
		public virtual int EstimateId
		{
			get
			{
				return this.estimateId;
			}
			set
			{
				this.estimateId = value;
			}
		}
		
		private DateTime estimateDate;
		public virtual DateTime EstimateDate
		{
			get
			{
				return this.estimateDate;
			}
			set
			{
				this.estimateDate = value;
			}
		}
		
		private decimal total;
		public virtual decimal Total
		{
			get
			{
				return this.total;
			}
			set
			{
				this.total = value;
			}
		}
		
		private string fullName;
		public virtual string FullName
		{
			get
			{
				return this.fullName;
			}
			set
			{
				this.fullName = value;
			}
		}
		
		private string comments;
		public virtual string Comments
		{
			get
			{
				return this.comments;
			}
			set
			{
				this.comments = value;
			}
		}
		
		private Request request;
		public virtual Request Request
		{
			get
			{
				return this.request;
			}
			set
			{
				this.request = value;
			}
		}
		
		private User user;
		public virtual User User
		{
			get
			{
				return this.user;
			}
			set
			{
				this.user = value;
			}
		}
		
		private IList<EstimateLine> estimateLines = new List<EstimateLine>();
		public virtual IList<EstimateLine> EstimateLines
		{
			get
			{
				return this.estimateLines;
			}
		}
		
	}
}
#pragma warning restore 1591
