using Abp.Web.Mvc.Views;

namespace RenCaiEX.Web.Views
{
    public abstract class RenCaiEXWebViewPageBase : RenCaiEXWebViewPageBase<dynamic>
    {

    }

    public abstract class RenCaiEXWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected RenCaiEXWebViewPageBase()
        {
            LocalizationSourceName = RenCaiEXConsts.LocalizationSourceName;
        }
    }
}