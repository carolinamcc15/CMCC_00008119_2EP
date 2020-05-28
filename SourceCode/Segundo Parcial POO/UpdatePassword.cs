using System;
using System.Windows.Forms;

namespace Segundo_Parcial_POO
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                AppUser user = AppUserDAO.VerifyAppUser(txtUsername.Text, txtCurrentPass.Text);
                AppUserDAO.UpdatePassword(user, txtNewPass.Text);
                MessageBox.Show("Su contraseña fue actualizada exitosamente", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique su usuario y contraseña actual.", "Cambio de contraseña fallido",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
    }
}