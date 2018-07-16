using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composition_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Instructor Rob = new Instructor();

            Rob.InstructorID = 1;
            Rob.Name = "Robert Wood";
            Rob.EmailAddress = "rdrwood@gmail.com";
            
            Course cpw212 = new Course();
            cpw212.CourseID = 1000;
            cpw212.Title = "Advanced .net";
            cpw212.NumCredits = 5;
            cpw212.Teacher = Rob;


            DisplayCourse(null);
            DisplayCourse(new Course());
            DisplayCourse(cpw212);

            Student s1 = new Student();
            s1.FirstName = "Jim";
            s1.LastName = "Halpert";
            s1.StudentID = 123456789;
            s1.DateOfBirth = null;

            s1.Schedule.Add(cpw212);
            // get the first course for s1
            Course stuCourse = s1.Schedule[0];
            Course stuCourse2 = s1.Schedule.ElementAt(0);

            // get the course title for s1
            string title = s1.Schedule[0].Title;
            // get the instructor for the first course for s1
            string insName = s1.Schedule[0].Teacher.Name;
            string insName2 = stuCourse.Teacher.Name;
            Student s2 = new Student();
            s2.FirstName = "Dwight";
            s2.LastName = "Schrute";
            s2.StudentID = 987654321;
            s2.DateOfBirth = new DateTime(1982, 12, 26);

        }

        private void DisplayCourse(Course c)
        {
            if(c == null)
            {
                MessageBox.Show("No info to display");
                return;  // escapes the method
            }
            if (c.Teacher == null)
            {
                string displayWithNoInstructor =
                    $"Course: {c.Title} \n Credits: {c.NumCredits} \n Taught by: No Instructor";
                MessageBox.Show(displayWithNoInstructor);
                return;
            }

            string display =
                $"Course: {c.Title} \n Credits: {c.NumCredits} \n Taught by: {c.Teacher.Name} \n Email: {c.Teacher.EmailAddress}";

            MessageBox.Show(display);
        }
    }
}
