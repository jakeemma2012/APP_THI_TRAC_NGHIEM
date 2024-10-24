using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace APP_THI_TRAC_NGHIEM_DAL.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Attempt> Attempts { get; set; }
        public virtual DbSet<ExamQuestion> ExamQuestions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAnswer> StudentAnswers { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.Attempts)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Exams)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Feedbacks)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.CreatedBy);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.StudentAnswers)
                .WithOptional(e => e.Account)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Attempts)
                .WithOptional(e => e.Exam)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.ExamQuestions)
                .WithOptional(e => e.Exam)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Feedbacks)
                .WithOptional(e => e.Exam)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.Results)
                .WithOptional(e => e.Exam)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Exam>()
                .HasMany(e => e.StudentAnswers)
                .WithOptional(e => e.Exam)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ExamQuestions)
                .WithOptional(e => e.Question)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.StudentAnswers)
                .WithOptional(e => e.Question)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Subject)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.Subject)
                .HasForeignKey(e => e.TeacherSubjectsID)
                .WillCascadeOnDelete(false);
        }
    }
}
