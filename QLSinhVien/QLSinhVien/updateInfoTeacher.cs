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
    public partial class updateInfoTeacher : Form
    {
        public string TeacherID = "";
        public string TeacherName = "";
        public string TeacherDOB = "";
        public updateInfoTeacher()
        {
            InitializeComponent();
        }

        public updateInfoTeacher(string TeacherID, string TeacherName, string TeacherDOB)
        {
            InitializeComponent();
            this.TeacherID = TeacherID;
            this.TeacherName = TeacherName;
            this.TeacherDOB = TeacherDOB;
        }

        public void showInfo()
        {
            txtTeacherID.Text = TeacherID;
            txtTeacherName.Text = TeacherName;
            txtDOB.Text = TeacherDOB;
        }

        private void updateInfo_Load(object sender, EventArgs e)
        {
            showInfo();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Update teacher set teacher_name = '"+txtTeacherName.Text+"', teacher_dob = '"+txtDOB.Text+"' where teacher_id = '"+txtTeacherID.Text+"'  ", ConnectDB.conn);
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

        private void txtTeacherID_Click(object sender, EventArgs e)
        {

        }

        private void txtTeacherDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
