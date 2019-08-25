SET XACT_ABORT ON
BEGIN TRANSACTION

INSERT [dbo].[AppUserLogins] ([UserName], [Password],[IsActive] ) VALUES (N'Erfan'    , N'erfan'      ,1 )
INSERT [dbo].[AppUserLogins] ([UserName], [Password],[IsActive] ) VALUES (N'David'    , N'david'      ,1 )
INSERT [dbo].[AppUserLogins] ([UserName], [Password],[IsActive] ) VALUES (N'Patty'    , N'patty'      ,1 )

INSERT [dbo].[AppUsers] ([Id],[Prefix], [FirstName],[Middle], [LastName], [Suffix],[UserTypesLookupId], LastActiveDate, CreatedOn ) VALUES (1,N'Dr.', N'Erfan'    , N'B.', N'Card'      ,'LMT',2,'2016-01-01','2016-01-01'  )
INSERT [dbo].[AppUsers] ([Id],[Prefix], [FirstName],[Middle], [LastName], [Suffix],[UserTypesLookupId], LastActiveDate, CreatedOn  ) VALUES (2,N'Dr.', N'David'    , N'B.', N'Aaron'     ,'LMT',2,'2016-01-01','2016-01-01' )
INSERT [dbo].[AppUsers] ([Id],[Prefix], [FirstName],[Middle], [LastName], [Suffix],[UserTypesLookupId], LastActiveDate, CreatedOn  ) VALUES (3,N'Dr.', N'Aimee'    , N'B.', N'Gee'       ,'LMT',2,'2016-01-01','2016-01-01' )

INSERT [dbo].[AppRoles] ([Id],[Role], [Description]) VALUES (1,N'Therapist'    , N'Staff Therapist')
INSERT [dbo].[AppRoles] ([Id],[Role], [Description]) VALUES (2,N'Supervisor'   , N'Supervisor')
INSERT [dbo].[AppRoles] ([Id],[Role], [Description]) VALUES (3,N'Directory'    , N'Directory')

INSERT [dbo].[AppUserRoles] ([RoleId],[UserId]) VALUES (1,1)
INSERT [dbo].[AppUserRoles] ([RoleId],[UserId]) VALUES (1,2)
INSERT [dbo].[AppUserRoles] ([RoleId],[UserId]) VALUES (1,3)


SET IDENTITY_INSERT [dbo].[Clients] ON

INSERT [dbo].[Clients] ([Id], [ClientReferenceCode], [FirstName], [LastName], 
[MiddleInitial], [Alias], [DateOfBirth], [SSN], [Address], [City], [State], [Zip], [County], [Notes], 
[PrimaryPhone], [CanLeaveMsgOnPriPhone], [SecondaryPhone], [CanLeaveMsgOnSecPhone], [GenderLookupId], 
[EthnicityLookupId], [MaritalStatusLookupId], [ClientStatusLookupId], [SpecialNeedsLookupId], 
[PreferredLanguageLookupId], [IncomeSourceLookupId], [ResidenceLookupId], [MonthlyIncome], 
[Dependents], [RecordedBy], [RecordedOn]) 
VALUES (1, N'OR100221', N'Steve', N'Smith', N'A', N'Stevie', CAST(N'2000-11-01' AS Date), N'123457894', 
N'1234 Somewhere Lane', N'Portland', N'OR', N'97210', NULL, N'Some notes about this client.', N'5031221234', 1, 
N'5035551212', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1000, 0, N'david', CAST(N'2016-01-30 14:51:59.523' AS DateTime))

