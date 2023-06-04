﻿using Demos.HomeWork.ModelsDb;
using System.Data;

namespace Demos.HomeWork.Repository_HW20
{
    public class UserRolesRepository
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
                    Roles roles = new Roles();
                    roles.RolesName = roleName;
                    user.rolesList.Add(roles);
                    UpdateUserRole(user);
                    return db.SaveChanges() > 0;
                }
                return db.SaveChanges() > 0;
            }
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


        public bool UpdateUserRole(Users userToUpdate)
        {
            using (URDbContext db = new URDbContext())
            {
                db._Users.Update(userToUpdate);
                return db.SaveChanges() > 0;
            }
        }
        public List<string> GetAllUsersEmailsInRole()
        {

        }
        public bool IsUserInRole(string userName)
        {

        }

        public List<Users> GetAllUsers()
        {

        }
    }
}
