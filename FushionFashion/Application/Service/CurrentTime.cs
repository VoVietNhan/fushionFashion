using Application.Interface;

namespace Application.Service
{
    public class CurrentTime : ICurrentTime
    {
        DateTime ICurrentTime.CurrentTime() => DateTime.UtcNow.AddHours(7);
    }
}
