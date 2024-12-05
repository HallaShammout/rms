using Restaurant_Managment_System;
using Restaurant_Managment_System.View;
using RM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class FormMain : Form
    {
        internal static object Instance;

        public FormMain()
        {
            InitializeComponent();
        }
        public void AddControls(Form f)
        {
            ContrilsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ContrilsPanel.Controls.Add(f);
            f.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbUser.Text = MainClass.User;


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new FormHome());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new FormCategoryView());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            AddControls(new FormTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new FormStaffView());
        }
    }
}
