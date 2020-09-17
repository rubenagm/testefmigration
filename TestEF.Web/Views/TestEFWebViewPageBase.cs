using Abp.Web.Mvc.Views;

namespace TestEF.Web.Views
{
    public abstract class TestEFWebViewPageBase : TestEFWebViewPageBase<dynamic>
    {

    }

    public abstract class TestEFWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestEFWebViewPageBase()
        {
            LocalizationSourceName = TestEFConsts.LocalizationSourceName;
        }
    }
}