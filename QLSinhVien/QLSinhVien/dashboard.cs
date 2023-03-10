using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QLSinhVien
{
    public partial class DashBoard : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public string username = "";
        public DashBoard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn); 
        }

        public DashBoard(string username)
        {
            InitializeComponent();
            this.username = username;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        public void acctivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon-text title
                iconTitle.IconChar = currentBtn.IconChar;
                iconTitle.ForeColor = color;

            }
            
        }

        public void disableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 128, 128);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
            labelTitle.ForeColor = Color.FromArgb(197, 179, 88);


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            acctivateButton(sender, Color.FromArgb(197, 179, 88));
            openChildForm(new inforTeacher(username));
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            acctivateButton(sender, Color.FromArgb(197, 179, 88));
            openChildForm(new transcript(username));
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            acctivateButton(sender, Color.FromArgb(197, 179, 88));
            openChildForm(new importExcel());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            acctivateButton(sender, Color.FromArgb(197, 179, 88));
            openChildForm(new subjectForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            this.Close();
            login.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            disableButton();
            leftBorderBtn.Visible = false;
            iconTitle.IconChar = IconChar.Home;
            iconTitle.ForeColor = Color.Gainsboro;
        }


        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
