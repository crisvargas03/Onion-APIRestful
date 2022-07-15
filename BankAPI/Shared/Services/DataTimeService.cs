using Application.Interfaces;

namespace Shared.Services
{
    public class DataTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
