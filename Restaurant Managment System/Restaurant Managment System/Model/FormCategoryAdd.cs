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

namespace Restaurant_Managment_System.Model
{
    public partial class FormCategoryAdd : SampleAdd
    {
        private Guna.UI2.WinForms.Guna2PictureBox gunaPictureBox1;


        public FormCategoryAdd()
        {
            InitializeComponent();
            gunaPictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            gunaPictureBox1.Location = new Point(12, 10); 
            gunaPictureBox1.Size = new Size(94, 85); 
            this.Controls.Add(gunaPictureBox1); 
            LoadImage();
        }
        private void LoadImage()
        {
            string imagePath = "C:\\Users\\HP\\Downloads\\list.png"; 
            Bitmap bitmap = new Bitmap(Image.FromFile(imagePath));

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    if (pixelColor.R > 200 && pixelColor.G > 200 && pixelColor.B > 200)
                    {
                        bitmap.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            gunaPictureBox1.Image = bitmap;

            gunaPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            gunaPictureBox1.BringToFront();
        }






        private void FormCategoryAdd_Load(object sender, EventArgs e)
        {

        }
        public int id = 0;
        public override void guna2Button1_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id == 0)
            { qry = "insert into category values (@Name)"; }
            else 
            { qry = "update category set catName=@Name where catID=@id"; }
            Hashtable ht = new Hashtable();
            ht.Add("@id",id);
            ht.Add("@Name", txtName.Text);
            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully..");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
