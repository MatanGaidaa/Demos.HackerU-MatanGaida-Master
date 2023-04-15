using Demos.HackerU.HomeWork.Inhheritance;
using Demos.HackerU.Wpf.Helpers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for JsonSerialization.xaml
    /// </summary>
    public partial class JsonSerialization : Window
    {
        private IStudentsRepository repo = null;

        public JsonSerialization()
        {
            //Initialize all XAML Controls
            InitializeComponent();
            repo = StudentsRepository.Instance;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnSave.IsEnabled = false;
            btnRemove.IsEnabled = false;

            // repo.AddStudent(new Student { Name = "Test", Id = "1", Grade = 80 });
            // repo.AddStudent(new Student { Name = "Test2", Id = "2", Grade = 95 });
            //listBoxStudents.ItemsSource = this.repo.GetAllStudents();
        }
        private void listBoxStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var student = listBoxStudents.SelectedItem as Student;
            if (student != null)
            {
                if (student.ImagePath != null)
                {
                    string destinationFile = Path.Combine(Environment.CurrentDirectory, student.ImagePath);
                    imgTitle.Source = new BitmapImage(new Uri(destinationFile));
                }
                else
                {
                    imgTitle.Source = new BitmapImage();
                }
            }



            //--Check On Remove
            if (listBoxStudents.Items.Count == 0)
            {
                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtGrade.Text = string.Empty;
                btnSave.IsEnabled = false;
                btnRemove.IsEnabled = false;
            }

            else if (this.listBoxStudents.SelectedItem is Student selectedStudent)
            {
                txtId.Text = selectedStudent.Id;
                txtName.Text = selectedStudent.Name;
                txtGrade.Text = selectedStudent.Grade.ToString();
                btnSave.IsEnabled = true;
                btnRemove.IsEnabled = true;
            }
        }
        int iNoName = 1;
        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {


            Student emtyStudent = new Student
            {
                Name = "NoName_" + iNoName,
                Id = iNoName.ToString(),
                Grade = 0
            };

            repo.AddStudent(emtyStudent);

            // listBoxStudents.Items.Clear();
            //Refresh GUI From RepO
            listBoxStudents.ItemsSource = null;
            listBoxStudents.ItemsSource = this.repo.GetAllStudents();

            iNoName++;
        }
        private void SetSelectedById(string id)
        {

        }
        private void SetSelectedByIndex(int index)
        {

        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            //Get Selected Item / Student
            Student selectedStudentObj = (this.listBoxStudents.SelectedItem as Student);
            if (selectedStudentObj != null)
            {
                this.repo.RemoveStudent(selectedStudentObj.Id);
                //Refresh List
                listBoxStudents.ItemsSource = null;
                listBoxStudents.ItemsSource = this.repo.GetAllStudents();

                //txtId.Text = string.Empty;
                //txtName.Text = string.Empty;
                //txtGrade.Text = string.Empty;

                if (listBoxStudents.Items.Count > 0)
                {
                    listBoxStudents.SelectedIndex = listBoxStudents.Items.Count - 1;
                }

            }

        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxStudents.SelectedIndex == -1)
            {
                MessageBox.Show("No Selected Item");
                return;
            }

            var student = listBoxStudents.SelectedItem as Student;
            if (student != null)
            {
                student.Id = txtId.Text;
                student.Name = txtName.Text;
                if (student.ImagePath != null)
                {
                    string destinationFile = Path.Combine(Environment.CurrentDirectory, student.ImagePath);
                    imgTitle.Source = new BitmapImage(new Uri(destinationFile));
                }
                else
                {
                    imgTitle.Source = new BitmapImage();
                }
                try
                {
                    student.Grade = int.Parse(txtGrade.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter Number Format: 0-100");
                    txtGrade.Clear();
                }

            }


            //Update Repo 
            repo.UpdateStudent(student);

            //RefreshList
            int lastSelectedIndex = listBoxStudents.SelectedIndex;
            listBoxStudents.ItemsSource = null;
            listBoxStudents.ItemsSource = this.repo.GetAllStudents();
            listBoxStudents.SelectedIndex = lastSelectedIndex;

        }
        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {


            //2--Check If Directory Not Exsist 
            if (!Directory.Exists("AppData"))
            {
                //--Create New Directory (bin/debug....)
                Directory.CreateDirectory("AppData");
            }


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "שמירת קובץ";
            saveFileDialog.Filter = "JSON Files|*.json";
            if (Directory.Exists("AppData"))
            {
                saveFileDialog.InitialDirectory = Path.Combine(Environment.CurrentDirectory, "AppData");  // Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            else
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }


            if (saveFileDialog.ShowDialog() == true)
            {
                string filePathSelected = saveFileDialog.FileName;

                //1--Get Current Repo Students List
                List<Student> students = repo.GetAllStudents();

                //3--Options For Indentation
                var options = new JsonSerializerOptions { WriteIndented = true };
                //--Convert List to Json String
                var studentsJson = JsonSerializer.Serialize(students, options);
                //4--Save JSON Text To File in  BinDebug under AppData Directory
                File.WriteAllText(filePathSelected, studentsJson);
            }


        }
        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            //--Open Dialog
            OpenFileDialog dialog = new OpenFileDialog();
            //--Open Desktop
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //--Open JSON Files Only
            dialog.Filter = "JSON Files|*.json;*.JSON;*.txt";

            //Display Dialog
            if (dialog.ShowDialog() == true)
            {
                //--read User Selected File
                string jsonFullPath = dialog.FileName;
                this.PathLoader.Text = jsonFullPath;//Show Path In Text

                //Desirialize + Refresh LIST

                string studentsText = File.ReadAllText(this.PathLoader.Text);
                var studentsList =
                JsonSerializer.Deserialize<List<Student>>(studentsText);
                //2)Add Objects to Repo Manager
                foreach (Student item in studentsList)
                {
                    repo.AddStudent(item);
                }
                //3)Sync GUI LIST
                this.listBoxStudents.ItemsSource = null;
                this.listBoxStudents.ItemsSource = repo.GetAllStudents();
            }
        }
        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            var student = listBoxStudents.SelectedItem as Student;

            if (student != null)
            {
                student.ImagePath = FilesHandling.ImageUpload();

                string destinationFile = Path.Combine(Environment.CurrentDirectory, student.ImagePath);

                if (student.ImagePath != null)
                {
                    imgTitle.Source = new BitmapImage(new Uri(destinationFile));
                }
            }


        }

        private void JsonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

