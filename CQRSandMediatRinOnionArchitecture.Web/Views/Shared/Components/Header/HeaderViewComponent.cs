using Microsoft.AspNetCore.Mvc;

namespace CQRSandMediatRinOnionArchitecture.Web.Views.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}