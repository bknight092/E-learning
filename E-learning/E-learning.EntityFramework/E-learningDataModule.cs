using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using E-learning.EntityFramework;

namespace E-learning
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(E-learningCoreModule))]
    public class E-learningDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<E-learningDbContext>(null);
        }
    }
}
