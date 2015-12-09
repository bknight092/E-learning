using Abp.Web.Mvc.Views;

namespace ELearning.Web.Views
{
    public abstract class ELearningWebViewPageBase : ELearningWebViewPageBase<dynamic>
    {

    }

    public abstract class ELearningWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ELearningWebViewPageBase()
        {
            LocalizationSourceName = ELearningConsts.LocalizationSourceName;
        }
    }
}