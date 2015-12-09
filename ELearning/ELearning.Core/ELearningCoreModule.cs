using System.Reflection;
using Abp.Modules;

namespace ELearning
{
    public class ELearningCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
