namespace Demos.HackerU.HomeWork.HW_18.Db
{
    public interface ISudentDbRepository
    {
        void AddNewStudent(StudentModel student);
        void DeleteStudentByID(int id);
        List<StudentModel> GetAllStudents();
        List<StudentModel> GetAllStudentsByCours(string courseName);
        StudentModel GetStudentById();
        void SaveLastStudenttoFile();
        void UpDateStudentByID(int id);
    }
}