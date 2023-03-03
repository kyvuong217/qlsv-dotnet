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
    public partial class subjectForm : Form
    {
        public subjectForm()
        {
            InitializeComponent();
        }


        public void showSubject()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"Select subj_id as 'Subject ID', subj_name as 'Subject Name' from subj", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSubject.DataSource = dt;
        }

        private void subjectForm_Load(object sender, EventArgs e)
        {
            showSubject();
            getDataGridView();
        }
        
        public void getDataGridView()
        {
            txtSubjectID.DataBindings.Clear();
            txtSubjectID.DataBindings.Add("text", dgvSubject.DataSource, "Subject ID");
            txtSubjectName.DataBindings.Clear();
            txtSubjectName.DataBindings.Add("text", dgvSubject.DataSource, "Subject Name");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtSubjectName.Text != string.Empty && txtSubjectID.Text != string.Empty)
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Select subj_id from subj where subj_id = '"+txtSubjectID.Text+"' ", ConnectDB.conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Subject ID already exists!!!");
                }
                else
                {
                    ConnectDB.openConnection();
                    SqlCommand cmd1 = new SqlCommand(@"Insert into subj values ('" + txtSubjectID.Text + "', '" + txtSubjectName.Text + "')", ConnectDB.conn);
                    cmd1.ExecuteNonQuery();
                    ConnectDB.closeConnection();
                    MessageBox.Show("Insert successfully!!!");
                    subjectForm_Load(sender, e);
                }

            }
            else
            {
                MessageBox.Show("Please input data!!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to remove this row ???", "Remove Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConnectDB.openConnection();
                    SqlCommand cmd = new SqlCommand(@"Delete from subj where subj_id = '"+txtSubjectID.Text+"'", ConnectDB.conn);
                    cmd.ExecuteNonQuery();
                    ConnectDB.closeConnection();
                    subjectForm_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text != string.Empty && txtSubjectID.Text != string.Empty)
            {
                ConnectDB.openConnection();
                SqlCommand cmd = new SqlCommand(@"Select subj_id from subj where subj_id = '" + txtSubjectID.Text + "' ", ConnectDB.conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ConnectDB.openConnection();
                    SqlCommand cmd1 = new SqlCommand(@"Update subj Set subj_name = '" + txtSubjectName.Text + "' where subj_id = '"+txtSubjectID.Text+"'  ", ConnectDB.conn);
                    cmd1.ExecuteNonQuery();
                    ConnectDB.closeConnection();
                    MessageBox.Show("Update successfully!!!");
                    subjectForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Subject ID not exist!!!");
                }

            }
            else
            {
                MessageBox.Show("Please input data!!!");
            }
        }
    }
}
