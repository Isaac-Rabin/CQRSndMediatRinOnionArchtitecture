using System;

namespace CQRSandMediatRinOnionArchitecture.Application.Interfaces.Shared
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}