using System.Threading.Tasks;

namespace CQRSandMediatRinOnionArchitecture.Web.Abstractions
{
    public interface IViewRenderService
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}