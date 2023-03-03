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
    public partial class transcriptStudent : Form
    {
        public string username = "";

        public transcriptStudent()
        {
            InitializeComponent();
        }
        public transcriptStudent(string username)
        {
            InitializeComponent();
            this.username = username;

        }

        public void showTranscriptStudent()
        {
            ConnectDB.openConnection();
            SqlCommand cmd = new SqlCommand(@"select transcript_subj as 'Subject ID', subj_name as 'Subject Name', transcript_teacher as 'Teacher ID', teacher_name as 'Teacher Name', transcript_point as Point  from transcript
                                                inner join teacher on transcript_teacher = teacher_id 
                                                inner join subj on transcript_subj = subj_ID 
                                                where transcript_student = '"+username+"'", ConnectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTranscript.DataSource = dt;
        }

        private void transcriptStudent_Load(object sender, EventArgs e)
        {
            showTranscriptStudent();
        }
    }
}
