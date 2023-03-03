using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class updateInfoStudent : Form
    {
        public string studentID = "";
        public string studentName = "";
        public string DOB;
        public string classroom = "";

        public updateInfoStudent()
        {
            InitializeComponent();
        }
        public updateInfoStudent(string studentID, string studentName, string dob, string classroom)
        {
            InitializeComponent();
            this.studentID = studentID;
            this.studentName = studentName;
            this.DOB = dob;
            this.classroom = classroom;
        }

        public void showClass()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select distinct class_id from class", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            ConnectDB.closeConnection();
            cbbClass.DataSource = dt;
            cbbClass.DisplayMember = "class_id";
        }

        public void showInfo()
        {
            txtStudentID.Text = studentID;
            txtStudentName.Text = studentName;
            txtStudentDOB.Text = DOB;
            cbbClass.Text = classroom;

        }

        private void updateInfoStudent_Load(object sender, EventArgs e)
        {
            showClass();
            showInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Update student set student_name = '" + txtStudentName.Text + "', student_dob = '" + txtStudentDOB.Text + "', student_class = '"+cbbClass.Text+"' where student_id = '"+txtStudentID.Text+"' ", ConnectDB.conn);
                cmd.ExecuteNonQuery();
                ConnectDB.closeConnection();
                MessageBox.Show("Update Successfully!!!");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
