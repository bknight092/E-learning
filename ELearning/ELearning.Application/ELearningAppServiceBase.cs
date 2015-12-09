using Abp.Application.Services;

namespace ELearning
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ELearningAppServiceBase : ApplicationService
    {
        protected ELearningAppServiceBase()
        {
            LocalizationSourceName = ELearningConsts.LocalizationSourceName;
        }
    }
}