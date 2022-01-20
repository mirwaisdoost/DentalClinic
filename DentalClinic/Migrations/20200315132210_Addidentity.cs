using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalClinic.Migrations
{
    public partial class Addidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    companyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.companyID);
                });

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    doctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    fatherName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    jop = table.Column<string>(maxLength: 50, nullable: true),
                    jobLocation = table.Column<string>(maxLength: 50, nullable: true),
                    phone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor", x => x.doctorID);
                });

            migrationBuilder.CreateTable(
                name: "drugType",
                columns: table => new
                {
                    drugTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugType", x => x.drugTypeID);
                });

            migrationBuilder.CreateTable(
                name: "feeType",
                columns: table => new
                {
                    feeTypeID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feeType", x => x.feeTypeID);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "semester",
                columns: table => new
                {
                    semesterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semester", x => x.semesterID);
                });

            migrationBuilder.CreateTable(
                name: "session",
                columns: table => new
                {
                    sessionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_session", x => x.sessionID);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    fatherName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    phone = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student", x => x.studentID);
                });

            migrationBuilder.CreateTable(
                name: "studentGroup",
                columns: table => new
                {
                    studentGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentGroup", x => x.studentGroupID);
                });

            migrationBuilder.CreateTable(
                name: "subject",
                columns: table => new
                {
                    subjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject", x => x.subjectID);
                });

            migrationBuilder.CreateTable(
                name: "teethNumber",
                columns: table => new
                {
                    teethNumberID = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    leftOrRight = table.Column<string>(maxLength: 50, nullable: false),
                    topOrButtom = table.Column<string>(maxLength: 50, nullable: false),
                    aduOrChd = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teethNumber", x => x.teethNumberID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "drugElement",
                columns: table => new
                {
                    drugElementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    price = table.Column<decimal>(type: "decimal(7, 2)", nullable: false),
                    companyID = table.Column<int>(nullable: false),
                    drugTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drugElement", x => x.drugElementID);
                    table.ForeignKey(
                        name: "FK__drugEleme__compa__08B54D69",
                        column: x => x.companyID,
                        principalTable: "company",
                        principalColumn: "companyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__drugEleme__drugT__09A971A2",
                        column: x => x.drugTypeID,
                        principalTable: "drugType",
                        principalColumn: "drugTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feeElement",
                columns: table => new
                {
                    feeElementID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(7, 2)", nullable: false),
                    feeTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feeElement", x => x.feeElementID);
                    table.ForeignKey(
                        name: "FK__feeElemen__feeTy__07C12930",
                        column: x => x.feeTypeID,
                        principalTable: "feeType",
                        principalColumn: "feeTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historyElement",
                columns: table => new
                {
                    historyElementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    applyToGender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historyElement", x => x.historyElementID);
                    table.ForeignKey(
                        name: "FK__historyEl__apply__361203C5",
                        column: x => x.applyToGender,
                        principalTable: "gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    patientID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(maxLength: 50, nullable: false),
                    genderID = table.Column<int>(nullable: false),
                    dataOfBrith = table.Column<DateTime>(type: "date", nullable: false),
                    job = table.Column<string>(maxLength: 50, nullable: true),
                    address = table.Column<string>(maxLength: 70, nullable: true),
                    phone = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.patientID);
                    table.ForeignKey(
                        name: "FK__patient__genderI__12C8C788",
                        column: x => x.genderID,
                        principalTable: "gender",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentSessionGroupDoctor",
                columns: table => new
                {
                    StudentSessionGroupDoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sessionID = table.Column<int>(nullable: false),
                    studentID = table.Column<int>(nullable: true),
                    groupID = table.Column<int>(nullable: false),
                    doctorID = table.Column<int>(nullable: false),
                    semesterID = table.Column<int>(nullable: false),
                    subjectID = table.Column<int>(nullable: false),
                    Duration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentSessionGroupDoctor", x => x.StudentSessionGroupDoctorID);
                    table.ForeignKey(
                        name: "FK__StudentSe__docto__7A3223E8",
                        column: x => x.doctorID,
                        principalTable: "doctor",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__StudentSe__group__793DFFAF",
                        column: x => x.groupID,
                        principalTable: "studentGroup",
                        principalColumn: "studentGroupID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__StudentSe__semes__2CBDA3B5",
                        column: x => x.semesterID,
                        principalTable: "semester",
                        principalColumn: "semesterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__StudentSe__sessi__7755B73D",
                        column: x => x.sessionID,
                        principalTable: "session",
                        principalColumn: "sessionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__StudentSe__stude__7849DB76",
                        column: x => x.studentID,
                        principalTable: "student",
                        principalColumn: "studentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__StudentSe__subje__3FD07829",
                        column: x => x.subjectID,
                        principalTable: "subject",
                        principalColumn: "subjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientRegisteration",
                columns: table => new
                {
                    patientRegisterationID = table.Column<int>(nullable: false),
                    patientID = table.Column<int>(nullable: false),
                    doctorID = table.Column<int>(nullable: false),
                    rgisterationFee = table.Column<decimal>(type: "decimal(7, 2)", nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientRegisteration", x => x.patientRegisterationID);
                    table.ForeignKey(
                        name: "FK__patientRe__docto__114A936A",
                        column: x => x.doctorID,
                        principalTable: "doctor",
                        principalColumn: "doctorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__patientRe__patie__10566F31",
                        column: x => x.patientID,
                        principalTable: "patient",
                        principalColumn: "patientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientHistory",
                columns: table => new
                {
                    patientHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    patientRegisterationID = table.Column<int>(nullable: true),
                    historyElementID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientHistory", x => x.patientHistoryID);
                    table.ForeignKey(
                        name: "FK__patientHi__histo__03F0984C",
                        column: x => x.historyElementID,
                        principalTable: "historyElement",
                        principalColumn: "historyElementID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__patientHi__patie__02FC7413",
                        column: x => x.patientRegisterationID,
                        principalTable: "patientRegisteration",
                        principalColumn: "patientRegisterationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientRegisterationCheck",
                columns: table => new
                {
                    patientRegisterationCheckID = table.Column<int>(nullable: false),
                    checkDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Note = table.Column<string>(nullable: true),
                    patientRegisterationID = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientRegisterationCheck", x => x.patientRegisterationCheckID);
                    table.ForeignKey(
                        name: "FK__patientRe__patie__0C85DE4D",
                        column: x => x.patientRegisterationID,
                        principalTable: "patientRegisteration",
                        principalColumn: "patientRegisterationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patientRegisterationCheck_student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "student",
                        principalColumn: "studentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientTeeth",
                columns: table => new
                {
                    patientTeethID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    patientRegisterationID = table.Column<int>(nullable: true),
                    teethNumberID = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientTeeth", x => x.patientTeethID);
                    table.ForeignKey(
                        name: "FK__patientTe__patie__123EB7A3",
                        column: x => x.patientRegisterationID,
                        principalTable: "patientRegisteration",
                        principalColumn: "patientRegisterationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__patientTe__teeth__1332DBDC",
                        column: x => x.teethNumberID,
                        principalTable: "teethNumber",
                        principalColumn: "teethNumberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "patientCheckFee",
                columns: table => new
                {
                    patientCheckFeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    feeElementID = table.Column<int>(nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(7, 2)", nullable: true),
                    patientRegisterationCheckID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientCheckFee", x => x.patientCheckFeeID);
                    table.ForeignKey(
                        name: "FK__patientCh__feeEl__0D7A0286",
                        column: x => x.feeElementID,
                        principalTable: "feeElement",
                        principalColumn: "feeElementID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__patientCh__patie__0E6E26BF",
                        column: x => x.patientRegisterationCheckID,
                        principalTable: "patientRegisterationCheck",
                        principalColumn: "patientRegisterationCheckID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientRegisterationCheckDrug",
                columns: table => new
                {
                    patientRegisterationCheckDrugID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    drugElementID = table.Column<int>(nullable: true),
                    patientRegisterationCheckID = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(7, 2)", nullable: true),
                    quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientRegisterationCheckDrug", x => x.patientRegisterationCheckDrugID);
                    table.ForeignKey(
                        name: "FK__patientRe__drugE__6FE99F9F",
                        column: x => x.drugElementID,
                        principalTable: "drugElement",
                        principalColumn: "drugElementID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__patientRe__patie__01142BA1",
                        column: x => x.patientRegisterationCheckID,
                        principalTable: "patientRegisterationCheck",
                        principalColumn: "patientRegisterationCheckID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patientRegisterationPayment",
                columns: table => new
                {
                    patientRegisterationPaymentID = table.Column<int>(nullable: false),
                    drugTotal = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    feeTotal = table.Column<decimal>(type: "decimal(15, 2)", nullable: true),
                    Payed = table.Column<decimal>(type: "decimal(15, 2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    patientRegisterationCheckID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientRegisterationPayment", x => x.patientRegisterationPaymentID);
                    table.ForeignKey(
                        name: "FK__patientRe__patie__0F624AF8",
                        column: x => x.patientRegisterationCheckID,
                        principalTable: "patientRegisterationCheck",
                        principalColumn: "patientRegisterationCheckID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_drugElement_companyID",
                table: "drugElement",
                column: "companyID");

            migrationBuilder.CreateIndex(
                name: "IX_drugElement_drugTypeID",
                table: "drugElement",
                column: "drugTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_feeElement_feeTypeID",
                table: "feeElement",
                column: "feeTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_historyElement_applyToGender",
                table: "historyElement",
                column: "applyToGender");

            migrationBuilder.CreateIndex(
                name: "IX_patient_genderID",
                table: "patient",
                column: "genderID");

            migrationBuilder.CreateIndex(
                name: "IX_patientCheckFee_feeElementID",
                table: "patientCheckFee",
                column: "feeElementID");

            migrationBuilder.CreateIndex(
                name: "IX_patientCheckFee_patientRegisterationCheckID",
                table: "patientCheckFee",
                column: "patientRegisterationCheckID");

            migrationBuilder.CreateIndex(
                name: "IX_patientHistory_historyElementID",
                table: "patientHistory",
                column: "historyElementID");

            migrationBuilder.CreateIndex(
                name: "IX_patientHistory_patientRegisterationID",
                table: "patientHistory",
                column: "patientRegisterationID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisteration_doctorID",
                table: "patientRegisteration",
                column: "doctorID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisteration_patientID",
                table: "patientRegisteration",
                column: "patientID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisterationCheck_patientRegisterationID",
                table: "patientRegisterationCheck",
                column: "patientRegisterationID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisterationCheck_StudentId",
                table: "patientRegisterationCheck",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisterationCheckDrug_drugElementID",
                table: "patientRegisterationCheckDrug",
                column: "drugElementID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisterationCheckDrug_patientRegisterationCheckID",
                table: "patientRegisterationCheckDrug",
                column: "patientRegisterationCheckID");

            migrationBuilder.CreateIndex(
                name: "IX_patientRegisterationPayment_patientRegisterationCheckID",
                table: "patientRegisterationPayment",
                column: "patientRegisterationCheckID");

            migrationBuilder.CreateIndex(
                name: "IX_patientTeeth_patientRegisterationID",
                table: "patientTeeth",
                column: "patientRegisterationID");

            migrationBuilder.CreateIndex(
                name: "IX_patientTeeth_teethNumberID",
                table: "patientTeeth",
                column: "teethNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_doctorID",
                table: "StudentSessionGroupDoctor",
                column: "doctorID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_groupID",
                table: "StudentSessionGroupDoctor",
                column: "groupID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_semesterID",
                table: "StudentSessionGroupDoctor",
                column: "semesterID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_sessionID",
                table: "StudentSessionGroupDoctor",
                column: "sessionID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_studentID",
                table: "StudentSessionGroupDoctor",
                column: "studentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentSessionGroupDoctor_subjectID",
                table: "StudentSessionGroupDoctor",
                column: "subjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "patientCheckFee");

            migrationBuilder.DropTable(
                name: "patientHistory");

            migrationBuilder.DropTable(
                name: "patientRegisterationCheckDrug");

            migrationBuilder.DropTable(
                name: "patientRegisterationCheckFeeElement");

            migrationBuilder.DropTable(
                name: "patientRegisterationPayment");

            migrationBuilder.DropTable(
                name: "patientTeeth");

            migrationBuilder.DropTable(
                name: "StudentSessionGroupDoctor");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "feeElement");

            migrationBuilder.DropTable(
                name: "historyElement");

            migrationBuilder.DropTable(
                name: "drugElement");

            migrationBuilder.DropTable(
                name: "patientRegisterationCheck");

            migrationBuilder.DropTable(
                name: "teethNumber");

            migrationBuilder.DropTable(
                name: "studentGroup");

            migrationBuilder.DropTable(
                name: "semester");

            migrationBuilder.DropTable(
                name: "session");

            migrationBuilder.DropTable(
                name: "subject");

            migrationBuilder.DropTable(
                name: "feeType");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "drugType");

            migrationBuilder.DropTable(
                name: "patientRegisteration");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "patient");

            migrationBuilder.DropTable(
                name: "gender");
        }
    }
}
