using System.Threading.Tasks;
using Abp.Application.Services;
using RenCaiEX.Roles.Dto;

namespace RenCaiEX.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
