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
    public partial class inforTeacher : Form
    {
        public string username = "";
        public inforTeacher()
        {
            InitializeComponent();
        }

        public inforTeacher(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public void showInfo()
        {
            ConnectDB.openConnection();
            //truy van
            SqlCommand sql = new SqlCommand(@"Select *from teacher where teacher_ID = '"+username+"' ", ConnectDB.conn);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                // lay du lieu
                string teacherID = dr.GetString(0);
                string teacherName = dr.GetString(1);
                DateTime teacherDOB = dr.GetDateTime(2);

                //hien du lieu
                txtTeacherID.Text = teacherID;
                txtTeacherName.Text = teacherName;
                txtDOB.Text = teacherDOB.ToShortDateString();
            }
            dr.Close();
        }

        private void informationForm_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            updateInfoTeacher updateInfo = new updateInfoTeacher(txtTeacherID.Text, txtTeacherName.Text, txtDOB.Text);
            updateInfo.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            informationForm_Load(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDOB_Click(object sender, EventArgs e)
        {

        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {

        }

        private void txtTeacherID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
