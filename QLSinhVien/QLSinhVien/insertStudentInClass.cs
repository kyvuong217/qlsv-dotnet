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
    public partial class insertStudentInClass : Form
    {

        public string subject = "";
        public string username = "";
        public insertStudentInClass()
        {
            InitializeComponent();
        }

        public insertStudentInClass(string subject, string username)
        {
            InitializeComponent();
            this.subject = subject;
            this.username = username;
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

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.openConnection();
                SqlCommand cmd1 = new SqlCommand(@"Insert into transcript (transcript_subj, transcript_student, transcript_teacher) values ('"+txtSubject.Text+"', '"+cbbStudentID.Text+"', '"+username+"') ", ConnectDB.conn);
                cmd1.ExecuteNonQuery();
                ConnectDB.closeConnection();
                MessageBox.Show("Insert Successfully!!!");
                this.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select student_id from student inner join transcript on transcript_student = student_id inner join subj on transcript_subj = subj_ID where student_class = '"+cbbClass.Text+ "' and not subj_name = '" + subject + "' ", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            ConnectDB.closeConnection();
            cbbStudentID.DataSource = dt;
            cbbStudentID.DisplayMember = "student_id";
        }

        private void cbbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"Select student_name, student_dob from student where student_id = '"+cbbStudentID.Text+"' ", ConnectDB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                // lay du lieu
                string studentName = dr.GetString(0);
                DateTime studentDate = dr.GetDateTime(1);


                //hien du lieu
                txtStudentName.Text = studentName;
                txtStudentDOB.Text = studentDate.ToShortDateString();
            }
            dr.Close();

        }

        public void getSubject()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"Select *from subj where subj_name = '"+subject+"' ", ConnectDB.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                // lay du lieu
                string subj_id = dr.GetString(0);



                //hien du lieu
                txtSubject.Text = subj_id;

            }
            dr.Close();
        }

        private void insertStudentInClass_Load(object sender, EventArgs e)
        {
            getSubject();
            showClass();
        }


    }
}
