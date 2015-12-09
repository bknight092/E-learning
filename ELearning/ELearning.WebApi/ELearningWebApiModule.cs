using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace ELearning
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ELearningApplicationModule))]
    public class ELearningWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ELearningApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
