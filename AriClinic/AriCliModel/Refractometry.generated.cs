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
	public partial class Refractometry : ExaminationAssigned
	{
		private IList<PrescriptionGlasses> prescriptionGlasses1 = new List<PrescriptionGlasses>();
		public virtual IList<PrescriptionGlasses> PrescriptionGlasses
		{
			get
			{
				return this.prescriptionGlasses1;
			}
		}
		
		private IList<OpticalObjectiveExamination> opticalObjectiveExaminations1 = new List<OpticalObjectiveExamination>();
		public virtual IList<OpticalObjectiveExamination> OpticalObjectiveExaminations
		{
			get
			{
				return this.opticalObjectiveExaminations1;
			}
		}
		
		private IList<GlassesTest> glassesTests1 = new List<GlassesTest>();
		public virtual IList<GlassesTest> GlassesTests
		{
			get
			{
				return this.glassesTests1;
			}
		}
		
		private IList<WithoutGlassesTest> withoutGlassesTests1 = new List<WithoutGlassesTest>();
		public virtual IList<WithoutGlassesTest> WithoutGlassesTests
		{
			get
			{
				return this.withoutGlassesTests1;
			}
		}
		
		private IList<ContactLensesTest> contactLensesTests1 = new List<ContactLensesTest>();
		public virtual IList<ContactLensesTest> ContactLensesTests
		{
			get
			{
				return this.contactLensesTests1;
			}
		}
		
		private IList<SubjectiveOpticalExamination> subjectiveOpticalExaminations1 = new List<SubjectiveOpticalExamination>();
		public virtual IList<SubjectiveOpticalExamination> SubjectiveOpticalExaminations
		{
			get
			{
				return this.subjectiveOpticalExaminations1;
			}
		}
		
		private IList<Cycloplegia> cycloplegias1 = new List<Cycloplegia>();
		public virtual IList<Cycloplegia> Cycloplegias
		{
			get
			{
				return this.cycloplegias1;
			}
		}
		
	}
}
#pragma warning restore 1591
