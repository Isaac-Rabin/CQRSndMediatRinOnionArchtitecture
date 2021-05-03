using Microsoft.AspNetCore.Mvc;

namespace CQRSandMediatRinOnionArchitecture.Web.Views.Shared.Components.Title
{
    public class TitleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}