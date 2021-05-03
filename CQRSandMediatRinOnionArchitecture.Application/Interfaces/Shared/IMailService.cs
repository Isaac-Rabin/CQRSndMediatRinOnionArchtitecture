using CQRSandMediatRinOnionArchitecture.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace CQRSandMediatRinOnionArchitecture.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}