using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demos.HackerU.Wpf
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        //Field
        private List<Student> studentList;


        public StudentWindow()
        {
            InitializeComponent();
            studentList = new List<Student>();
        }

        /// <summary>
        /// When Window Displayed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student(txtName.Text, txtId.Text,int.Parse(txtGrade.Text));
            studentList.Add(s);
            UpdateStudentsListBox();
        }

        private void UpdateStudentsListBox()
        {
            listBoxStudents.Items.Clear();
            foreach (Student s in studentList)
            {
                listBoxStudents.Items.Add(s.ShowStudent());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            var indexSelected = listBoxStudents.SelectedIndex;
            if (indexSelected >= 0)
            {
                studentList.RemoveAt(indexSelected);
                UpdateStudentsListBox();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string contentToFile = "";
            foreach (Student s in studentList)
            {
                contentToFile += s.ShowStudent()+Environment.NewLine;
            }

            System.IO.File.WriteAllText("students.txt",contentToFile);
            
        
        }
    }
}