INSERT [dbo].[Clients] ([Id], [ClientReferenceCode], [FirstName], [LastName], 
[MiddleInitial], [Alias], [DateOfBirth], [SSN], [Address], [City], [State], [Zip], [County], [Notes], 
[PrimaryPhone], [CanLeaveMsgOnPriPhone], [SecondaryPhone], [CanLeaveMsgOnSecPhone], [GenderLookupId], 
[EthnicityLookupId], [MaritalStatusLookupId], [ClientStatusLookupId], [SpecialNeedsLookupId], 
[PreferredLanguageLookupId], [IncomeSourceLookupId], [ResidenceLookupId], [MonthlyIncome], 
[Dependents], [RecordedBy], [RecordedOn]) 
VALUES (2, N'OR100221', N'Martin', N'McFly', N'A', N'Marty', CAST(N'2000-11-01' AS Date), N'123457894', 
N'1234 Somewhere Lane', N'Portland', N'OR', N'97210', NULL, N'Some notes about this client.', N'5031221234', 1, 
N'5035551212',  1, 1, 1, 1, 1, 1, 1, 1, 1, 1000, 0, N'david', CAST(N'2016-01-30 14:51:59.523' AS DateTime))

INSERT [dbo].[Clients] ([Id], [ClientReferenceCode], [FirstName], [LastName], 
[MiddleInitial], [Alias], [DateOfBirth], [SSN], [Address], [City], [State], [Zip], [County], [Notes], 
[PrimaryPhone], [CanLeaveMsgOnPriPhone], [SecondaryPhone], [CanLeaveMsgOnSecPhone], [GenderLookupId], 
[EthnicityLookupId], [MaritalStatusLookupId], [ClientStatusLookupId], [SpecialNeedsLookupId], 
[PreferredLanguageLookupId], [IncomeSourceLookupId], [ResidenceLookupId], [MonthlyIncome], 
[Dependents], [RecordedBy], [RecordedOn]) 
VALUES (3, N'OR100221', N'John', N'Doe', N'A', N'Jay', CAST(N'2000-11-01' AS Date), N'123457894', 
N'1234 Somewhere Lane', N'Portland', N'OR', N'97210', NULL, N'Some notes about this client.', N'5031221234', 1, 
N'5035551212',  1, 1, 1, 1, 1, 1, 1, 1, 1, 1000, 0, N'david', CAST(N'2016-01-30 14:51:59.523' AS DateTime))

INSERT [dbo].[Clients] ([Id], [ClientReferenceCode], [FirstName], [LastName], 
[MiddleInitial], [Alias], [DateOfBirth], [SSN], [Address], [City], [State], [Zip], [County], [Notes], 
[PrimaryPhone], [CanLeaveMsgOnPriPhone], [SecondaryPhone], [CanLeaveMsgOnSecPhone], [GenderLookupId], 
[EthnicityLookupId], [MaritalStatusLookupId], [ClientStatusLookupId], [SpecialNeedsLookupId], 
[PreferredLanguageLookupId], [IncomeSourceLookupId], [ResidenceLookupId], [MonthlyIncome], 
[Dependents], [RecordedBy], [RecordedOn]) 
VALUES (4, N'OR100221', N'Jillian', N'Doe', N'A', N'Jill', CAST(N'2000-11-01' AS Date), N'123457894', 
N'1234 Somewhere Lane', N'Portland', N'OR', N'97210', NULL, N'Some notes about this client.', N'5031221234', 1, 
N'5035551212',  1, 1, 1, 1, 1, 1, 1, 1, 1, 1000, 0, N'david', CAST(N'2016-01-30 14:51:59.523' AS DateTime))

SET IDENTITY_INSERT [dbo].[Clients] OFF

INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 1, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 1, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 2, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 2, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 3, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
INSERT [dbo].[ClientAddresses] ([ClientId], [Address], [City], [State], [Zip], [RecordedBy], [RecordedOn]) VALUES ( 3, N'4321 Another Address St.', N'Portland', N'OR', N'97210', N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))


INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (1, N'Darla', N'Smith', CAST(N'1975-11-01 00:00:00.000' AS DateTime), NULL, N'Portland', N'OR', N'97210', NULL, NULL, N'The mother of our client', 2, 1, 0, 0, N'david', CAST(N'2016-01-30 14:52:00.763' AS DateTime))
INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (1, N'David', N'Smith', CAST(N'2016-02-19 00:00:00.000' AS DateTime), N'124124 ', N'124124', N'12', N'12412', N'124124', N'124124124', N'31141', 1, 1, 0, 0, N'david', CAST(N'2016-02-06 09:51:34.550' AS DateTime))
INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (2, N'Darla', N'Smith', CAST(N'1975-11-01 00:00:00.000' AS DateTime), NULL, N'Portland', N'OR', N'97210', NULL, NULL, N'The mother of our client', 2, 1, 0, 0, N'david', CAST(N'2016-01-30 14:52:00.763' AS DateTime))
INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (2, N'David', N'Smith', CAST(N'2016-02-19 00:00:00.000' AS DateTime), N'124124 ', N'124124', N'12', N'12412', N'124124', N'124124124', N'31141', 1, 1, 0, 0, N'david', CAST(N'2016-02-06 09:51:34.550' AS DateTime))
INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (3, N'Darla', N'Smith', CAST(N'1975-11-01 00:00:00.000' AS DateTime), NULL, N'Portland', N'OR', N'97210', NULL, NULL, N'The mother of our client', 2, 1, 0, 0, N'david', CAST(N'2016-01-30 14:52:00.763' AS DateTime))
INSERT [dbo].[ClientContacts] ([ClientId], [FirstName], [LastName], [DateOfBirth], [Address], [City], [State], [Zip], [HomePhone], [CellPhone], [Notes], [GenderLookupId], [RelationshipTypeLookupId], [IsEmergencyContact], [IsFinanciallyResponsible], [RecordedBy], [RecordedOn]) VALUES (3, N'David', N'Smith', CAST(N'2016-02-19 00:00:00.000' AS DateTime), N'124124 ', N'124124', N'12', N'12412', N'124124', N'124124124', N'31141', 1, 1, 0, 0, N'david', CAST(N'2016-02-06 09:51:34.550' AS DateTime))

INSERT [dbo].[StaffAssignments] ([ClientId],[StaffId]) VALUES (1,1)
INSERT [dbo].[StaffAssignments] ([ClientId],[StaffId]) VALUES (2,1)
INSERT [dbo].[StaffAssignments] ([ClientId],[StaffId]) VALUES (3,1)
INSERT [dbo].[StaffAssignments] ([ClientId],[StaffId]) VALUES (4,2)

--SET IDENTITY_INSERT [dbo].[MentalHealthNotes] ON 
--INSERT [dbo].[MentalHealthNotes] ([Id], [ClientId], [MentalHealthNotesDate], [MentalHealthNotesJson], [MentalHealthNotesSummaryDesc], [RecordedBy], [RecordedOn]) VALUES (1, 1, CAST(N'2016-01-10' AS Date), NULL, NULL, N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
--INSERT [dbo].[MentalHealthNotes] ([Id], [ClientId], [MentalHealthNotesDate], [MentalHealthNotesJson], [MentalHealthNotesSummaryDesc], [RecordedBy], [RecordedOn]) VALUES (2, 2, CAST(N'2016-01-10' AS Date), NULL, NULL, N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))
--INSERT [dbo].[MentalHealthNotes] ([Id], [ClientId], [MentalHealthNotesDate], [MentalHealthNotesJson], [MentalHealthNotesSummaryDesc], [RecordedBy], [RecordedOn]) VALUES (3, 3, CAST(N'2016-01-10' AS Date), NULL, NULL, N'david', CAST(N'2016-01-30 14:52:00.820' AS DateTime))

