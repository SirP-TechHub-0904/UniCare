using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class jk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MailSystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retries = table.Column<int>(type: "int", nullable: false),
                    NotificationStatus = table.Column<int>(type: "int", nullable: false),
                    NotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserStatus = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangePass = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalInsNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeTel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoYouHavePermissionToWorkInTheUk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoYouHaveAValidPassport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YouHaveAValidWorkPermit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoYouHaveAccessToACarWhichCanBeUsedForWorkPurposes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoYouHoldAFullUkDrivingLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorPostcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoctorPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullTime_PartTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfPartTime_HowManyHoursPerWeekDoYouWantToWork_HomeCareAndPopInVisits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeCareAndPopInVisits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hospitals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nursing_ResidentialHomes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morning_Day_Evening_NightSleeperDuty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PleaseStateIfYouAreAbleToWorkAsA24_HourResidential_Live_In_Care = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfYes_WouldYouLike_LongOrShort_Assignments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WouldYouAcceptALive_InAssignmentSomeDistanceFromYourHome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfNo_PleaseSpecifyPreferredAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bath_Shower_StripWash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PressureAreaCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedBath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SimpleDressingProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseOfBathAids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssistingWithMedication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shaving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MouthCareIncDentures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareOfHair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareOfFeetExcToeNails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LightHousework = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CareOfFingerNails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WashingPersonalLaundry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dressing_Undressing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shopping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BedMaking_ChangingBedLinen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectingBenefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContinenceCare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bedpans_CommodesEtc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangingACatheterBag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Confidentiality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmptyingCatheterBag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportWriting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordingInstructionsFromGp_DistrictNurse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observing_Recording = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManeuveringAndHandlingCourse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangesInClientsCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseOfHoistsMan_Elec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UseOfWalkingAids = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrivateHouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nursing_Residential = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Home = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registereddisability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnregisteredDisability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nodisability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginWhiteEuropean = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginWhiteOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginBlackAfrican = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginBlackCaribbean = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginBlackOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Indian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginPakistani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginChinese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EthnicOriginOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowDidYouHearAboutThePost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreYouRelatedOrDoYouKnowAnyMemberOfStaffAtChosenHealthcare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HaveYouEverBeenConvictedOfACriminalOffence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IfYesPleaseGiveDetailsOfAllConvictionsAndCautionsIncludingSpentConvictionsAndCautions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Profile_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Profile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IncomeTax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NationalInsurance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NINumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P45 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Profile_UserId",
                        column: x => x.UserId,
                        principalTable: "Profile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    All = table.Column<bool>(type: "bit", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Profile_UserId",
                        column: x => x.UserId,
                        principalTable: "Profile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserTimeSheets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Break = table.Column<int>(type: "int", nullable: false),
                    TimeSheetId = table.Column<int>(type: "int", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    GeneratedInvoice = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimesheetAcceptance = table.Column<int>(type: "int", nullable: false),
                    AcceptedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcceptanceExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserSheetStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserSheetEndTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTimeSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTimeSheets_Profile_UserId",
                        column: x => x.UserId,
                        principalTable: "Profile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserTimeSheets_TimeSheets_TimeSheetId",
                        column: x => x.TimeSheetId,
                        principalTable: "TimeSheets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationReferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEmployer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationReferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationReferences_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmploymentHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfEmployer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneOfEmployer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOfEmployer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionDuties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentHistories_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthQualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthQualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthQualifications_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OccupationalHealthAssessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationalHealthAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupationalHealthAssessments_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualificationsItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolCollege = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GradeResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatesFromTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualifications_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vacinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacinations_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationReferences_ApplicationId",
                table: "ApplicationReferences",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId1",
                table: "Applications",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicationId",
                table: "Documents",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentHistories_ApplicationId",
                table: "EmploymentHistories",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthQualifications_ApplicationId",
                table: "HealthQualifications",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationalHealthAssessments_ApplicationId",
                table: "OccupationalHealthAssessments",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_ApplicationId",
                table: "Qualifications",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTimeSheets_TimeSheetId",
                table: "UserTimeSheets",
                column: "TimeSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTimeSheets_UserId",
                table: "UserTimeSheets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacinations_ApplicationId",
                table: "Vacinations",
                column: "ApplicationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationReferences");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EmploymentHistories");

            migrationBuilder.DropTable(
                name: "HealthQualifications");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "MailSystems");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OccupationalHealthAssessments");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "UserRotas");

            migrationBuilder.DropTable(
                name: "UserTimeSheets");

            migrationBuilder.DropTable(
                name: "Vacinations");

            migrationBuilder.DropTable(
                name: "TimeSheets");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Profile");
        }
    }
}
