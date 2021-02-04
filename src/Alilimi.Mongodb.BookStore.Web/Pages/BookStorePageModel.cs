using Alilimi.Mongodb.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Alilimi.Mongodb.BookStore.Web.Pages
{
    public abstract class BookStorePageModel : AbpPageModel
    {
        protected BookStorePageModel()
        {
            LocalizationResourceType = typeof(BookStoreResource);
        }
    }
}