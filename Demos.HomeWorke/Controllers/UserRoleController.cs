using Demos.HomeWork.DTOModels;
using Demos.HomeWork.ModelsDb;
using Demos.HomeWork.Repository_HW20;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demos.HomeWork.Controllers
{
    [Route("api/UserRole")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRolesRepository usersRepo = null;

        public UserRoleController(IUserRolesRepository usersRepo)
        {
            this.usersRepo = usersRepo;
        }



        // GET: api/<UserRoleController>
        /// <summary>
        /// get all users in the list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> Get()
        {
            return usersRepo.GetAllUsers();
        }



        // GET api/<UserRoleController>/5
        /// <summary>
        /// get youser by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Users? Get(int id)
        {
            return usersRepo.GetAllUsers().Find(x => x.Id == id);
        }

        // POST api/<UserRoleController>
        [HttpPost("LoginUser")]
        public ActionResult<Users>? Login([FromBody] LoginUser user)
        {
            var userFound = usersRepo.Login(user.UserName, user.Password);
            if (userFound != null)
            {
                return Ok(userFound);
            }
            return NotFound();
        }

        // POST api/<UserRoleController>
        [HttpPost("RegUser")]
        public void RegUser([FromBody] RegUser user)
        {
            usersRepo.UserRegister(user.UserName, user.Password, user.Email, user.Rolename);

        }

        // PUT api/<UserRoleController>/5
        [HttpPut("{id}")]
        public void UserToRole(int id, [FromBody] string roleName)
        {
            usersRepo.AddUserToRole(id, roleName);
        }


        [HttpPut("{id}")]
        public void UpdateUserToRole(int id, [FromBody] string roleName, [FromBody] string roleNameToUpdate)
        {
            usersRepo.UpdateUserRole(id, roleName, roleNameToUpdate);
        }


        // DELETE api/<UserRoleController>/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            bool isOk = usersRepo.RemoveUserFromRole(id);
            if (isOk)
            {
                return Ok("User As Been Deleted");
            }
            return BadRequest("Id is not valid");
        }
    }
}
