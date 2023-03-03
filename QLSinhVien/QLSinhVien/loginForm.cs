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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public string username = "";

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text != string.Empty && txtPasswd.Text != string.Empty)
            {
                ConnectDB.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("Select * From account where username = '" + txtUser.Text + "' and passwd = '" + txtPasswd.Text + "' ", ConnectDB.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    SqlDataAdapter ad = new SqlDataAdapter("Select * From account where username = '" + txtUser.Text + "' and passwd = '" + txtPasswd.Text + "' and role = 'teacher' ", ConnectDB.conn);
                    DataTable account = new DataTable();
                    ad.Fill(account);
                    if (account.Rows.Count > 0)
                    {
                        DashBoard dashBoard = new DashBoard(account.Rows[0][0].ToString());
                        dashBoard.Show();
                        this.Hide();
                    }
                    else
                    {
                        string username = txtUser.Text;
                        dashboardStudent dashboardStudent = new dashboardStudent(username);
                        dashboardStudent.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!!!");
                }

            }
            else
            {
                MessageBox.Show("Please input data!!!");
            }
            

        }

        private void btnIconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
