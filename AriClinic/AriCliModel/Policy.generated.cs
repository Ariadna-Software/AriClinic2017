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
	public partial class Policy
	{
		private int policyId;
		public virtual int PolicyId
		{
			get
			{
				return this.policyId;
			}
			set
			{
				this.policyId = value;
			}
		}
		
		private string policyNumber;
		public virtual string PolicyNumber
		{
			get
			{
				return this.policyNumber;
			}
			set
			{
				this.policyNumber = value;
			}
		}
		
		private DateTime beginDate;
		public virtual DateTime BeginDate
		{
			get
			{
				return this.beginDate;
			}
			set
			{
				this.beginDate = value;
			}
		}
		
		private DateTime endDate;
		public virtual DateTime EndDate
		{
			get
			{
				return this.endDate;
			}
			set
			{
				this.endDate = value;
			}
		}
		
		private string type;
		public virtual string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
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
		
		private Insurance insurance1;
		public virtual Insurance Insurance
		{
			get
			{
				return this.insurance1;
			}
			set
			{
				this.insurance1 = value;
			}
		}
		
		private Customer customer1;
		public virtual Customer Customer
		{
			get
			{
				return this.customer1;
			}
			set
			{
				this.customer1 = value;
			}
		}
		
		private IList<Ticket> tickets1 = new List<Ticket>();
		public virtual IList<Ticket> Tickets
		{
			get
			{
				return this.tickets1;
			}
		}
		
	}
}
#pragma warning restore 1591