using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Models
{
    public partial class EnrollmentSystemContext : DbContext
    {
        public EnrollmentSystemContext()
        {
        }

        public EnrollmentSystemContext(DbContextOptions<EnrollmentSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCourse> TblCourses { get; set; }
        public virtual DbSet<TblFeedback> TblFeedbacks { get; set; }
        public virtual DbSet<TblGrade> TblGrades { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblStatusCourse> TblStatusCourses { get; set; }
        public virtual DbSet<TblStatusUser> TblStatusUsers { get; set; }
        public virtual DbSet<TblSubject> TblSubjects { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=EnrollmentSystem;uid=sa;pwd=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("tblCourses");

                entity.Property(e => e.CourseId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("courseID");

                entity.Property(e => e.CoursetName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("coursetName");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.LecturerId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lecturerID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.StatusId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("statusID");

                entity.Property(e => e.StudentQuantity).HasColumnName("studentQuantity");

                entity.Property(e => e.SubjectId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("subjectID");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.LecturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSubjects_tblUsers1");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSubjects_tblStatusSubjects");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TblCourses)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCourses_tblSubject");
            });

            modelBuilder.Entity<TblFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId)
                    .HasName("PK_tblFeedback_1");

                entity.ToTable("tblFeedback");

                entity.Property(e => e.FeedbackId)
                    .ValueGeneratedNever()
                    .HasColumnName("feedbackID");

                entity.Property(e => e.CourseId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("courseID");

                entity.Property(e => e.FeedbackContent)
                    .HasColumnType("ntext")
                    .HasColumnName("feedbackContent");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFeedback_tblCourses");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblFeedbacks)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFeedback_tblUsers");
            });

            modelBuilder.Entity<TblGrade>(entity =>
            {
                entity.HasKey(e => e.GradeId)
                    .HasName("PK_tblGradeList");

                entity.ToTable("tblGrades");

                entity.Property(e => e.GradeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gradeID");

                entity.Property(e => e.CourseId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("courseID");

                entity.Property(e => e.FinalTest).HasColumnName("finalTest");

                entity.Property(e => e.MidTermTest).HasColumnName("midTermTest");

                entity.Property(e => e.PracticalTest)
                    .HasMaxLength(10)
                    .HasColumnName("practicalTest")
                    .IsFixedLength(true);

                entity.Property(e => e.ProgressTest).HasColumnName("progressTest");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("studentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TblGrades)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGrades_tblSubjects");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblGrades)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblGrades_tblUsers");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tblRoles");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("roleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<TblStatusCourse>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblStatusCourses");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("statusID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<TblStatusUser>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblStatusUsers");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("statusID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .HasColumnName("statusName");
            });

            modelBuilder.Entity<TblSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("tblSubject");

                entity.Property(e => e.SubjectId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("subjectID");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(100)
                    .HasColumnName("subjectName");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUsers");

                entity.Property(e => e.UserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("roleID");

                entity.Property(e => e.StatusId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("statusID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("userName");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsers_tblRoles");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsers_tblStatusUsers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
