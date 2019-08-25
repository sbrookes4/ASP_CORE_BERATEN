namespace BeratenHealthcareDataAccessLib
{
    using BeratenHealthcareModels;
    using Microsoft.EntityFrameworkCore;

    public class PositivityModel : DbContext
    {
        public PositivityModel()
        {
        }

        public virtual DbSet<AppRole> AppRoles { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AppUserRole> AppUserRoles { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<Widget> Widgets { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Coverage> Coverages { get; set; }
        public virtual DbSet<Guardian> Guardians { get; set; }
        public virtual DbSet<ClientCondition> ClientConditions { get; set; }

        public virtual DbSet<CaseIntake> CaseIntakes { get; set; }
        public virtual DbSet<CaseDischarge> CaseDischarges { get; set; }

        public virtual DbSet<ProgressNote> ProgressNotes { get; set; }
        public virtual DbSet<TreatmentGoal> TreatmentGoals { get; set; }
        public virtual DbSet<TreatmentPlan> TreatmentPlans { get; set; }

        public virtual DbSet<ComprehensiveAssessment> ComprehensiveAssessments { get; set; }
        public virtual DbSet<MentalHealthAssessment> MentalHealthAssessments { get; set; }
        //public virtual DbSet<DsmCode> ICDTenCodes { get; set; }
        //public virtual DbSet<GoalObjective> GoalObjectives { get; set; }

        //#region Billing

        //public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }
        //public virtual DbSet<BillingProcedure> BillingProcedures { get; set; }
        //public virtual DbSet<Invoice> Invoices { get; set; }
        //public virtual DbSet<Payment> Payments { get; set; }
        //public virtual DbSet<AccountingEntryReconciliation> AccountingEntryAllocations { get; set; }
        //public virtual DbSet<Payor> Payors { get; set; }

        //#endregion Billing

        #region lookups

        public virtual DbSet<AbuseLookup> AbuseLookups { get; set; }
        public virtual DbSet<AffectLookup> AffectLookups { get; set; }
        public virtual DbSet<AppearanceLookup> AppearanceLookups { get; set; }
        public virtual DbSet<AttentionLookup> AttentionLookups { get; set; }
        public virtual DbSet<AttitudeLookup> AttitudeLookups { get; set; }
        public virtual DbSet<BodyMovementLookup> BodyMovementLookups { get; set; }
        public virtual DbSet<ConcentrationLookup> ConcentrationLookups { get; set; }
        public virtual DbSet<DegreeOfRiskLookup> DegreeOfRiskLookUups { get; set; }

        //public virtual DbSet<DispositionLookup> DispositionLookup { get; set; }
        public virtual DbSet<EducationLookup> EducationLookups { get; set; }

        public virtual DbSet<EligibilityLookup> EligibilityLookups { get; set; }
        public virtual DbSet<EmploymentLookup> EmploymentLookups { get; set; }
        public virtual DbSet<EnglishLanguageSkillsLookup> EnglishLanguageSkillsLookups { get; set; }
        public virtual DbSet<RaceLookup> EthnicityLookups { get; set; }
        public virtual DbSet<FacialExpressionLookup> FacialExpressionLookups { get; set; }
        public virtual DbSet<FamilyOriginLookup> FamilyOriginLookups { get; set; }

        //public virtual DbSet<FirstActivityLookup> FirstActivityLookups { get; set; }
        public virtual DbSet<FirstDispositionLookup> FirstDispositionLookups { get; set; }

        public virtual DbSet<FutureOrientLookup> FutureOrientLookups { get; set; }
        public virtual DbSet<GenderLookup> GenderLookups { get; set; }
        public virtual DbSet<GeneralKnowledgeLookup> GeneralKnowledgeLookups { get; set; }
        public virtual DbSet<HygieneLookup> HygieneLookups { get; set; }

        //public virtual DbSet<IdeaLookup> IdeaLookups { get; set; }
        public virtual DbSet<ImpulseControlLookup> ImpulseControlLookups { get; set; }

        public virtual DbSet<IncomeSourceLookup> IncomeSourceLookups { get; set; }
        public virtual DbSet<InsightLookup> InsightLookups { get; set; }
        public virtual DbSet<IntellectualFunctionLookup> IntellectualFunctionLookups { get; set; }
        public virtual DbSet<IntellectualLevelLookup> IntellectualLevelLookups { get; set; }
        public virtual DbSet<InterviewLookup> InterviewLookups { get; set; }
        public virtual DbSet<JudgementLookup> JudgementLookups { get; set; }
        public virtual DbSet<LivingArrangementLookup> LivingArrangementLookups { get; set; }
        public virtual DbSet<MaritalStatusLookup> MaritalStatusLookups { get; set; }
        public virtual DbSet<MemoryLookup> MemoryLookups { get; set; }
        public virtual DbSet<MoodLookup> MoodLookups { get; set; }
        public virtual DbSet<MotorBehaviorLookup> MotorBehaviorLookups { get; set; }
        public virtual DbSet<OrientationLookup> OrientationLookups { get; set; }
        public virtual DbSet<OtherHarmLookup> OtherHarmLookups { get; set; }
        public virtual DbSet<PhobiaLookup> PhobiaLookups { get; set; }
        public virtual DbSet<ProblemDomainLookup> ProblemDomainLookups { get; set; }
        public virtual DbSet<ReferralSourceLookup> ReferralCodeLookups { get; set; }

        //public virtual DbSet<ReliabilityLookup> ReliabilityLookups { get; set; }
        public virtual DbSet<SchoolsLookup> SchoolsLookups { get; set; }

        public virtual DbSet<SelfHarmLookup> SelfHarmLookups { get; set; }
        public virtual DbSet<SensoryCognitionLookup> SensoryCognitionLookups { get; set; }
        public virtual DbSet<SpeechLookup> SpeechLookups { get; set; }
        public virtual DbSet<SuicideLookup> SuicideLookups { get; set; }
        public virtual DbSet<ThoughtContentLookup> ThoughtContentLookups { get; set; }
        public virtual DbSet<ThoughtProcessLookup> ThoughtProcessLookups { get; set; }
        public virtual DbSet<TreatmentModalityLookup> TreatmentModalityLookups { get; set; }
        public virtual DbSet<UrgencyLevelLookup> UrgencyLevelLookups { get; set; }
        public virtual DbSet<SpecialNeedsLookup> SpecialNeedsLookups { get; set; }
        public virtual DbSet<PreferredLanguageLookup> PreferredLanguageLookups { get; set; }
        public virtual DbSet<ResidenceLookup> ResidenceLookups { get; set; }
        public virtual DbSet<ProgramsLookup> Programs { get; set; }
        public virtual DbSet<FrustrationToleranceLookup> FrustrationToleranceLookups { get; set; }
        public virtual DbSet<TransitionsLookup> TransitionsLookups { get; set; }
        public virtual DbSet<AlertnessLookup> AlertnessLookups { get; set; }
        public virtual DbSet<SensoryIntegrationLookup> SensoryIntegrationLookups { get; set; }
        public virtual DbSet<SelfSoothingCapacityLookup> SelfSoothingCapacityLookups { get; set; }
        public virtual DbSet<ActivityLevelLookup> ActivityLevelLookups { get; set; }
        public virtual DbSet<BodyTypeLookup> BodyTypeLookups { get; set; }
        public virtual DbSet<EyeContactLookup> EyeContactLookups { get; set; }
        public virtual DbSet<FineMotorLookup> FineMotorLookups { get; set; }
        public virtual DbSet<GrossMotorLookup> GrossMotorLookus { get; set; }
        public virtual DbSet<MascularLookup> MuscularLookups { get; set; }
        public virtual DbSet<GaitLookup> GaitLookups { get; set; }
        public virtual DbSet<TreatmentModalityLookup> TreatmentModalityLookup { get; set; }
        public virtual DbSet<ContactMethodLookup> ContactMethodLookups { get; set; }
        public virtual DbSet<ServiceLocationLookup> ServiceLocationLookups { get; set; }
        public virtual DbSet<SleepPatternsLookup> SleepPatternsLookups { get; set; }
        public virtual DbSet<EatingPatternsLookup> EatingPatternsLookups { get; set; }
        public virtual DbSet<UnusualBehaviorPatternsLookup> UnusualBehaviorPatternsLookups { get; set; }
        public virtual DbSet<BehaviorWithCareGiversLookup> BehaviorWithCareGiversLookups { get; set; }
        public virtual DbSet<BehaviorWithExaminersLookup> BehaviorWithExaminersLookups { get; set; }
        public virtual DbSet<HallucinationsLookup> HallucinationsLookups { get; set; }
        public virtual DbSet<DelusionsLookup> DelusionsLookups { get; set; }
        public virtual DbSet<AssociationsLookup> AssociationsLookups { get; set; }
        public virtual DbSet<ReceptiveLanguageLookup> ReceptiveLanguageLookups { get; set; }
        public virtual DbSet<ExpressiveLanguageLookup> ExpressiveLanguageLookups { get; set; }
        public virtual DbSet<PresentingProblemsLookup> PresentingProblemsLookups { get; set; }

        #endregion lookups

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connection = @"data source=.\SQLEXPRESS;initial catalog=BeratenPositivityDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUserRole>()
           .HasKey(bc => new { bc.AppUserId, bc.AppRoleId });

            modelBuilder.Entity<AppUserRole>()
               .HasOne(bc => bc.AppUser)
               .WithMany(b => b.AppUserRoles)
               .HasForeignKey(bc => bc.AppUserId);

            modelBuilder.Entity<AppUserRole>()
               .HasOne(bc => bc.AppRole)
               .WithMany(b => b.AppUserRoles)
               .HasForeignKey(bc => bc.AppRoleId);

            //modelBuilder.Entity<ProgressNote>().HasOptional(c => c.InvoiceItem).WithRequired().WillCascadeOnDelete(false);

            //modelBuilder.Entity<Client>().HasMany(x => x.ClinicalAssessments).WithRequired(x => x.Client).WillCascadeOnDelete(false);
            //modelBuilder.Entity<ClientCase>().HasMany(x => x.Services).WithRequired(x => x.ClientCase).WillCascadeOnDelete(false);
            ////modelBuilder.Entity<BusinessProfile>().HasMany( x => x.BusinessTags ).WithRequired( x => x.TaggedByBusiness ).WillCascadeOnDelete( false );

            ////modelBuilder.Entity<ClientService>().HasOptional( c => c.Staff ).WithRequired().WillCascadeOnDelete( false );

            //modelBuilder.Entity<ClientService>().HasRequired(c => c.ClientCase).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<ProgressNote>().HasRequired(c => c.ClientService).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<TreatmentPlan>().HasRequired(c => c.ClientCase).WithMany().WillCascadeOnDelete(false);

            ////modelBuilder.Entity<TreatmentPlan>().HasRequired( c => c.PrimaryStaff ).WithMany().WillCascadeOnDelete( false );

            ////modelBuilder.Entity<InvoiceItem>().HasRequired( t => t.ProgramsLookup ).WithMany().WillCascadeOnDelete( false );

            //modelBuilder.Entity<AccountingEntryReconciliation>().HasRequired(t => t.AllocateToEntry).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<AccountingEntryReconciliation>().HasRequired(t => t.AllocateFromEntry).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<Payment>().HasRequired(t => t.Payor).WithMany().WillCascadeOnDelete(false);

            ////modelBuilder.Entity<AccountingEntry>().HasMany( t => t.Allocations ).WithRequired( t => t.AllocateFromEntry );

            //modelBuilder.Entity<Invoice>().HasRequired(t => t.Payor).WithMany().WillCascadeOnDelete(false);

            //modelBuilder.Entity<CreditMemo>().HasRequired(t => t.Payor).WithMany().WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}