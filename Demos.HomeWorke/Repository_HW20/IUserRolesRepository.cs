using Demos.HomeWork.ModelsDb;

namespace Demos.HomeWork.Repository_HW20
{
    public interface IUserRolesRepository
    {
        Users? Login(string userName, string password);
        bool UserRegister(string name, string password, string email, string rolename);
        bool AddUserToRole(int id, string roleName);
        bool RemoveUserFromRole(int id);
        bool UpdateUserRole(int id, string rolename, string roleToUpdate);
        List<Users> GetAllUsers();
    }
}