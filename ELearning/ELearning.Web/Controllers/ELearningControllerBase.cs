using Abp.Web.Mvc.Controllers;

namespace ELearning.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ELearningControllerBase : AbpController
    {
        protected ELearningControllerBase()
        {
            LocalizationSourceName = ELearningConsts.LocalizationSourceName;
        }
    }
}