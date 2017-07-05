﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
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
	public partial class AriClinicContext : OpenAccessContext, IAriClinicContextUnitOfWork
	{
		private static string connectionStringName = @"AriClinicContext";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntityDiagrams.rlinq");
		
		public AriClinicContext()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public AriClinicContext(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public AriClinicContext(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public AriClinicContext(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public AriClinicContext(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<User> Users 
		{
			get
			{
				return this.GetAll<User>();
			}
		}
		
		public IQueryable<UserGroup> UserGroups 
		{
			get
			{
				return this.GetAll<UserGroup>();
			}
		}
		
		public IQueryable<HealthcareCompany> HealthcareCompanies 
		{
			get
			{
				return this.GetAll<HealthcareCompany>();
			}
		}
		
		public IQueryable<Telephone> Telephones 
		{
			get
			{
				return this.GetAll<Telephone>();
			}
		}
		
		public IQueryable<Email> Emails 
		{
			get
			{
				return this.GetAll<Email>();
			}
		}
		
		public IQueryable<Log> Logs 
		{
			get
			{
				return this.GetAll<Log>();
			}
		}
		
		public IQueryable<Process> Processes 
		{
			get
			{
				return this.GetAll<Process>();
			}
		}
		
		public IQueryable<Permission> Permissions 
		{
			get
			{
				return this.GetAll<Permission>();
			}
		}
		
		public IQueryable<Address> Addresses 
		{
			get
			{
				return this.GetAll<Address>();
			}
		}
		
		public IQueryable<Clinic> Clinics 
		{
			get
			{
				return this.GetAll<Clinic>();
			}
		}
		
		public IQueryable<Person> People 
		{
			get
			{
				return this.GetAll<Person>();
			}
		}
		
		public IQueryable<ServiceCategory> ServiceCategories 
		{
			get
			{
				return this.GetAll<ServiceCategory>();
			}
		}
		
		public IQueryable<TaxType> TaxTypes 
		{
			get
			{
				return this.GetAll<TaxType>();
			}
		}
		
		public IQueryable<Service> Services 
		{
			get
			{
				return this.GetAll<Service>();
			}
		}
		
		public IQueryable<Insurance> Insurances 
		{
			get
			{
				return this.GetAll<Insurance>();
			}
		}
		
		public IQueryable<InsuranceService> InsuranceServices 
		{
			get
			{
				return this.GetAll<InsuranceService>();
			}
		}
		
		public IQueryable<Patient> Patients 
		{
			get
			{
				return this.GetAll<Patient>();
			}
		}
		
		public IQueryable<Customer> Customers 
		{
			get
			{
				return this.GetAll<Customer>();
			}
		}
		
		public IQueryable<Policy> Policies 
		{
			get
			{
				return this.GetAll<Policy>();
			}
		}
		
		public IQueryable<Ticket> Tickets 
		{
			get
			{
				return this.GetAll<Ticket>();
			}
		}
		
		public IQueryable<Invoice> Invoices 
		{
			get
			{
				return this.GetAll<Invoice>();
			}
		}
		
		public IQueryable<InvoiceLine> InvoiceLines 
		{
			get
			{
				return this.GetAll<InvoiceLine>();
			}
		}
		
		public IQueryable<PaymentMethod> PaymentMethods 
		{
			get
			{
				return this.GetAll<PaymentMethod>();
			}
		}
		
		public IQueryable<Payment> Payments 
		{
			get
			{
				return this.GetAll<Payment>();
			}
		}
		
		public IQueryable<TaxWithholdingType> TaxWithholdingTypes 
		{
			get
			{
				return this.GetAll<TaxWithholdingType>();
			}
		}
		
		public IQueryable<Professional> Professionals 
		{
			get
			{
				return this.GetAll<Professional>();
			}
		}
		
		public IQueryable<Procedure> Procedures 
		{
			get
			{
				return this.GetAll<Procedure>();
			}
		}
		
		public IQueryable<AnestheticTicket> AnestheticTickets 
		{
			get
			{
				return this.GetAll<AnestheticTicket>();
			}
		}
		
		public IQueryable<AnestheticServiceNote> AnestheticServiceNotes 
		{
			get
			{
				return this.GetAll<AnestheticServiceNote>();
			}
		}
		
		public IQueryable<Parameter> Parameters 
		{
			get
			{
				return this.GetAll<Parameter>();
			}
		}
		
		public IQueryable<ServiceNote> ServiceNotes 
		{
			get
			{
				return this.GetAll<ServiceNote>();
			}
		}
		
		public IQueryable<Diary> Diaries 
		{
			get
			{
				return this.GetAll<Diary>();
			}
		}
		
		public IQueryable<AppointmentType> AppointmentTypes 
		{
			get
			{
				return this.GetAll<AppointmentType>();
			}
		}
		
		public IQueryable<AppointmentInfo> AppointmentInfos 
		{
			get
			{
				return this.GetAll<AppointmentInfo>();
			}
		}
		
		public IQueryable<DiagnosticAssigned> DiagnosticAssigneds 
		{
			get
			{
				return this.GetAll<DiagnosticAssigned>();
			}
		}
		
		public IQueryable<Diagnostic> Diagnostics 
		{
			get
			{
				return this.GetAll<Diagnostic>();
			}
		}
		
		public IQueryable<Drug> Drugs 
		{
			get
			{
				return this.GetAll<Drug>();
			}
		}
		
		public IQueryable<Treatment> Treatments 
		{
			get
			{
				return this.GetAll<Treatment>();
			}
		}
		
		public IQueryable<UnitType> UnitTypes 
		{
			get
			{
				return this.GetAll<UnitType>();
			}
		}
		
		public IQueryable<Examination> Examinations 
		{
			get
			{
				return this.GetAll<Examination>();
			}
		}
		
		public IQueryable<ExaminationAssigned> ExaminationAssigneds 
		{
			get
			{
				return this.GetAll<ExaminationAssigned>();
			}
		}
		
		public IQueryable<Refractometry> Refractometries 
		{
			get
			{
				return this.GetAll<Refractometry>();
			}
		}
		
		public IQueryable<WithoutGlassesTest> WithoutGlassesTests 
		{
			get
			{
				return this.GetAll<WithoutGlassesTest>();
			}
		}
		
		public IQueryable<GlassesTest> GlassesTests 
		{
			get
			{
				return this.GetAll<GlassesTest>();
			}
		}
		
		public IQueryable<ContactLensesTest> ContactLensesTests 
		{
			get
			{
				return this.GetAll<ContactLensesTest>();
			}
		}
		
		public IQueryable<OpticalObjectiveExamination> OpticalObjectiveExaminations 
		{
			get
			{
				return this.GetAll<OpticalObjectiveExamination>();
			}
		}
		
		public IQueryable<SubjectiveOpticalExamination> SubjectiveOpticalExaminations 
		{
			get
			{
				return this.GetAll<SubjectiveOpticalExamination>();
			}
		}
		
		public IQueryable<PrescriptionGlasses> PrescriptionGlasses 
		{
			get
			{
				return this.GetAll<PrescriptionGlasses>();
			}
		}
		
		public IQueryable<Cycloplegia> Cycloplegias 
		{
			get
			{
				return this.GetAll<Cycloplegia>();
			}
		}
		
		public IQueryable<LabTest> LabTests 
		{
			get
			{
				return this.GetAll<LabTest>();
			}
		}
		
		public IQueryable<ProfessionalInvoice> ProfessionalInvoices 
		{
			get
			{
				return this.GetAll<ProfessionalInvoice>();
			}
		}
		
		public IQueryable<ProfessionalInvoiceLine> ProfessionalInvoiceLines 
		{
			get
			{
				return this.GetAll<ProfessionalInvoiceLine>();
			}
		}
		
		public IQueryable<ExaminationType> ExaminationTypes 
		{
			get
			{
				return this.GetAll<ExaminationType>();
			}
		}
		
		public IQueryable<Nomenclator> Nomenclators 
		{
			get
			{
				return this.GetAll<Nomenclator>();
			}
		}
		
		public IQueryable<LabTestAssigned> LabTestAssigneds 
		{
			get
			{
				return this.GetAll<LabTestAssigned>();
			}
		}
		
		public IQueryable<ProcedureAssigned> ProcedureAssigneds 
		{
			get
			{
				return this.GetAll<ProcedureAssigned>();
			}
		}
		
		public IQueryable<Biometry> Biometries 
		{
			get
			{
				return this.GetAll<Biometry>();
			}
		}
		
		public IQueryable<Paquimetry> Paquimetries 
		{
			get
			{
				return this.GetAll<Paquimetry>();
			}
		}
		
		public IQueryable<Topography> Topographies 
		{
			get
			{
				return this.GetAll<Topography>();
			}
		}
		
		public IQueryable<VisitReason> VisitReasons 
		{
			get
			{
				return this.GetAll<VisitReason>();
			}
		}
		
		public IQueryable<BaseVisit> BaseVisits 
		{
			get
			{
				return this.GetAll<BaseVisit>();
			}
		}
		
		public IQueryable<OphthalmologicVisit> OphthalmologicVisits 
		{
			get
			{
				return this.GetAll<OphthalmologicVisit>();
			}
		}
		
		public IQueryable<AntSegment> AntSegments 
		{
			get
			{
				return this.GetAll<AntSegment>();
			}
		}
		
		public IQueryable<MotAppend> MotAppends 
		{
			get
			{
				return this.GetAll<MotAppend>();
			}
		}
		
		public IQueryable<Fundus> Fundus 
		{
			get
			{
				return this.GetAll<Fundus>();
			}
		}
		
		public IQueryable<Source> Sources 
		{
			get
			{
				return this.GetAll<Source>();
			}
		}
		
		public IQueryable<GeneralPayment> GeneralPayments 
		{
			get
			{
				return this.GetAll<GeneralPayment>();
			}
		}
		
		public IQueryable<PreviousMedicalRecord> PreviousMedicalRecords 
		{
			get
			{
				return this.GetAll<PreviousMedicalRecord>();
			}
		}
		
		public IQueryable<BackPersonal> BackPersonals 
		{
			get
			{
				return this.GetAll<BackPersonal>();
			}
		}
		
		public IQueryable<BackFamily> BackFamilies 
		{
			get
			{
				return this.GetAll<BackFamily>();
			}
		}
		
		public IQueryable<BackGinecology> BackGinecologies 
		{
			get
			{
				return this.GetAll<BackGinecology>();
			}
		}
		
		public IQueryable<BaseVisitType> BaseVisitTypes 
		{
			get
			{
				return this.GetAll<BaseVisitType>();
			}
		}
		
		public IQueryable<Template> Templates 
		{
			get
			{
				return this.GetAll<Template>();
			}
		}
		
		public IQueryable<Campaign> Campaigns 
		{
			get
			{
				return this.GetAll<Campaign>();
			}
		}
		
		public IQueryable<Channel> Channels 
		{
			get
			{
				return this.GetAll<Channel>();
			}
		}
		
		public IQueryable<Request> Requests 
		{
			get
			{
				return this.GetAll<Request>();
			}
		}
		
		public IQueryable<Replay> Replays 
		{
			get
			{
				return this.GetAll<Replay>();
			}
		}
		
		public IQueryable<EstimateLine> EstimateLines 
		{
			get
			{
				return this.GetAll<EstimateLine>();
			}
		}
		
		public IQueryable<Estimate> Estimates 
		{
			get
			{
				return this.GetAll<Estimate>();
			}
		}
		
		public IQueryable<ServiceSubCategory> ServiceSubCategories 
		{
			get
			{
				return this.GetAll<ServiceSubCategory>();
			}
		}
		
		public IQueryable<AmendmentInvoice> AmendmentInvoices 
		{
			get
			{
				return this.GetAll<AmendmentInvoice>();
			}
		}
		
		public IQueryable<AmendmentInvoiceLine> AmendmentInvoiceLines 
		{
			get
			{
				return this.GetAll<AmendmentInvoiceLine>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MySql";
			backend.ProviderName = "MySql.Data.MySqlClient";
			backend.Logging.LogEventsToTrace = false;
			backend.Logging.MetricStoreSnapshotInterval = 0;
			return backend;
		}
	}
	
	public interface IAriClinicContextUnitOfWork : IUnitOfWork
	{
		IQueryable<User> Users
		{
			get;
		}
		IQueryable<UserGroup> UserGroups
		{
			get;
		}
		IQueryable<HealthcareCompany> HealthcareCompanies
		{
			get;
		}
		IQueryable<Telephone> Telephones
		{
			get;
		}
		IQueryable<Email> Emails
		{
			get;
		}
		IQueryable<Log> Logs
		{
			get;
		}
		IQueryable<Process> Processes
		{
			get;
		}
		IQueryable<Permission> Permissions
		{
			get;
		}
		IQueryable<Address> Addresses
		{
			get;
		}
		IQueryable<Clinic> Clinics
		{
			get;
		}
		IQueryable<Person> People
		{
			get;
		}
		IQueryable<ServiceCategory> ServiceCategories
		{
			get;
		}
		IQueryable<TaxType> TaxTypes
		{
			get;
		}
		IQueryable<Service> Services
		{
			get;
		}
		IQueryable<Insurance> Insurances
		{
			get;
		}
		IQueryable<InsuranceService> InsuranceServices
		{
			get;
		}
		IQueryable<Patient> Patients
		{
			get;
		}
		IQueryable<Customer> Customers
		{
			get;
		}
		IQueryable<Policy> Policies
		{
			get;
		}
		IQueryable<Ticket> Tickets
		{
			get;
		}
		IQueryable<Invoice> Invoices
		{
			get;
		}
		IQueryable<InvoiceLine> InvoiceLines
		{
			get;
		}
		IQueryable<PaymentMethod> PaymentMethods
		{
			get;
		}
		IQueryable<Payment> Payments
		{
			get;
		}
		IQueryable<TaxWithholdingType> TaxWithholdingTypes
		{
			get;
		}
		IQueryable<Professional> Professionals
		{
			get;
		}
		IQueryable<Procedure> Procedures
		{
			get;
		}
		IQueryable<AnestheticTicket> AnestheticTickets
		{
			get;
		}
		IQueryable<AnestheticServiceNote> AnestheticServiceNotes
		{
			get;
		}
		IQueryable<Parameter> Parameters
		{
			get;
		}
		IQueryable<ServiceNote> ServiceNotes
		{
			get;
		}
		IQueryable<Diary> Diaries
		{
			get;
		}
		IQueryable<AppointmentType> AppointmentTypes
		{
			get;
		}
		IQueryable<AppointmentInfo> AppointmentInfos
		{
			get;
		}
		IQueryable<DiagnosticAssigned> DiagnosticAssigneds
		{
			get;
		}
		IQueryable<Diagnostic> Diagnostics
		{
			get;
		}
		IQueryable<Drug> Drugs
		{
			get;
		}
		IQueryable<Treatment> Treatments
		{
			get;
		}
		IQueryable<UnitType> UnitTypes
		{
			get;
		}
		IQueryable<Examination> Examinations
		{
			get;
		}
		IQueryable<ExaminationAssigned> ExaminationAssigneds
		{
			get;
		}
		IQueryable<Refractometry> Refractometries
		{
			get;
		}
		IQueryable<WithoutGlassesTest> WithoutGlassesTests
		{
			get;
		}
		IQueryable<GlassesTest> GlassesTests
		{
			get;
		}
		IQueryable<ContactLensesTest> ContactLensesTests
		{
			get;
		}
		IQueryable<OpticalObjectiveExamination> OpticalObjectiveExaminations
		{
			get;
		}
		IQueryable<SubjectiveOpticalExamination> SubjectiveOpticalExaminations
		{
			get;
		}
		IQueryable<PrescriptionGlasses> PrescriptionGlasses
		{
			get;
		}
		IQueryable<Cycloplegia> Cycloplegias
		{
			get;
		}
		IQueryable<LabTest> LabTests
		{
			get;
		}
		IQueryable<ProfessionalInvoice> ProfessionalInvoices
		{
			get;
		}
		IQueryable<ProfessionalInvoiceLine> ProfessionalInvoiceLines
		{
			get;
		}
		IQueryable<ExaminationType> ExaminationTypes
		{
			get;
		}
		IQueryable<Nomenclator> Nomenclators
		{
			get;
		}
		IQueryable<LabTestAssigned> LabTestAssigneds
		{
			get;
		}
		IQueryable<ProcedureAssigned> ProcedureAssigneds
		{
			get;
		}
		IQueryable<Biometry> Biometries
		{
			get;
		}
		IQueryable<Paquimetry> Paquimetries
		{
			get;
		}
		IQueryable<Topography> Topographies
		{
			get;
		}
		IQueryable<VisitReason> VisitReasons
		{
			get;
		}
		IQueryable<BaseVisit> BaseVisits
		{
			get;
		}
		IQueryable<OphthalmologicVisit> OphthalmologicVisits
		{
			get;
		}
		IQueryable<AntSegment> AntSegments
		{
			get;
		}
		IQueryable<MotAppend> MotAppends
		{
			get;
		}
		IQueryable<Fundus> Fundus
		{
			get;
		}
		IQueryable<Source> Sources
		{
			get;
		}
		IQueryable<GeneralPayment> GeneralPayments
		{
			get;
		}
		IQueryable<PreviousMedicalRecord> PreviousMedicalRecords
		{
			get;
		}
		IQueryable<BackPersonal> BackPersonals
		{
			get;
		}
		IQueryable<BackFamily> BackFamilies
		{
			get;
		}
		IQueryable<BackGinecology> BackGinecologies
		{
			get;
		}
		IQueryable<BaseVisitType> BaseVisitTypes
		{
			get;
		}
		IQueryable<Template> Templates
		{
			get;
		}
		IQueryable<Campaign> Campaigns
		{
			get;
		}
		IQueryable<Channel> Channels
		{
			get;
		}
		IQueryable<Request> Requests
		{
			get;
		}
		IQueryable<Replay> Replays
		{
			get;
		}
		IQueryable<EstimateLine> EstimateLines
		{
			get;
		}
		IQueryable<Estimate> Estimates
		{
			get;
		}
		IQueryable<ServiceSubCategory> ServiceSubCategories
		{
			get;
		}
		IQueryable<AmendmentInvoice> AmendmentInvoices
		{
			get;
		}
		IQueryable<AmendmentInvoiceLine> AmendmentInvoiceLines
		{
			get;
		}
	}
}
#pragma warning restore 1591