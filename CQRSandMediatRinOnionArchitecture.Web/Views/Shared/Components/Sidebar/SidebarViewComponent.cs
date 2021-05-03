using Microsoft.AspNetCore.Mvc;

namespace CQRSandMediatRinOnionArchitecture.Web.Views.Shared.Components.Sidebar
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}