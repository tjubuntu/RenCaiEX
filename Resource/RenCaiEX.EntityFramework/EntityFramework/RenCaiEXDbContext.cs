using System.Data.Common;
using Abp.Zero.EntityFramework;
using RenCaiEX.Authorization.Roles;
using RenCaiEX.MultiTenancy;
using RenCaiEX.Users;
using System.Data.Entity;
using RenCaiEX.Corporations;
using RenCaiEX.Educations;
using RenCaiEX.Experiences;
using RenCaiEX.Logos;
using RenCaiEX.Resumes;
using RenCaiEX.Trainings;
using RenCaiEX.Recruitments;

namespace RenCaiEX.EntityFramework
{
    public class RenCaiEXDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Corporation> Corporations { get; set; }
        public virtual IDbSet<Recruitment> Recruitments { get; set; }
        public virtual IDbSet<Training> Trainings { get; set; }
        public virtual IDbSet<Education> Educations { get; set; }
        public virtual IDbSet<Experience> Experiences { get; set; }
        public virtual IDbSet<Logo> Logos { get; set; }
        public virtual IDbSet<Resume> Resumes { get; set; }
        public virtual IDbSet<JobHunter> JobHunters { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public RenCaiEXDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in RenCaiEXDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of RenCaiEXDbContext since ABP automatically handles it.
         */
        public RenCaiEXDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public RenCaiEXDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
