using Microsoft.AspNetCore.Mvc;

namespace CQRSandMediatRinOnionArchitecture.Web.Views.Shared.Components.Culture
{
    public class CultureViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}