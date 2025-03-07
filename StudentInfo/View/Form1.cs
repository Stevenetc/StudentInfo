using DevExpress.XtraEditors;
using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo.View
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private bool ValidateInputs()
        {
            // Tan-awa kung puno ba ang tanan nga field
            if (string.IsNullOrWhiteSpace(TEFirstName.Text))
            {
                MessageBox.Show("Palihug isulod ang First Name.");
                TEFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TEMiddleName.Text))
            {
                MessageBox.Show("Palihug isulod ang Middle Name.");
                TEMiddleName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TELastName.Text))
            {
                MessageBox.Show("Palihug isulod ang Last Name.");
                TELastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TEGender.Text))
            {
                MessageBox.Show("Palihug isulod ang Gender.");
                TEGender.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TEAge.Text))
            {
                MessageBox.Show("Palihug isulod ang Age.");
                TEAge.Focus();
                return false;
            }

            // Tan-awa kung ang Age kay valid nga numero
            if (!int.TryParse(TEAge.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Ang Age kinahanglan usa ka positibong numero.");
                TEAge.Focus();
                return false;
            }

            return true;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            // I-validate ang inputs una mag-add
            if (ValidateInputs())
            {
                // Pagbuhat og bag-ong student object
                Student student = new Student
                {
                    FirstName = TEFirstName.Text,
                    MiddleName = TEMiddleName.Text,
                    LastName = TELastName.Text,
                    Gender = TEGender.Text,
                    Age = TEAge.Text
                };

                // Idugang ang student sa listahan
                students.Add(student);
                GCStudent.DataSource = students; // I-set ang data source para sa grid
                GCStudent.RefreshDataSource(); // I-refresh ang grid aron makita ang updated nga data
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {  // Validate inputs before updating
            if (ValidateInputs())
            {
                // Create a new student object for updating
                Student student = new Student
                {
                    FirstName = TEFirstName.Text,
                    MiddleName = TEMiddleName.Text,
                    LastName = TELastName.Text,
                    Gender = TEGender.Text,
                    Age = TEAge.Text
                };

        // Update the selected student in the list using the focused row handle
        students[GVStudent.FocusedRowHandle] = student;

                // Refresh the grid to reflect the changes
                GCStudent.RefreshDataSource();
            }
}
private void btnDELETE_Click(object sender, EventArgs e)
        {
            // Tan-awa kung adunay napiling row
            if (GVStudent.FocusedRowHandle >= 0)
            {
                // Kuhaa ang napiling student
                Student selectedStudent = (Student)GVStudent.GetRow(GVStudent.FocusedRowHandle);

                // Kuhaa ang student gikan sa listahan
                students.Remove(selectedStudent);

                // I-refresh ang data source sa grid aron makita ang pagkuha
                GCStudent.DataSource = null;
                GCStudent.DataSource = students;
                GCStudent.RefreshDataSource();
            }
            else
            {
                // Ipakita ang mensahe kung walay napiling student
                MessageBox.Show("Palihug pilii ang usa ka student nga i-delete.");
            }
        }
    }
}