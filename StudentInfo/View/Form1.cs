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
        private void btnADD_Click(object sender, EventArgs e)
        {
            // Pagbuhat og bag-ong Student object
            Student student = new Student();
            student.FirstName = TEFirstName.Text;
            student.MiddleName = TEMiddleName.Text;
            student.LastName = TELastName.Text;
            student.Gender = TEGender.Text;
            student.Age = TEAge.Text;
            // Idugang ang student sa listahan
            students.Add(student);
            GCStudent.DataSource = students; // Iset ang data source sa grid
            GCStudent.RefreshDataSource();   // I-refresh ang grid aron makita ang updated nga data
        }
        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            // Pagbuhat og bag-ong Student object alang sa update
            Student student = new Student();
            student.FirstName = TEFirstName.Text;
            student.MiddleName = TEMiddleName.Text;
            student.LastName = TELastName.Text;
            student.Gender = TEGender.Text;
            student.Age = TEAge.Text;
            // I-set ang data source sa grid
            GCStudent.DataSource = students;
            // I-update ang selected student sa listahan gamit ang focused row handle
            students[GVStudent.FocusedRowHandle] = student;
            // I-refresh ang grid aron makita ang mga changes
            GCStudent.RefreshDataSource();
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
                // I-refresh ang data source sa grid aron makita ang update
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