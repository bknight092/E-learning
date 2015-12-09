using System.Reflection;
using Abp.Modules;

namespace E-learning
{
    public class E-learningCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
