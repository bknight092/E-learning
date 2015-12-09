using System.Reflection;
using Abp.Modules;

namespace E-learning
{
    [DependsOn(typeof(E-learningCoreModule))]
    public class E-learningApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
