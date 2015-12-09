using Abp.Web.Mvc.Controllers;

namespace E-learning.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class E-learningControllerBase : AbpController
    {
        protected E-learningControllerBase()
        {
            LocalizationSourceName = E-learningConsts.LocalizationSourceName;
        }
    }
}