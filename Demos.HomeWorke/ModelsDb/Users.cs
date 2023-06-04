namespace Demos.HomeWork.ModelsDb
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public List<Roles> rolesList { get; set; }

    }
}
