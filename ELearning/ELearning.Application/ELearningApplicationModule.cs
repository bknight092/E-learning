using System.Reflection;
using Abp.Modules;

namespace ELearning
{
    [DependsOn(typeof(ELearningCoreModule))]
    public class ELearningApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
