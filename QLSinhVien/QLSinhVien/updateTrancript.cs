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
    public partial class updateTrancript : Form
    {

        public string classOfStudent = "";
        public string studentID = "";
        public string nameOfStudent = "";
        public string DOB ;
        public string point = "";
        public string subj = "";

        public updateTrancript()
        {
            InitializeComponent();
        }

        public updateTrancript(string studentID, string nameOfStudent, string DOB, string point, string subj)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.nameOfStudent = nameOfStudent;
            this.DOB = DOB;
            this.point = point;
            this.subj = subj;
        }
        public void showClass()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select *from class", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ConnectDB.closeConnection();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbClass.DataSource = dt;
            cbbClass.DisplayMember = "class_id";

        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = studentID;
            txtName.Text = nameOfStudent;
            txtDOB.Text = DOB;
            txtPoint.Text = point;
            txtSubject.Text = subj;
            showClass();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Update student Set 
                                                    student_class = '" + cbbClass.Text + "', " +
                                                    "student_ID = '"+txtStudentID.Text+"'," +
                                                    " student_name = '"+txtName.Text+"'," +
                                                    " student_dob = '"+txtDOB.Text+"'" +
                                                    " where student_ID = '" + txtStudentID.Text + "'", ConnectDB.conn);
                string point = txtPoint.Text;
                float transcript_point = float.Parse(point);
                SqlCommand cmd2 = new SqlCommand("Update transcript Set transcript_point = "+transcript_point+" where transcript_student = '"+txtStudentID.Text+"';", ConnectDB.conn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
