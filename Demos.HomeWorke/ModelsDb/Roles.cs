namespace Demos.HomeWork.ModelsDb
{
    public class Roles
    {
        public int Id { get; set; }
        public string RolesName { get; set; }
        public List<Users> usersList { get; set; }
    }
}
