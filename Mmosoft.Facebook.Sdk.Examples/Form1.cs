using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace Mmosoft.Facebook.Sdk.Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(txtUsername.Text, txtPassword.Text);

            fb.PostToWall(txtContent.Text);
            MessageBox.Show("Đăng thành công!", "Thông Báo");
        }
        private void btnPostGroup_Click(object sender, EventArgs e)
        {
            var fb = new FacebookClient(txtUsername.Text, txtPassword.Text);
            fb.PostToGroup(txtContent.Text, txtIDgroup.Text);
            MessageBox.Show("Đăng tin lên Group Facebook thành công!", "Thông Báo");
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        protected void button1_Click_1(object sender, EventArgs e)
        {
            Thread b2 = new Thread(new ThreadStart(ThreadMethod));
            b2.SetApartmentState(ApartmentState.STA);
            b2.Start();
        }
        static void ThreadMethod()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            open.ShowDialog();
            MessageBox.Show(open.FileName);
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }
    }
}
