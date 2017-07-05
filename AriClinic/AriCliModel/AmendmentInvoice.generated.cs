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
	public partial class AmendmentInvoice
	{
		private int amendmentInvoiceId;
		public virtual int AmendmentInvoiceId
		{
			get
			{
				return this.amendmentInvoiceId;
			}
			set
			{
				this.amendmentInvoiceId = value;
			}
		}
		
		private DateTime invoiceDate;
		public virtual DateTime InvoiceDate
		{
			get
			{
				return this.invoiceDate;
			}
			set
			{
				this.invoiceDate = value;
			}
		}
		
		private string serial;
		public virtual string Serial
		{
			get
			{
				return this.serial;
			}
			set
			{
				this.serial = value;
			}
		}
		
		private int year;
		public virtual int Year
		{
			get
			{
				return this.year;
			}
			set
			{
				this.year = value;
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
		
		private string invoiceKey;
		public virtual string InvoiceKey
		{
			get
			{
				return this.invoiceKey;
			}
			set
			{
				this.invoiceKey = value;
			}
		}
		
		private int invoiceNumber;
		public virtual int InvoiceNumber
		{
			get
			{
				return this.invoiceNumber;
			}
			set
			{
				this.invoiceNumber = value;
			}
		}
		
		private string reason;
		public virtual string Reason
		{
			get
			{
				return this.reason;
			}
			set
			{
				this.reason = value;
			}
		}
		
		private Invoice invoice;
		public virtual Invoice OriginalInvoice
		{
			get
			{
				return this.invoice;
			}
			set
			{
				this.invoice = value;
			}
		}
		
		private Customer customer;
		public virtual Customer Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				this.customer = value;
			}
		}
		
		private IList<AmendmentInvoiceLine> amendmentInvoiceLines = new List<AmendmentInvoiceLine>();
		public virtual IList<AmendmentInvoiceLine> AmendmentInvoiceLines
		{
			get
			{
				return this.amendmentInvoiceLines;
			}
		}
		
	}
}
#pragma warning restore 1591