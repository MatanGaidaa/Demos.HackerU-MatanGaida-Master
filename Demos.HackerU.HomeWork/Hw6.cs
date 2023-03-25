namespace Demos.HackerU.HomeWork
{
    public class Course
    {
        private string title;
        private string description;
        private int id;
        private List<string> students = new List<string>();
        public CategoryType categoryType { get; set; }

        public Course(string title, string description, int id, List<string> students, CategoryType category)
        {
            Title = title;
            Description = description;
            this.id = id;
            Students = students;
            this.categoryType = category;
        }


        public Course()
        {
            title = "";
            description = "";
            students = new List<string>();
            id = 0;
            this.categoryType = CategoryType.none;
        }


        public List<string> Students
        {
            get
            {
                return students;
            }
            set
            {
                if (students.Count < 10)
                {
                    students = value;
                }

            }
        }

        public int StudentsCount
        {
            get
            {
                return students.Count;
            }
        }



        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length <= 10)
                {
                    title = value;
                }
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length <= 30)
                    description = value;

            }
        }


        public void AddStudentName(string student)
        {
            Students.Add(student);
        }

        public void RemoveStudent(string student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
            }
            else
            {
                Console.WriteLine("Not exsist");
            }
        }

        public string DisplayCourseInfo()
        {
            Console.WriteLine("\nCourse Info:");

            string courseInfoText = $"id:{id}\ntitle:{title}\ndesc:{description}\ncategory:{categoryType}\n";
            courseInfoText += "Students:\n";
            int index = 0;
            foreach (string studentName in students)
            {
                index++;
                courseInfoText += " " + index + "." + studentName + "\n";
            }
            return courseInfoText;
        }

        public string DisplayShortCourseInfo()
        {
            Console.WriteLine("\nshort Info :");
            return $"Title:{title},StudentsCount:{StudentsCount}";
        }

    }
    public enum CategoryType
    {
        QA,
        DotNet,
        DevOps,
        Graphics,
        Webmaster,
        none
    }

}
