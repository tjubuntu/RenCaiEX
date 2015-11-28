using System.Threading.Tasks;
using Abp.Application.Services;
using RenCaiEX.Users.Dto;

namespace RenCaiEX.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}