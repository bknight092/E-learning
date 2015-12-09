using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ELearning.EntityFramework;

namespace ELearning
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ELearningCoreModule))]
    public class ELearningDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ELearningDbContext>(null);
        }
    }
}
