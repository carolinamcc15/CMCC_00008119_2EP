using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AppUser loginUser = AppUserDAO.VerifyAppUser(txtUser.Text, txtPass.Text);
                if (loginUser.userType)
                {
                    AdminUser admin = new AdminUser(); 
                    admin.Show();   
                }
                else
                {
                    NormalUser normal = new NormalUser(loginUser); 
                    normal.Show();
                }
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Verifique su usuario y contraseña.", "Inicio de sesión fallido",
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePassword pass = new UpdatePassword();
            pass.ShowDialog();
        }
    }
}