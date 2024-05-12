using GrigStock.Model;
using GrigStock.Sercive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrigStock.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            comboBoxRole.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text != null && textBoxPassword.Text != null && comboBoxRole.Text != null)
            {
                User user = new User();
                user.UserLogin = textBoxLogin.Text;
                user.UserPassword = textBoxPassword.Text;
                user.UserRole = comboBoxRole.Text;
                if (AuthService.Registration(user))
                {
                    MessageBox.Show($"{user.UserLogin} успешно внесён в систему");
                    this.Close();
                    LoginForm form = new LoginForm();
                    form.Show();
                }

            }
        }
    }
}
