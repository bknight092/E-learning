using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace E-learning
{
    [DependsOn(typeof(AbpWebApiModule), typeof(E-learningApplicationModule))]
    public class E-learningWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(E-learningApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
