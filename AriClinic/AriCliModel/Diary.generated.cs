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
	public partial class Diary
	{
		private int diaryId;
		public virtual int DiaryId
		{
			get
			{
				return this.diaryId;
			}
			set
			{
				this.diaryId = value;
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
		
		private DateTime beginHour;
		public virtual DateTime BeginHour
		{
			get
			{
				return this.beginHour;
			}
			set
			{
				this.beginHour = value;
			}
		}
		
		private DateTime endHour;
		public virtual DateTime EndHour
		{
			get
			{
				return this.endHour;
			}
			set
			{
				this.endHour = value;
			}
		}
		
		private int timeStep;
		public virtual int TimeStep
		{
			get
			{
				return this.timeStep;
			}
			set
			{
				this.timeStep = value;
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
		
		private IList<AppointmentInfo> appointmentsRelated = new List<AppointmentInfo>();
		public virtual IList<AppointmentInfo> AppointmentsRelated
		{
			get
			{
				return this.appointmentsRelated;
			}
		}
		
	}
}
#pragma warning restore 1591
