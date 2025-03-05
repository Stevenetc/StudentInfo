using DevExpress.XtraEditors;
using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo.View
{
    public partial class StudentInfo : DevExpress.XtraEditors.XtraForm
    {
        public List<StudentInfo> studentInfo = new List<StudentInfo>();
        public StudentInfo()
        {
            InitializeComponent();
        }

        public void AddStudent(StudentInfo newstudentInfo)
        {
            studentInfo.Add(newstudentInfo); // Idugang ang estudyante sa listahan
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            // Create new student object
            // Maghimo og bag-ong estudyante nga object
            Models.StudentInfo newStudentInfo = new Models.StudentInfo();

            // I-assign ang mga values gikan sa mga textbox ngadto sa properties sa estudyante
            newStudentInfo.FirstName = TEFirstName.Text;
            newStudentInfo.MiddleName = TEMiddleName.Text; // Assuming nga naa'y textbox para sa MiddleName
            newStudentInfo.LastName = TELastName.Text;
            newStudentInfo.Gender = TEGender.Text;
            newStudentInfo.Age = TEAge.Text;

            // Idugang ang estudyante sa listahan
            studentInfo.Add(newStudentInfo);

            // Optional: I-clear ang mga form fields human madugang ang estudyante
            TEFirstName.Clear();
            TEMiddleName.Clear();
            TELastName.Clear();
            TEGender.Clear();
            TEAge.Clear();

            // Pwede pud magpakita og success message o mag-refresh og UI control (sama sa DataGridView) aron makita ang bag-ong estudyante
            MessageBox.Show("Gidugang ang estudyante nga malampuson!");
        }
    }
}