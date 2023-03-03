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
    public partial class importExcel : Form
    {
        public importExcel()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Insert into account values ('"+txtStudentID.Text+"', '"+txtStudentPw.Text+"', 'student')", ConnectDB.conn);
                SqlCommand cmd1 = new SqlCommand(@"Insert into student values ('" + txtStudentID.Text + "', '" + txtStudentName.Text + "', '"+dob.Text+"', '"+cbbClass.Text+"')", ConnectDB.conn);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                ConnectDB.closeConnection();
                MessageBox.Show("Insert Successfully!!!");


            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void importExcel_Load(object sender, EventArgs e)
        {
            showClass();
        }

        private void txtStudentPw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
