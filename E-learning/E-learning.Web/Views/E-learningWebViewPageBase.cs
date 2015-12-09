using Abp.Web.Mvc.Views;

namespace E-learning.Web.Views
{
    public abstract class E-learningWebViewPageBase : E-learningWebViewPageBase<dynamic>
    {

    }

    public abstract class E-learningWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected E-learningWebViewPageBase()
        {
            LocalizationSourceName = E-learningConsts.LocalizationSourceName;
        }
    }
}