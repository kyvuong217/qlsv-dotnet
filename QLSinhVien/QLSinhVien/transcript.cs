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
    public partial class transcript : Form
    {
        public string username = "";
        public string studentID = "";
        public string nameOfStudent = "";
        public string DOB = "";
        public string point = "";
        public string subj = "";
        public string classname = "";

        public transcript()
        {
            InitializeComponent();

        }

        public transcript(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        public void showSubject()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select distinct subj_name from account 
                                                inner join teacher on username = teacher_ID
                                                inner join transcript on teacher_ID = transcript_teacher
                                                inner join subj on transcript_subj = subj_id
                                              where username = '"+username+"'", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ConnectDB.closeConnection();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbSubject.DataSource = dt;
            cbbSubject.DisplayMember = "subj_name";

        }


        private void transcript_Load(object sender, EventArgs e)
        {
            showSubject();
            cbbSubject_SelectedIndexChanged(sender, e);
        }

        private void dgvTranscript_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexOfContent = e.RowIndex;
            DataGridViewRow row = dgvTranscript.Rows[indexOfContent];

            subj           = row.Cells[0].Value.ToString();
            studentID      = row.Cells[2].Value.ToString();
            nameOfStudent  = row.Cells[3].Value.ToString();
            DOB            = row.Cells[4].Value.ToString();
            point          = row.Cells[5].Value.ToString();
            

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertStudentInClass insertForm = new insertStudentInClass(cbbSubject.Text, username);
            insertForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTrancript updateForm = new updateTrancript(studentID, nameOfStudent, DOB, point, subj);
            updateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to remove this row ???", "Remove Rows", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConnectDB.openConnection();
                    SqlCommand cmd = new SqlCommand(@"Delete from transcript where transcript_student = '"+studentID+"' and transcript_subj = '"+subj+"' ", ConnectDB.conn);
                    cmd.ExecuteNonQuery();
                    ConnectDB.closeConnection();
                    transcript_Load(sender, e);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void cbbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select subj_id as 'Subject ID', student_class as Class, transcript_student as 'Student ID', student_name as 'Name', student_dob as DOB, transcript_point as Point from account 
                                                inner join teacher on username = teacher_ID
                                                inner join transcript on teacher_ID = transcript_teacher
                                                inner join student on transcript_student = student_ID
                                                inner join subj on transcript_subj = subj_id
                                             where username = '" + username + "' and subj_name = '" + cbbSubject.Text + "'", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTranscript.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            transcript_Load(sender, e);
        }
    }
}
