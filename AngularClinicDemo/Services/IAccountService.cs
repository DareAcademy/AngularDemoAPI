using AngularClinicDemo.Models;
using Microsoft.AspNetCore.Identity;

namespace AngularClinicDemo.servicies
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccount(SignupModel signup);

        Task<SignInResult> SignIn(SignInModel signIn);

        Task<IdentityResult> CreateRole(RoleModel role);

        Task<List<UserDTO>> GetUsers();

        Task<List<RoleDTO>> getRoles(string userId);

        Task UpdateRoles(List<RoleDTO> liUserRoles);

        Task SignOut();
    }
}
