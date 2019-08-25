using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeratenHealthcareDataAccessLib.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbuseLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbuseLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLevelLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLevelLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AffectLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffectLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlertnessLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertnessLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppearanceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppearanceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Role = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociationsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociationsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttentionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttentionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttitudeLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttitudeLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BehaviorWithCareGiversLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehaviorWithCareGiversLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BehaviorWithExaminersLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehaviorWithExaminersLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingProcedure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    CPTCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitOfMeasure = table.Column<int>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: true),
                    ValidTo = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingProcedure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyMovementLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyMovementLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BodyTypeLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyTypeLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConcentrationLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcentrationLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactMethodLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMethodLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DegreeOfRiskLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeOfRiskLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DelusionsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DelusionsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DischareReasonLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DischareReasonLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EatingPatternsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingPatternsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EligibilityLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EligibilityLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnglishLanguageSkillsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishLanguageSkillsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Error = table.Column<string>(maxLength: 8000, nullable: true),
                    ErrorSource = table.Column<string>(maxLength: 1000, nullable: true),
                    LoggedOn = table.Column<DateTime>(nullable: false),
                    LoggedBy = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EthnicityHispanicLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EthnicityHispanicLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpressiveLanguageLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpressiveLanguageLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EyeContactLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EyeContactLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacialExpressionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacialExpressionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyOriginLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyOriginLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FineMotorLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FineMotorLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirstDispositionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstDispositionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrustrationToleranceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrustrationToleranceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FutureOrientLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutureOrientLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GaitLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GaitLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenderLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralKnowledgeLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralKnowledgeLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GrossMotorLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossMotorLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HallucinationsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallucinationsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HygieneLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HygieneLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImpulseControlLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImpulseControlLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeSourceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeSourceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsightLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsightLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntakeMethodLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntakeMethodLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntellectualFunctionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntellectualFunctionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IntellectualLevelLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntellectualLevelLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JudgementLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudgementLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivingArrangementLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingArrangementLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatusLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatusLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MascularLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascularLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemoryLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemoryLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoodLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotorBehaviorLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorBehaviorLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrientationLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrientationLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OtherHarmLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherHarmLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhobiaLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhobiaLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreferredLanguageLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredLanguageLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PresentingProblemsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentingProblemsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProblemDomainLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemDomainLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptiveLanguageLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptiveLanguageLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralSourceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralSourceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationshipTypeLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationshipTypeLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidenceLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidenceLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelfHarmLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfHarmLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SelfSoothingCapacityLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelfSoothingCapacityLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SensoryCognitionLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensoryCognitionLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SensoryIntegrationLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensoryIntegrationLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceLocationLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceLocationLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SleepPatternsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepPatternsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialNeedsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialNeedsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpeechLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeechLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuicideLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuicideLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThoughtContentLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoughtContentLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThoughtProcessLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoughtProcessLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransitionsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitionsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentModalityLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentModalityLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnusualBehaviorPatternsLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnusualBehaviorPatternsLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrgencyLevelLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrgencyLevelLookup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    WidgetComponentId = table.Column<int>(nullable: false),
                    WidgetOrder = table.Column<int>(nullable: false),
                    IsMyStuff = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MedicalRecordNumber = table.Column<string>(maxLength: 20, nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: true),
                    Alias = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    SSN = table.Column<string>(maxLength: 11, nullable: true),
                    GenderLookupId = table.Column<int>(nullable: false),
                    RaceLookupId = table.Column<int>(nullable: false),
                    EthnicityHispanicLookupId = table.Column<int>(nullable: false),
                    MaritalStatusLookupId = table.Column<int>(nullable: false),
                    SpecialNeedsLookupId = table.Column<int>(nullable: false),
                    PreferredLanguageLookupId = table.Column<int>(nullable: false),
                    Photo = table.Column<byte[]>(nullable: true),
                    IsBillingAddress = table.Column<bool>(nullable: false),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    StateLookupId = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(maxLength: 5, nullable: true),
                    County = table.Column<string>(maxLength: 50, nullable: true),
                    PrimaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    CanLeaveMsgOnPriPhone = table.Column<bool>(nullable: false),
                    SecondaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    CanLeaveMsgOnSecPhone = table.Column<bool>(nullable: false),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_EthnicityHispanicLookup_EthnicityHispanicLookupId",
                        column: x => x.EthnicityHispanicLookupId,
                        principalTable: "EthnicityHispanicLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_GenderLookup_GenderLookupId",
                        column: x => x.GenderLookupId,
                        principalTable: "GenderLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_MaritalStatusLookup_MaritalStatusLookupId",
                        column: x => x.MaritalStatusLookupId,
                        principalTable: "MaritalStatusLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_PreferredLanguageLookup_PreferredLanguageLookupId",
                        column: x => x.PreferredLanguageLookupId,
                        principalTable: "PreferredLanguageLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_RaceLookup_RaceLookupId",
                        column: x => x.RaceLookupId,
                        principalTable: "RaceLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_SpecialNeedsLookup_SpecialNeedsLookupId",
                        column: x => x.SpecialNeedsLookupId,
                        principalTable: "SpecialNeedsLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_StateLookup_StateLookupId",
                        column: x => x.StateLookupId,
                        principalTable: "StateLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacilityCode = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    PrimaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    SecondaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    StateLookupId = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(maxLength: 5, nullable: true),
                    County = table.Column<string>(maxLength: 50, nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facilities_StateLookup_StateLookupId",
                        column: x => x.StateLookupId,
                        principalTable: "StateLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PayorType = table.Column<int>(nullable: false),
                    PayorName = table.Column<string>(maxLength: 250, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    StateLookupId = table.Column<int>(nullable: false),
                    Zip = table.Column<string>(maxLength: 10, nullable: true),
                    Phone = table.Column<string>(maxLength: 15, nullable: true),
                    Fax = table.Column<string>(maxLength: 15, nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payor_StateLookup_StateLookupId",
                        column: x => x.StateLookupId,
                        principalTable: "StateLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaseIntakes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    CaseNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CaseName = table.Column<string>(maxLength: 2000, nullable: false),
                    IntakeDate = table.Column<DateTime>(nullable: false),
                    IntakeTime = table.Column<DateTime>(nullable: false),
                    IntakeMethodLookupId = table.Column<int>(nullable: false),
                    UrgencyLevelLookupId = table.Column<int>(nullable: false),
                    ReferralSourceLookupId = table.Column<int>(nullable: true),
                    ReferralContactName = table.Column<string>(maxLength: 2000, nullable: false),
                    ReferralReason = table.Column<string>(maxLength: 2000, nullable: false),
                    PresentingProblems = table.Column<string>(maxLength: 2000, nullable: true),
                    AbuseLookupId = table.Column<int>(nullable: false),
                    AbuseDesc = table.Column<string>(maxLength: 1000, nullable: true),
                    PriorServicesDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    PriorHospitalizationDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    PriorMedicalConditionsAndTreatmentsDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    CurrentLivingSituationAndFamilyRelations = table.Column<string>(maxLength: 2000, nullable: true),
                    CaseFormulation = table.Column<string>(maxLength: 2000, nullable: true),
                    DsmDiagnosis = table.Column<string>(maxLength: 2000, nullable: true),
                    FirstDispositionLookupId = table.Column<int>(nullable: false),
                    IntakeTakendBy = table.Column<string>(maxLength: 100, nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    DateIntakeCompleted = table.Column<DateTime>(nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseIntakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_AbuseLookup_AbuseLookupId",
                        column: x => x.AbuseLookupId,
                        principalTable: "AbuseLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_FirstDispositionLookup_FirstDispositionLookupId",
                        column: x => x.FirstDispositionLookupId,
                        principalTable: "FirstDispositionLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_IntakeMethodLookup_IntakeMethodLookupId",
                        column: x => x.IntakeMethodLookupId,
                        principalTable: "IntakeMethodLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_ReferralSourceLookup_ReferralSourceLookupId",
                        column: x => x.ReferralSourceLookupId,
                        principalTable: "ReferralSourceLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CaseIntakes_UrgencyLevelLookup_UrgencyLevelLookupId",
                        column: x => x.UrgencyLevelLookupId,
                        principalTable: "UrgencyLevelLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientConditions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    ResidenceLookupId = table.Column<int>(nullable: false),
                    LivingArrangementLookupId = table.Column<int>(nullable: false),
                    FamilyOriginLookupId = table.Column<int>(nullable: false),
                    IncomeSourceLookupId = table.Column<int>(nullable: false),
                    MonthlyIncome = table.Column<double>(nullable: false),
                    Dependents = table.Column<int>(nullable: false),
                    PhysicianName = table.Column<string>(maxLength: 100, nullable: true),
                    PhysicianPhone = table.Column<string>(maxLength: 17, nullable: true),
                    ClinicName = table.Column<string>(maxLength: 500, nullable: true),
                    RecentClinicVisitDate = table.Column<DateTime>(nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientConditions_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientConditions_FamilyOriginLookup_FamilyOriginLookupId",
                        column: x => x.FamilyOriginLookupId,
                        principalTable: "FamilyOriginLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientConditions_IncomeSourceLookup_IncomeSourceLookupId",
                        column: x => x.IncomeSourceLookupId,
                        principalTable: "IncomeSourceLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientConditions_LivingArrangementLookup_LivingArrangementLookupId",
                        column: x => x.LivingArrangementLookupId,
                        principalTable: "LivingArrangementLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientConditions_ResidenceLookup_ResidenceLookupId",
                        column: x => x.ResidenceLookupId,
                        principalTable: "ResidenceLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guardians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(maxLength: 100, nullable: true),
                    Alias = table.Column<string>(maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(maxLength: 250, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    StateLookupId = table.Column<int>(nullable: true),
                    Zip = table.Column<string>(maxLength: 5, nullable: true),
                    PrimaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    SecondaryPhone = table.Column<string>(maxLength: 17, nullable: true),
                    GenderLookupId = table.Column<int>(nullable: true),
                    RelationshipTypeLookupId = table.Column<int>(nullable: false),
                    RaceLookupId = table.Column<int>(nullable: true),
                    EthnicityHispanicLookupId = table.Column<int>(nullable: true),
                    IsEmergencyContact = table.Column<bool>(nullable: false),
                    IsFinanciallyResponsible = table.Column<bool>(nullable: false),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guardians_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guardians_EthnicityHispanicLookup_EthnicityHispanicLookupId",
                        column: x => x.EthnicityHispanicLookupId,
                        principalTable: "EthnicityHispanicLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guardians_GenderLookup_GenderLookupId",
                        column: x => x.GenderLookupId,
                        principalTable: "GenderLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guardians_RaceLookup_RaceLookupId",
                        column: x => x.RaceLookupId,
                        principalTable: "RaceLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Guardians_RelationshipTypeLookup_RelationshipTypeLookupId",
                        column: x => x.RelationshipTypeLookupId,
                        principalTable: "RelationshipTypeLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guardians_StateLookup_StateLookupId",
                        column: x => x.StateLookupId,
                        principalTable: "StateLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacilityId = table.Column<int>(nullable: false),
                    LoginId = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Prefix = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    Suffix = table.Column<string>(maxLength: 50, nullable: true),
                    CellPhone = table.Column<string>(maxLength: 17, nullable: true),
                    LastActiveDate = table.Column<DateTime>(nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false),
                    RecordedBy = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coverages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    PayorId = table.Column<int>(nullable: true),
                    CoverageType = table.Column<int>(nullable: false),
                    CoverageRank = table.Column<int>(nullable: false),
                    EffectiveFrom = table.Column<DateTime>(nullable: true),
                    EffectiveUntil = table.Column<DateTime>(nullable: true),
                    PlanName = table.Column<string>(maxLength: 100, nullable: true),
                    GroupNumber = table.Column<string>(maxLength: 100, nullable: true),
                    MemberNumber = table.Column<string>(maxLength: 100, nullable: true),
                    CoPayAmount = table.Column<decimal>(nullable: false),
                    ContractedRateWithInsurer = table.Column<decimal>(nullable: false),
                    PriorAuthNumber = table.Column<string>(maxLength: 100, nullable: true),
                    PlanSubscriberEmployer = table.Column<string>(maxLength: 100, nullable: true),
                    InsuranceNotes = table.Column<string>(maxLength: 1000, nullable: true),
                    MedicaidNumber = table.Column<string>(maxLength: 1000, nullable: true),
                    MedicaidWorker = table.Column<string>(maxLength: 100, nullable: true),
                    MedicaidEligibilityNotes = table.Column<string>(maxLength: 2000, nullable: true),
                    EligibilityLookupId = table.Column<int>(nullable: true),
                    MedicareNumber = table.Column<string>(maxLength: 100, nullable: true),
                    MedicareA = table.Column<bool>(nullable: false),
                    MedicareB = table.Column<bool>(nullable: false),
                    MedicareD = table.Column<bool>(nullable: false),
                    MedicarePhone = table.Column<string>(maxLength: 17, nullable: true),
                    MedicareNotes = table.Column<string>(maxLength: 2000, nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coverages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coverages_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coverages_EligibilityLookup_EligibilityLookupId",
                        column: x => x.EligibilityLookupId,
                        principalTable: "EligibilityLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coverages_Payor_PayorId",
                        column: x => x.PayorId,
                        principalTable: "Payor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CaseDischarges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseIntakeId = table.Column<int>(nullable: false),
                    DischargeDate = table.Column<DateTime>(nullable: false),
                    DischargeTime = table.Column<DateTime>(nullable: true),
                    DischareReasonLookupId = table.Column<int>(nullable: false),
                    TransferredTo = table.Column<string>(maxLength: 200, nullable: true),
                    TransferredDate = table.Column<DateTime>(nullable: true),
                    ContactInfo = table.Column<string>(maxLength: 1000, nullable: true),
                    Phone = table.Column<string>(maxLength: 17, nullable: true),
                    DischargeRecommendation = table.Column<string>(maxLength: 1000, nullable: true),
                    PossiblePostDischargeProblems = table.Column<string>(maxLength: 1000, nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    DischargeCompletedBy = table.Column<string>(maxLength: 50, nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDischarges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseDischarges_CaseIntakes_CaseIntakeId",
                        column: x => x.CaseIntakeId,
                        principalTable: "CaseIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseDischarges_DischareReasonLookup_DischareReasonLookupId",
                        column: x => x.DischareReasonLookupId,
                        principalTable: "DischareReasonLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComprehensiveAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseIntakeId = table.Column<int>(nullable: false),
                    AssessmentDate = table.Column<DateTime>(nullable: false),
                    EducationLookupId = table.Column<int>(nullable: true),
                    EmploymentLookupId = table.Column<int>(nullable: true),
                    EmploymentHistory = table.Column<string>(maxLength: 2000, nullable: true),
                    RelationshipWithManagementDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    RelationshipWithPeersDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    SocialRelationshipDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    CommunityInvolvmentDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    School = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolTeacher = table.Column<string>(maxLength: 100, nullable: true),
                    SchoolGrade = table.Column<int>(nullable: true),
                    SchoolGPA = table.Column<decimal>(nullable: true),
                    RelationshipWithStaffDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    RelationshipWithClassmatesDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    SchoolAttendanceAndAdditionalNotesDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    SchoolEducationalAndVocationalGoalsDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    SchoolSpecialNeedsDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalSubstanceAbuseData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalMedicationData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalFamilyData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalDevelopmentalData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalBehavioralData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalEmotionalData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalSocialData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalPsychiatricData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalRecreationalData = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalNutritionalDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    HistoricalLegalIssuesDesc = table.Column<string>(maxLength: 2000, nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    DateAssessmentCompleted = table.Column<DateTime>(nullable: true),
                    AssessmentCompletedBy = table.Column<string>(maxLength: 50, nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprehensiveAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprehensiveAssessments_CaseIntakes_CaseIntakeId",
                        column: x => x.CaseIntakeId,
                        principalTable: "CaseIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprehensiveAssessments_EducationLookup_EducationLookupId",
                        column: x => x.EducationLookupId,
                        principalTable: "EducationLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComprehensiveAssessments_EmploymentLookup_EmploymentLookupId",
                        column: x => x.EmploymentLookupId,
                        principalTable: "EmploymentLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MentalHealthAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseIntakeId = table.Column<int>(nullable: false),
                    AssessmentDate = table.Column<DateTime>(nullable: false),
                    Appearance = table.Column<string>(maxLength: 2000, nullable: true),
                    BodyType = table.Column<string>(maxLength: 2000, nullable: true),
                    EyeContact = table.Column<string>(maxLength: 2000, nullable: true),
                    Hygiene = table.Column<string>(maxLength: 2000, nullable: true),
                    Attitude = table.Column<string>(maxLength: 2000, nullable: true),
                    BodyMovement = table.Column<string>(maxLength: 2000, nullable: true),
                    BehaviorWithExaminers = table.Column<string>(maxLength: 2000, nullable: true),
                    BehaviorWithCareGivers = table.Column<string>(maxLength: 2000, nullable: true),
                    FacialExpression = table.Column<string>(maxLength: 2000, nullable: true),
                    Interview = table.Column<string>(maxLength: 2000, nullable: true),
                    FineMotor = table.Column<string>(maxLength: 2000, nullable: true),
                    Gait = table.Column<string>(maxLength: 2000, nullable: true),
                    GrossMotor = table.Column<string>(maxLength: 2000, nullable: true),
                    Mascular = table.Column<string>(maxLength: 2000, nullable: true),
                    MotorBehavior = table.Column<string>(maxLength: 2000, nullable: true),
                    ActivityLevel = table.Column<string>(maxLength: 2000, nullable: true),
                    Affect = table.Column<string>(maxLength: 2000, nullable: true),
                    Alertness = table.Column<string>(maxLength: 2000, nullable: true),
                    Attention = table.Column<string>(maxLength: 2000, nullable: true),
                    Concentration = table.Column<string>(maxLength: 2000, nullable: true),
                    FrustrationTolerance = table.Column<string>(maxLength: 2000, nullable: true),
                    IntellectualLevel = table.Column<string>(maxLength: 2000, nullable: true),
                    IntellectualFunction = table.Column<string>(maxLength: 2000, nullable: true),
                    Mood = table.Column<string>(maxLength: 2000, nullable: true),
                    SelfSoothingCapacity = table.Column<string>(maxLength: 2000, nullable: true),
                    SensoryCognition = table.Column<string>(maxLength: 2000, nullable: true),
                    SensoryIntegration = table.Column<string>(maxLength: 2000, nullable: true),
                    Transitions = table.Column<string>(maxLength: 2000, nullable: true),
                    Associations = table.Column<string>(maxLength: 2000, nullable: true),
                    Delusions = table.Column<string>(maxLength: 2000, nullable: true),
                    Hallucinations = table.Column<string>(maxLength: 2000, nullable: true),
                    Insight = table.Column<string>(maxLength: 2000, nullable: true),
                    Judgement = table.Column<string>(maxLength: 2000, nullable: true),
                    Memory = table.Column<string>(maxLength: 2000, nullable: true),
                    Phobia = table.Column<string>(maxLength: 2000, nullable: true),
                    Orientation = table.Column<string>(maxLength: 2000, nullable: true),
                    FutureOrient = table.Column<string>(maxLength: 2000, nullable: true),
                    ThoughtContent = table.Column<string>(maxLength: 2000, nullable: true),
                    ThoughtProcess = table.Column<string>(maxLength: 2000, nullable: true),
                    ExpressiveLanguage = table.Column<string>(maxLength: 2000, nullable: true),
                    GeneralKnowledge = table.Column<string>(maxLength: 2000, nullable: true),
                    ReceptiveLanguage = table.Column<string>(maxLength: 2000, nullable: true),
                    Speech = table.Column<string>(maxLength: 2000, nullable: true),
                    EatingPatterns = table.Column<string>(maxLength: 2000, nullable: true),
                    SleepPatterns = table.Column<string>(maxLength: 2000, nullable: true),
                    UnusualBehaviorPattern = table.Column<string>(maxLength: 2000, nullable: true),
                    DegreeOfRisk = table.Column<string>(maxLength: 2000, nullable: true),
                    SelfHarm = table.Column<string>(maxLength: 2000, nullable: true),
                    OtherHarm = table.Column<string>(maxLength: 2000, nullable: true),
                    ImpulseControl = table.Column<string>(maxLength: 2000, nullable: true),
                    Suicide = table.Column<string>(maxLength: 2000, nullable: true),
                    DsmDiagnosis = table.Column<string>(maxLength: 2000, nullable: true),
                    AssessmentConducteddBy = table.Column<string>(maxLength: 50, nullable: true),
                    ConductingClinicianSignature = table.Column<byte[]>(nullable: true),
                    DateClinitianSignedOn = table.Column<DateTime>(nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    AssessmentCompletedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CompletingSupervisorSignature = table.Column<byte[]>(nullable: true),
                    DateSupervisorSignedOn = table.Column<DateTime>(nullable: true),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MentalHealthAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MentalHealthAssessments_CaseIntakes_CaseIntakeId",
                        column: x => x.CaseIntakeId,
                        principalTable: "CaseIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentPlans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseIntakeId = table.Column<int>(nullable: false),
                    PlanDate = table.Column<DateTime>(nullable: false),
                    PlanTime = table.Column<DateTime>(nullable: true),
                    PlanName = table.Column<string>(maxLength: 2000, nullable: true),
                    Problems = table.Column<string>(maxLength: 2000, nullable: true),
                    Strengths = table.Column<string>(maxLength: 2000, nullable: true),
                    LengthOfTreatment = table.Column<string>(maxLength: 500, nullable: true),
                    AttendingStaffNames = table.Column<string>(maxLength: 1000, nullable: true),
                    AttendingClientFamilyNames = table.Column<string>(maxLength: 1000, nullable: true),
                    ApproveddBySupervisor = table.Column<string>(nullable: true),
                    SupervisorSignature = table.Column<byte[]>(nullable: true),
                    DateSupervisorSigned = table.Column<DateTime>(nullable: true),
                    ClientSign = table.Column<string>(maxLength: 50, nullable: true),
                    ClientDigitalSignature = table.Column<byte[]>(nullable: true),
                    DateClientSigned = table.Column<DateTime>(nullable: true),
                    ReasonForNoClientSign = table.Column<string>(maxLength: 50, nullable: true),
                    IsLocked = table.Column<bool>(nullable: false),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreatmentPlans_CaseIntakes_CaseIntakeId",
                        column: x => x.CaseIntakeId,
                        principalTable: "CaseIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    AppUserId = table.Column<int>(nullable: false),
                    AppRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.AppUserId, x.AppRoleId });
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentGoals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TreatmentPlanId = table.Column<int>(nullable: false),
                    Problem = table.Column<string>(maxLength: 2000, nullable: false),
                    Goal = table.Column<string>(maxLength: 500, nullable: false),
                    TargetDate = table.Column<DateTime>(nullable: false),
                    Modalities = table.Column<string>(maxLength: 500, nullable: true),
                    FrequencyOfIntervention = table.Column<int>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false),
                    Outcome = table.Column<int>(nullable: false),
                    DateOfOutcome = table.Column<DateTime>(nullable: true),
                    ProgressRating = table.Column<int>(nullable: false),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreatmentGoals_TreatmentPlans_TreatmentPlanId",
                        column: x => x.TreatmentPlanId,
                        principalTable: "TreatmentPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseIntakeId = table.Column<int>(nullable: false),
                    DateOfService = table.Column<DateTime>(nullable: false),
                    TimeOfService = table.Column<DateTime>(nullable: true),
                    Duration = table.Column<float>(nullable: true),
                    IsNonBillable = table.Column<bool>(nullable: false),
                    BillingProcedureId = table.Column<int>(nullable: true),
                    TreatmentModalityLookupId = table.Column<int>(nullable: false),
                    ServiceLocationLookupId = table.Column<int>(nullable: false),
                    ContactMethodLookupId = table.Column<int>(nullable: false),
                    TreatmentGoalId = table.Column<int>(nullable: true),
                    AppUserId = table.Column<int>(nullable: false),
                    Narrative = table.Column<string>(nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    NotifyOthers = table.Column<bool>(nullable: false),
                    RecordedBy = table.Column<string>(maxLength: 50, nullable: false),
                    RecordedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_BillingProcedure_BillingProcedureId",
                        column: x => x.BillingProcedureId,
                        principalTable: "BillingProcedure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_CaseIntakes_CaseIntakeId",
                        column: x => x.CaseIntakeId,
                        principalTable: "CaseIntakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_ContactMethodLookup_ContactMethodLookupId",
                        column: x => x.ContactMethodLookupId,
                        principalTable: "ContactMethodLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_ServiceLocationLookup_ServiceLocationLookupId",
                        column: x => x.ServiceLocationLookupId,
                        principalTable: "ServiceLocationLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_TreatmentGoals_TreatmentGoalId",
                        column: x => x.TreatmentGoalId,
                        principalTable: "TreatmentGoals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgressNotes_TreatmentModalityLookup_TreatmentModalityLookupId",
                        column: x => x.TreatmentModalityLookupId,
                        principalTable: "TreatmentModalityLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppRoleId",
                table: "AppUserRoles",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_FacilityId",
                table: "AppUsers",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDischarges_CaseIntakeId",
                table: "CaseDischarges",
                column: "CaseIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDischarges_DischareReasonLookupId",
                table: "CaseDischarges",
                column: "DischareReasonLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_AbuseLookupId",
                table: "CaseIntakes",
                column: "AbuseLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_ClientId",
                table: "CaseIntakes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_FirstDispositionLookupId",
                table: "CaseIntakes",
                column: "FirstDispositionLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_IntakeMethodLookupId",
                table: "CaseIntakes",
                column: "IntakeMethodLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_ReferralSourceLookupId",
                table: "CaseIntakes",
                column: "ReferralSourceLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseIntakes_UrgencyLevelLookupId",
                table: "CaseIntakes",
                column: "UrgencyLevelLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConditions_ClientId",
                table: "ClientConditions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConditions_FamilyOriginLookupId",
                table: "ClientConditions",
                column: "FamilyOriginLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConditions_IncomeSourceLookupId",
                table: "ClientConditions",
                column: "IncomeSourceLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConditions_LivingArrangementLookupId",
                table: "ClientConditions",
                column: "LivingArrangementLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientConditions_ResidenceLookupId",
                table: "ClientConditions",
                column: "ResidenceLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_EthnicityHispanicLookupId",
                table: "Clients",
                column: "EthnicityHispanicLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_GenderLookupId",
                table: "Clients",
                column: "GenderLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MaritalStatusLookupId",
                table: "Clients",
                column: "MaritalStatusLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PreferredLanguageLookupId",
                table: "Clients",
                column: "PreferredLanguageLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RaceLookupId",
                table: "Clients",
                column: "RaceLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SpecialNeedsLookupId",
                table: "Clients",
                column: "SpecialNeedsLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_StateLookupId",
                table: "Clients",
                column: "StateLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprehensiveAssessments_CaseIntakeId",
                table: "ComprehensiveAssessments",
                column: "CaseIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprehensiveAssessments_EducationLookupId",
                table: "ComprehensiveAssessments",
                column: "EducationLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ComprehensiveAssessments_EmploymentLookupId",
                table: "ComprehensiveAssessments",
                column: "EmploymentLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Coverages_ClientId",
                table: "Coverages",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Coverages_EligibilityLookupId",
                table: "Coverages",
                column: "EligibilityLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Coverages_PayorId",
                table: "Coverages",
                column: "PayorId");

            migrationBuilder.CreateIndex(
                name: "IX_Facilities_StateLookupId",
                table: "Facilities",
                column: "StateLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_ClientId",
                table: "Guardians",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_EthnicityHispanicLookupId",
                table: "Guardians",
                column: "EthnicityHispanicLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_GenderLookupId",
                table: "Guardians",
                column: "GenderLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_RaceLookupId",
                table: "Guardians",
                column: "RaceLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_RelationshipTypeLookupId",
                table: "Guardians",
                column: "RelationshipTypeLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_Guardians_StateLookupId",
                table: "Guardians",
                column: "StateLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_MentalHealthAssessments_CaseIntakeId",
                table: "MentalHealthAssessments",
                column: "CaseIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payor_StateLookupId",
                table: "Payor",
                column: "StateLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_AppUserId",
                table: "ProgressNotes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_BillingProcedureId",
                table: "ProgressNotes",
                column: "BillingProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_CaseIntakeId",
                table: "ProgressNotes",
                column: "CaseIntakeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_ContactMethodLookupId",
                table: "ProgressNotes",
                column: "ContactMethodLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_ServiceLocationLookupId",
                table: "ProgressNotes",
                column: "ServiceLocationLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_TreatmentGoalId",
                table: "ProgressNotes",
                column: "TreatmentGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressNotes_TreatmentModalityLookupId",
                table: "ProgressNotes",
                column: "TreatmentModalityLookupId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentGoals_TreatmentPlanId",
                table: "TreatmentGoals",
                column: "TreatmentPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentPlans_CaseIntakeId",
                table: "TreatmentPlans",
                column: "CaseIntakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLevelLookup");

            migrationBuilder.DropTable(
                name: "AffectLookup");

            migrationBuilder.DropTable(
                name: "AlertnessLookup");

            migrationBuilder.DropTable(
                name: "AppearanceLookup");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AssociationsLookup");

            migrationBuilder.DropTable(
                name: "AttentionLookup");

            migrationBuilder.DropTable(
                name: "AttitudeLookup");

            migrationBuilder.DropTable(
                name: "BehaviorWithCareGiversLookup");

            migrationBuilder.DropTable(
                name: "BehaviorWithExaminersLookup");

            migrationBuilder.DropTable(
                name: "BodyMovementLookup");

            migrationBuilder.DropTable(
                name: "BodyTypeLookup");

            migrationBuilder.DropTable(
                name: "CaseDischarges");

            migrationBuilder.DropTable(
                name: "ClientConditions");

            migrationBuilder.DropTable(
                name: "ComprehensiveAssessments");

            migrationBuilder.DropTable(
                name: "ConcentrationLookup");

            migrationBuilder.DropTable(
                name: "Coverages");

            migrationBuilder.DropTable(
                name: "DegreeOfRiskLookup");

            migrationBuilder.DropTable(
                name: "DelusionsLookup");

            migrationBuilder.DropTable(
                name: "EatingPatternsLookup");

            migrationBuilder.DropTable(
                name: "EnglishLanguageSkillsLookup");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "ExpressiveLanguageLookup");

            migrationBuilder.DropTable(
                name: "EyeContactLookup");

            migrationBuilder.DropTable(
                name: "FacialExpressionLookup");

            migrationBuilder.DropTable(
                name: "FineMotorLookup");

            migrationBuilder.DropTable(
                name: "FrustrationToleranceLookup");

            migrationBuilder.DropTable(
                name: "FutureOrientLookup");

            migrationBuilder.DropTable(
                name: "GaitLookup");

            migrationBuilder.DropTable(
                name: "GeneralKnowledgeLookup");

            migrationBuilder.DropTable(
                name: "GrossMotorLookup");

            migrationBuilder.DropTable(
                name: "Guardians");

            migrationBuilder.DropTable(
                name: "HallucinationsLookup");

            migrationBuilder.DropTable(
                name: "HygieneLookup");

            migrationBuilder.DropTable(
                name: "ImpulseControlLookup");

            migrationBuilder.DropTable(
                name: "InsightLookup");

            migrationBuilder.DropTable(
                name: "IntellectualFunctionLookup");

            migrationBuilder.DropTable(
                name: "IntellectualLevelLookup");

            migrationBuilder.DropTable(
                name: "InterviewLookup");

            migrationBuilder.DropTable(
                name: "JudgementLookup");

            migrationBuilder.DropTable(
                name: "MascularLookup");

            migrationBuilder.DropTable(
                name: "MemoryLookup");

            migrationBuilder.DropTable(
                name: "MentalHealthAssessments");

            migrationBuilder.DropTable(
                name: "MoodLookup");

            migrationBuilder.DropTable(
                name: "MotorBehaviorLookup");

            migrationBuilder.DropTable(
                name: "OrientationLookup");

            migrationBuilder.DropTable(
                name: "OtherHarmLookup");

            migrationBuilder.DropTable(
                name: "PhobiaLookup");

            migrationBuilder.DropTable(
                name: "PresentingProblemsLookup");

            migrationBuilder.DropTable(
                name: "ProblemDomainLookup");

            migrationBuilder.DropTable(
                name: "ProgramsLookup");

            migrationBuilder.DropTable(
                name: "ProgressNotes");

            migrationBuilder.DropTable(
                name: "ReceptiveLanguageLookup");

            migrationBuilder.DropTable(
                name: "SchoolsLookup");

            migrationBuilder.DropTable(
                name: "SelfHarmLookup");

            migrationBuilder.DropTable(
                name: "SelfSoothingCapacityLookup");

            migrationBuilder.DropTable(
                name: "SensoryCognitionLookup");

            migrationBuilder.DropTable(
                name: "SensoryIntegrationLookup");

            migrationBuilder.DropTable(
                name: "SleepPatternsLookup");

            migrationBuilder.DropTable(
                name: "SpeechLookup");

            migrationBuilder.DropTable(
                name: "SuicideLookup");

            migrationBuilder.DropTable(
                name: "ThoughtContentLookup");

            migrationBuilder.DropTable(
                name: "ThoughtProcessLookup");

            migrationBuilder.DropTable(
                name: "TransitionsLookup");

            migrationBuilder.DropTable(
                name: "UnusualBehaviorPatternsLookup");

            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "DischareReasonLookup");

            migrationBuilder.DropTable(
                name: "FamilyOriginLookup");

            migrationBuilder.DropTable(
                name: "IncomeSourceLookup");

            migrationBuilder.DropTable(
                name: "LivingArrangementLookup");

            migrationBuilder.DropTable(
                name: "ResidenceLookup");

            migrationBuilder.DropTable(
                name: "EducationLookup");

            migrationBuilder.DropTable(
                name: "EmploymentLookup");

            migrationBuilder.DropTable(
                name: "EligibilityLookup");

            migrationBuilder.DropTable(
                name: "Payor");

            migrationBuilder.DropTable(
                name: "RelationshipTypeLookup");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "BillingProcedure");

            migrationBuilder.DropTable(
                name: "ContactMethodLookup");

            migrationBuilder.DropTable(
                name: "ServiceLocationLookup");

            migrationBuilder.DropTable(
                name: "TreatmentGoals");

            migrationBuilder.DropTable(
                name: "TreatmentModalityLookup");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "TreatmentPlans");

            migrationBuilder.DropTable(
                name: "CaseIntakes");

            migrationBuilder.DropTable(
                name: "AbuseLookup");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "FirstDispositionLookup");

            migrationBuilder.DropTable(
                name: "IntakeMethodLookup");

            migrationBuilder.DropTable(
                name: "ReferralSourceLookup");

            migrationBuilder.DropTable(
                name: "UrgencyLevelLookup");

            migrationBuilder.DropTable(
                name: "EthnicityHispanicLookup");

            migrationBuilder.DropTable(
                name: "GenderLookup");

            migrationBuilder.DropTable(
                name: "MaritalStatusLookup");

            migrationBuilder.DropTable(
                name: "PreferredLanguageLookup");

            migrationBuilder.DropTable(
                name: "RaceLookup");

            migrationBuilder.DropTable(
                name: "SpecialNeedsLookup");

            migrationBuilder.DropTable(
                name: "StateLookup");
        }
    }
}
