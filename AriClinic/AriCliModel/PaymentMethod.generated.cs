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
	public partial class PaymentMethod
	{
		private int paymentMethodId;
		public virtual int PaymentMethodId
		{
			get
			{
				return this.paymentMethodId;
			}
			set
			{
				this.paymentMethodId = value;
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
		
		private IList<Payment> payments = new List<Payment>();
		public virtual IList<Payment> Payments
		{
			get
			{
				return this.payments;
			}
		}
		
		private IList<GeneralPayment> generalPayments = new List<GeneralPayment>();
		public virtual IList<GeneralPayment> GeneralPayments
		{
			get
			{
				return this.generalPayments;
			}
		}
		
	}
}
#pragma warning restore 1591
