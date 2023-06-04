namespace Demos.HomeWork.ModelsDb
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Users> usersList { get; set; }
    }
}
