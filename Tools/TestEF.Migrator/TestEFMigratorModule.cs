using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TestEF.EntityFramework;

namespace TestEF.Migrator
{
    [DependsOn(typeof(TestEFDataModule))]
    public class TestEFMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestEFDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}