--SET IDENTITY_INSERT [dbo].[MentalHealthNotes] OFF
--SET IDENTITY_INSERT [dbo].[AdmitDischarges] ON 
--INSERT [dbo].[AdmitDischarges] ([Id], [ClientId], [ProgramTherapistId], [ProgramId], [ScreeningDate], [PaperworkDate], [AdmitDate], [DischargeDate], [ReferralSourceLookupId], [UrgencyLevelLookupId], [FirstActivityLookupId], [ReferralContactName], [ReferralReason], [DischargeReasonId], [DischargeRecommendation], [PossiblePostDischargeProblems], [ReferralDischargeId], [RecordedBy], [RecordedOn]) VALUES (1, 1, 1, 1, CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), NULL, 1, 1, 1, N'John Doe', N'needed some help', NULL, NULL, NULL, NULL, N'david', CAST(N'2016-02-06 11:41:16.893' AS DateTime))
--INSERT [dbo].[AdmitDischarges] ([Id], [ClientId], [ProgramTherapistId], [ProgramId], [ScreeningDate], [PaperworkDate], [AdmitDate], [DischargeDate], [ReferralSourceLookupId], [UrgencyLevelLookupId], [FirstActivityLookupId], [ReferralContactName], [ReferralReason], [DischargeReasonId], [DischargeRecommendation], [PossiblePostDischargeProblems], [ReferralDischargeId], [RecordedBy], [RecordedOn]) VALUES (2, 2, 1, 1, CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), NULL, 1, 1, 1, N'John Doe', N'needed some help', NULL, NULL, NULL, NULL, N'david', CAST(N'2016-02-06 11:41:16.893' AS DateTime))
--INSERT [dbo].[AdmitDischarges] ([Id], [ClientId], [ProgramTherapistId], [ProgramId], [ScreeningDate], [PaperworkDate], [AdmitDate], [DischargeDate], [ReferralSourceLookupId], [UrgencyLevelLookupId], [FirstActivityLookupId], [ReferralContactName], [ReferralReason], [DischargeReasonId], [DischargeRecommendation], [PossiblePostDischargeProblems], [ReferralDischargeId], [RecordedBy], [RecordedOn]) VALUES (3, 3, 1, 1, CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), CAST(N'2016-01-09' AS Date), NULL, 1, 1, 1, N'John Doe', N'needed some help', NULL, NULL, NULL, NULL, N'david', CAST(N'2016-02-06 11:41:16.893' AS DateTime))

--SET IDENTITY_INSERT [dbo].[AdmitDischarges] OFF






--INSERT [dbo].[ProgressNotes] ([ClientId], [DateOfService], InvoiceIt


--INSERT [dbo].[InvoiceItems] ([ClientId], [ProgramsLookupId], [TherapistId],	[Notes],	[InvoiceId],	[Quantity],						[OverrideAmount],[OverrideUnitPrice],[AttendedBy],[IsBillable],[RecordedBy],[RecordedOn], [BillingCodeId]) VALUES (1,1,1,NULL,NULL, CAST(2.00 AS Decimal(18, 2)),NULL, NULL,NULL,1,N'david',CAST(N'2016-01-30 14:52:02.613' AS DateTime),	1)
--INSERT [dbo].[InvoiceItems] ([ClientId], [ProgramsLookupId], [TherapistId], [Notes], [InvoiceId], [Quantity], [OverrideAmount], [OverrideUnitPrice],  [AttendedBy], [IsBillable], [RecordedBy], [RecordedOn], [BillingCodeId]) VALUES (2, 1, 1, NULL, NULL, CAST(2.00 AS Decimal(18, 2)), NULL, NULL, NULL, 1, N'david', CAST(N'2016-01-30 14:52:02.613' AS DateTime), 1)
--INSERT [dbo].[InvoiceItems] ([ClientId], [ProgramsLookupId], [TherapistId], [Notes], [InvoiceId], [Quantity], [OverrideAmount], [OverrideUnitPrice],  [AttendedBy], [IsBillable], [RecordedBy], [RecordedOn], [BillingCodeId]) VALUES (3, 1, 1, NULL, NULL, CAST(2.00 AS Decimal(18, 2)), NULL, NULL, NULL, 1, N'david', CAST(N'2016-01-30 14:52:02.613' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Payors] ON 
INSERT [dbo].[Payors] ([Id], [PayorType], [PayorName], [Address], [City], [State], [Zip], [Phone], [Fax], [RecordedBy], [RecordedOn]) VALUES (1, 0, N'Blue Cross', N'12233 Somewhere Ln', N'Portland', N'OR', N'97203', N'5031244222', N'12345678', N'david', CAST(N'2016-01-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Payors] OFF


COMMIT TRAN