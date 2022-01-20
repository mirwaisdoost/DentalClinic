using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DentalClinic.Models
{
    public partial class DentalClinicContext : IdentityDbContext
    {
        public DentalClinicContext(DbContextOptions<DentalClinicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DrugElement> DrugElement { get; set; }
        public virtual DbSet<DrugType> DrugType { get; set; }
        public virtual DbSet<FeeElement> FeeElement { get; set; }
        public virtual DbSet<FeeType> FeeType { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<HistoryElement> HistoryElement { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientCheckFee> PatientCheckFee { get; set; }
        public virtual DbSet<PatientHistory> PatientHistory { get; set; }
        public virtual DbSet<PatientRegisteration> PatientRegisteration { get; set; }
        public virtual DbSet<PatientRegisterationCheck> PatientRegisterationCheck { get; set; }
        public virtual DbSet<PatientRegisterationCheckDrug> PatientRegisterationCheckDrug { get; set; }
        public virtual DbSet<PatientRegisterationPayment> PatientRegisterationPayment { get; set; }
        public virtual DbSet<PatientTeeth> PatientTeeth { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGroup> StudentGroup { get; set; }
        public virtual DbSet<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<TeethNumber> TeethNumber { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(Local); Initial Catalog=DentalClinic; integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("company");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("doctor");

                entity.Property(e => e.DoctorId).HasColumnName("doctorID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasColumnName("fatherName")
                    .HasMaxLength(50);

                entity.Property(e => e.JobLocation)
                    .HasColumnName("jobLocation")
                    .HasMaxLength(50);

                entity.Property(e => e.Jop)
                    .HasColumnName("jop")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
            
            modelBuilder.Entity<DrugType>(entity =>
            {
                entity.ToTable("drugType");

                entity.Property(e => e.DrugTypeId).HasColumnName("drugTypeID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<DrugElement>(entity =>
            {
                entity.ToTable("drugElement");

                entity.Property(e => e.DrugElementId).HasColumnName("drugElementID");

                entity.Property(e => e.CompanyId).HasColumnName("companyID");

                entity.Property(e => e.DrugTypeId).HasColumnName("drugTypeID");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DrugElement)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__drugEleme__compa__08B54D69");

                entity.HasOne(d => d.DrugType)
                    .WithMany(p => p.DrugElement)
                    .HasForeignKey(d => d.DrugTypeId)
                    .HasConstraintName("FK__drugEleme__drugT__09A971A2");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.ToTable("feeType");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<FeeElement>(entity =>
            {
                entity.ToTable("feeElement");

                entity.Property(e => e.FeeElementId).HasColumnName("feeElementID");

                entity.Property(e => e.Fee).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FeeTypeId).HasColumnName("feeTypeID");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.HasOne(d => d.FeeType)
                    .WithMany(p => p.FeeElement)
                    .HasForeignKey(d => d.FeeTypeId)
                    .HasConstraintName("FK__feeElemen__feeTy__07C12930");
            });
                    

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<HistoryElement>(entity =>
            {
                entity.ToTable("historyElement");

                entity.Property(e => e.HistoryElementId).HasColumnName("historyElementID");

                entity.Property(e => e.ApplyToGender).HasColumnName("applyToGender");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.ApplyToGenderNavigation)
                    .WithMany(p => p.HistoryElement)
                    .HasForeignKey(d => d.ApplyToGender)
                    .HasConstraintName("FK__historyEl__apply__361203C5");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(70);

                entity.Property(e => e.DataOfBrith)
                    .HasColumnName("dataOfBrith")
                    .HasColumnType("date");

                entity.Property(e => e.GenderId).HasColumnName("genderID");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__patient__genderI__12C8C788");
            });

            modelBuilder.Entity<PatientRegisteration>(entity =>
            {
                entity.ToTable("patientRegisteration");

                entity.Property(e => e.PatientRegisterationId)
                    .HasColumnName("patientRegisterationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DoctorId).HasColumnName("doctorID");

                entity.Property(e => e.PatientId).HasColumnName("patientID");

                entity.Property(e => e.RgisterationFee)
                    .HasColumnName("rgisterationFee")
                    .HasColumnType("decimal(7, 2)");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.PatientRegisteration)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__patientRe__docto__114A936A");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientRegisteration)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__patientRe__patie__10566F31");
            });

            modelBuilder.Entity<PatientRegisterationCheck>(entity =>
            {
                entity.ToTable("patientRegisterationCheck");

                entity.Property(e => e.PatientRegisterationCheckId)
                    .HasColumnName("patientRegisterationCheckID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CheckDate)
                    .HasColumnName("checkDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientRegisterationId).HasColumnName("patientRegisterationID");

                entity.HasOne(d => d.PatientRegisteration)
                    .WithMany(p => p.PatientRegisterationCheck)
                    .HasForeignKey(d => d.PatientRegisterationId)
                    .HasConstraintName("FK__patientRe__patie__0C85DE4D");
            });

            modelBuilder.Entity<PatientRegisterationCheckDrug>(entity =>
            {
                entity.ToTable("patientRegisterationCheckDrug");

                entity.Property(e => e.PatientRegisterationCheckDrugId).HasColumnName("patientRegisterationCheckDrugID");

                entity.Property(e => e.DrugElementId).HasColumnName("drugElementID");

                entity.Property(e => e.PatientRegisterationCheckId).HasColumnName("patientRegisterationCheckID");

                entity.Property(e => e.Price).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.DrugElement)
                    .WithMany(p => p.PatientRegisterationCheckDrug)
                    .HasForeignKey(d => d.DrugElementId)
                    .HasConstraintName("FK__patientRe__drugE__6FE99F9F");

                entity.HasOne(d => d.PatientRegisterationCheck)
                    .WithMany(p => p.PatientRegisterationCheckDrug)
                    .HasForeignKey(d => d.PatientRegisterationCheckId)
                    .HasConstraintName("FK__patientRe__patie__01142BA1");
            });

            modelBuilder.Entity<PatientCheckFee>(entity =>
            {
                entity.ToTable("patientCheckFee");

                entity.Property(e => e.PatientCheckFeeId).HasColumnName("patientCheckFeeID");

                entity.Property(e => e.Fee).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.FeeElementId).HasColumnName("feeElementID");

                entity.Property(e => e.PatientRegisterationCheckId).HasColumnName("patientRegisterationCheckID");

                entity.HasOne(d => d.FeeElement)
                    .WithMany(p => p.PatientCheckFee)
                    .HasForeignKey(d => d.FeeElementId)
                    .HasConstraintName("FK__patientCh__feeEl__0D7A0286");

                entity.HasOne(d => d.PatientRegisterationCheck)
                    .WithMany(p => p.PatientCheckFee)
                    .HasForeignKey(d => d.PatientRegisterationCheckId)
                    .HasConstraintName("FK__patientCh__patie__0E6E26BF");
            });

            modelBuilder.Entity<PatientHistory>(entity =>
            {
                entity.ToTable("patientHistory");

                entity.Property(e => e.PatientHistoryId).HasColumnName("patientHistoryID");

                entity.Property(e => e.HistoryElementId).HasColumnName("historyElementID");

                entity.Property(e => e.PatientRegisterationId).HasColumnName("patientRegisterationID");

                entity.HasOne(d => d.HistoryElement)
                    .WithMany(p => p.PatientHistory)
                    .HasForeignKey(d => d.HistoryElementId)
                    .HasConstraintName("FK__patientHi__histo__03F0984C");

                entity.HasOne(d => d.PatientRegisteration)
                    .WithMany(p => p.PatientHistory)
                    .HasForeignKey(d => d.PatientRegisterationId)
                    .HasConstraintName("FK__patientHi__patie__02FC7413");
            });
                     
            modelBuilder.Entity<PatientRegisterationPayment>(entity =>
            {
                entity.ToTable("patientRegisterationPayment");

                entity.Property(e => e.PatientRegisterationPaymentId)
                    .HasColumnName("patientRegisterationPaymentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.DrugTotal)
                    .HasColumnName("drugTotal")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FeeTotal)
                    .HasColumnName("feeTotal")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PatientRegisterationCheckId).HasColumnName("patientRegisterationCheckID");

                entity.Property(e => e.Payed).HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.PatientRegisterationCheck)
                    .WithMany(p => p.PatientRegisterationPayment)
                    .HasForeignKey(d => d.PatientRegisterationCheckId)
                    .HasConstraintName("FK__patientRe__patie__0F624AF8");
            });

            modelBuilder.Entity<TeethNumber>(entity =>
            {
                entity.ToTable("teethNumber");

                entity.Property(e => e.TeethNumberId).HasColumnName("teethNumberID");

                entity.Property(e => e.AduOrChd)
                    .HasColumnName("aduOrChd")
                    .HasMaxLength(50);

                entity.Property(e => e.LeftOrRight)
                    .HasColumnName("leftOrRight")
                    .HasMaxLength(50);

                entity.Property(e => e.TopOrButtom)
                    .HasColumnName("topOrButtom")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PatientTeeth>(entity =>
            {
                entity.ToTable("patientTeeth");

                entity.Property(e => e.PatientTeethId).HasColumnName("patientTeethID");

                entity.Property(e => e.PatientRegisterationId).HasColumnName("patientRegisterationID");

                entity.Property(e => e.TeethNumberId).HasColumnName("teethNumberID");

                entity.HasOne(d => d.PatientRegisteration)
                    .WithMany(p => p.PatientTeeth)
                    .HasForeignKey(d => d.PatientRegisterationId)
                    .HasConstraintName("FK__patientTe__patie__123EB7A3");

                entity.HasOne(d => d.TeethNumber)
                    .WithMany(p => p.PatientTeeth)
                    .HasForeignKey(d => d.TeethNumberId)
                    .HasConstraintName("FK__patientTe__teeth__1332DBDC");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("semester");

                entity.Property(e => e.SemesterId).HasColumnName("semesterID");

                entity.Property(e => e.Name).HasMaxLength(15);
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("session");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.StudentId)
                    .HasColumnName("studentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FatherName)
                    .HasColumnName("fatherName")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentGroup>(entity =>
            {
                entity.ToTable("studentGroup");

                entity.Property(e => e.StudentGroupId).HasColumnName("studentGroupID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });


            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("subject");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });


            modelBuilder.Entity<StudentSessionGroupDoctor>(entity =>
            {
                entity.Property(e => e.StudentSessionGroupDoctorId).HasColumnName("StudentSessionGroupDoctorID");

                entity.Property(e => e.DoctorId).HasColumnName("doctorID");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.SemesterId).HasColumnName("semesterID");

                entity.Property(e => e.SessionId).HasColumnName("sessionID");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.Property(e => e.SubjectId).HasColumnName("subjectID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__StudentSe__docto__7A3223E8");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK__StudentSe__group__793DFFAF");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__StudentSe__semes__2CBDA3B5");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK__StudentSe__sessi__7755B73D");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentSe__stude__7849DB76");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.StudentSessionGroupDoctor)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__StudentSe__subje__3FD07829");
            });
   

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();
            });
        }
    }
}
