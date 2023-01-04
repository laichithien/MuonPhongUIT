using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MuonPhongUIT
{
    public partial class LoginForm : Form
    {
        string userName = "admin";
        string password = "admin";  
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thoát chương trình ?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }
        private void login()
        {
            //if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập");
            //}
            //else if (userNameTextBox.Text == userName && passwordTextBox.Text == password)
            //{
            //    this.Hide();
            //    Home home = new Home();
            //    home.ShowDialog();
            //    this.Dispose();
            //}
            //else MessageBox.Show("Thông tin đăng nhập sai");

            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Dispose();
        }
    }
}
