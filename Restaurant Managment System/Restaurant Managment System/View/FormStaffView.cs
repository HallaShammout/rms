using Restaurant_Managment_System.Model;
using RM;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Managment_System.View
{
    public partial class FormStaffView : SampleView
    {
        public FormStaffView()
        {
            InitializeComponent();
        }
        private void FormStaffView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "select * from users";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvUserName);
            lb.Items.Add(dgvPassword);
            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }
       
        public override void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            FormStaffAdd frm = new FormStaffAdd();
            frm.ShowDialog();
            GetData();
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
                FormStaffAdd frm = new FormStaffAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                frm.txtPhone.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                frm.txtUserName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvUserName"].Value);
                frm.txtPossword.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvPassword"].Value);
                frm.ShowDialog();
                GetData();
            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDel")
            {
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are You Sure You Want To Delet") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "DELETE FROM users WHERE userID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Deleted Successfully..");
                    GetData();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
