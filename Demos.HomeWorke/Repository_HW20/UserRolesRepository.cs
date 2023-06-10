using Demos.HomeWork.ModelsDb;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Demos.HomeWork.Repository_HW20
{
    public class UserRolesRepository : IUserRolesRepository
    {
        public Users? Login(string userName, string password)
        {
            using (URDbContext db = new URDbContext())
            {
                Users? user = db._Users.SingleOrDefault(x => x.UserName == userName && x.Password == password);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }
        public bool UserRegister(string name, string password, string email, string rolename)
        {
            using (URDbContext db = new URDbContext())
            {
                db._Users.Add(new Users { UserName = name, Password = password, Email = email, rolesList = new List<Roles>() { new Roles { RolesName = rolename } } });

                return db.SaveChanges() > 0;
            }

        }
        public bool AddUserToRole(int id, string roleName)
        {
            using (URDbContext db = new URDbContext())
            {
                Users? user = db._Users.SingleOrDefault(x => x.Id == id);
                if (user != null)
                {
                    user.rolesList = new List<Roles>() { new Roles { RolesName = roleName } };
                    db._Users.Update(user);
                    return db.SaveChanges() > 0;
                }

            }
            return false;

        }
        public bool RemoveUserFromRole(int id)
        {
            using (URDbContext db = new URDbContext())
            {
                Roles? role = db._Roles.SingleOrDefault(x => x.Id == id);
                if (role != null)
                {
                    db._Roles.Remove(role);
                    return db.SaveChanges() > 0;
                }
            }
            return false;
        }


        public bool UpdateUserRole(int id, string rolename, string roleToUpdate)
        {
            using (URDbContext db = new URDbContext())
            {
                Roles? role = db._Roles.SingleOrDefault(x => x.RolesName == rolename && x.Id == id);

                if (role != null)
                {
                    role.RolesName = roleToUpdate;
                    db._Roles.Update(role);
                }
                return db.SaveChanges() > 0;
            }
        }
        //public List<string> GetAllUsersEmailsInRole(string rolename)
        //{
        //    using (URDbContext db = new URDbContext())
        //    {
        //        Roles? role = db._Roles.All()
        //        if (role != null)
        //        {
        //            var allUsersInRole = db._Users.Include(x => x.rolesList);
        //        }

        //    }
        //}
        //public bool IsUserInRole(string userName)
        //{

        //}

        public List<Users> GetAllUsers()
        {
            var list = new List<Users>();
            using (URDbContext db = new URDbContext())
            {
                list = db._Users.ToList();
            }
            return list;
        }
    }
}
