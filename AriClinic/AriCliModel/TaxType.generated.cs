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
	public partial class TaxType
	{
		private int taxTypeId;
		public virtual int TaxTypeId
		{
			get
			{
				return this.taxTypeId;
			}
			set
			{
				this.taxTypeId = value;
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
		
		private decimal percentage;
		public virtual decimal Percentage
		{
			get
			{
				return this.percentage;
			}
			set
			{
				this.percentage = value;
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
		
		private IList<InvoiceLine> invoiceLines = new List<InvoiceLine>();
		public virtual IList<InvoiceLine> InvoiceLines
		{
			get
			{
				return this.invoiceLines;
			}
		}
		
		private IList<ProfessionalInvoiceLine> professionalInvoiceLines = new List<ProfessionalInvoiceLine>();
		public virtual IList<ProfessionalInvoiceLine> ProfessionalInvoiceLines
		{
			get
			{
				return this.professionalInvoiceLines;
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