using Abp.Application.Services;

namespace E-learning
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class E-learningAppServiceBase : ApplicationService
    {
        protected E-learningAppServiceBase()
        {
            LocalizationSourceName = E-learningConsts.LocalizationSourceName;
        }
    }
}