using ClubModels.Configuration.GeneralCodes;
using ClubModels.Models;
using ClubModels.Models.GeneralCodes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubModels
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        { }

        #region Db Sets
        //public DbSet<Member> members { get; set; }
        public DbSet<CityCode> cityCodes { get; set; }
        public DbSet<GenderCode> genderCodes { get; set; }
        public DbSet<JobCode> jobCodes { get; set; }
        public DbSet<MartialStatusCode> martialStatusCodes { get; set; }
        public DbSet<MembershipCode> membershipCodes { get; set; }
        public DbSet<NationalityCode> nationalityCodes { get; set; }
        public DbSet<QualificationCode> qualificationCodes { get; set; }
        public DbSet<ReferenceCode> referenceCodes { get; set; }
        public DbSet<ReligionCode> religionCodes { get; set; }
        public DbSet<SectionCode> sectionCodes { get; set; }
        public DbSet<TitleCode> titleCodes { get; set; }
        public DbSet<TransferCode> transferCodes { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configrations
            modelBuilder.ApplyConfiguration(new CityCodesConfiguration());
            modelBuilder.ApplyConfiguration(new GenderCodesConfiguration());
            modelBuilder.ApplyConfiguration(new JobCodesConfiguration());
            modelBuilder.ApplyConfiguration(new MartialStatusCodesConfiguration());
            modelBuilder.ApplyConfiguration(new MembershipCodesConfiguration());
            modelBuilder.ApplyConfiguration(new NationalityCodesConfiguration());
            modelBuilder.ApplyConfiguration(new QualificationCodesConfiguration());
            modelBuilder.ApplyConfiguration(new ReferenceCodesConfiguration());
            modelBuilder.ApplyConfiguration(new ReligionCodesConfiguration());
            modelBuilder.ApplyConfiguration(new SectionCodesConfiguration());
            modelBuilder.ApplyConfiguration(new TitleCodesConfiguration());
            modelBuilder.ApplyConfiguration(new TransferCodesConfiguration());
            #endregion

            #region Indexs
            modelBuilder.Entity<CityCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<GenderCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<JobCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<MartialStatusCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<MembershipCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<NationalityCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<QualificationCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<ReferenceCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<ReligionCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<SectionCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<TitleCode>().HasIndex(e => e.Code).IsUnique();
            modelBuilder.Entity<TransferCode>().HasIndex(e => e.Code).IsUnique();
            #endregion
        }
    }
}
