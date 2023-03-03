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
    public partial class inforStudent : Form
    {
        public string username = "";
        public inforStudent()
        {
            InitializeComponent();
        }

        public inforStudent(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public void showInfo()
        {
            ConnectDB.openConnection();
            //truy van
            SqlCommand sql = new SqlCommand(@"Select *from student where student_ID = '" + username + "' ", ConnectDB.conn);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                // lay du lieu
                string studentID = dr.GetString(0);
                string studentName = dr.GetString(1);
                DateTime studentDOB = dr.GetDateTime(2);
                string studentClass = dr.GetString(3);

                //hien du lieu
                txtStudentID.Text = studentID;
                txtStudentName.Text = studentName;
                txtDOB.Text = studentDOB.ToShortDateString();
                txtStudentClass.Text = studentClass;
                
            }
            dr.Close();
        }

        private void inforStudent_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfoStudent updateInfo = new updateInfoStudent(txtStudentID.Text, txtStudentName.Text, txtDOB.Text, txtStudentClass.Text);
            updateInfo.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inforStudent_Load(sender, e);
        }
    }
}
