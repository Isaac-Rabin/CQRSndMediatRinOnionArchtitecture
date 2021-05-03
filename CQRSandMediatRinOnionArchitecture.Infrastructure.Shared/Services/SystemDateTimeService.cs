using CQRSandMediatRinOnionArchitecture.Application.Interfaces.Shared;
using System;

namespace CQRSandMediatRinOnionArchitecture.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}