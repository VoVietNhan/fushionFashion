using Application.Interface;
using System.Security.Claims;

namespace API.Service
{
    public class ClaimService : IClaimService
    {
        public ClaimService(IHttpContextAccessor httpContextAccessor)
        {
            var Id = httpContextAccessor.HttpContext?.User?.FindFirstValue("userID");
            GetCurrentUserId = string.IsNullOrEmpty(Id) ? Guid.Empty : Guid.Parse(Id);
        }

        public Guid GetCurrentUserId {  get; }
    }
}
