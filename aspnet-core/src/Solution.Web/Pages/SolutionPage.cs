using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Solution.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Solution.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Solution.Web.Pages.SolutionPage
     */
    public abstract class SolutionPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<SolutionResource> L { get; set; }
    }
}
