//LiveChart comentado debido a desconfiguración de la ventana

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using PieChart = LiveCharts.WinForms.PieChart;

namespace Segundo_Parcial_POO
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
            dgvViewUsers.DataSource = AppUserDAO.ViewAppUsers();
            dgvOrders.DataSource = AppOrderDAO.ViewOrders();
            
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "idUser";
            cmbUsers.DisplayMember = "username";
            cmbUsers.DataSource = AppUserDAO.getAppUsers();
            
            cmbBusinesses.DataSource = null;
            cmbBusinesses.ValueMember = "idBusiness";
            cmbBusinesses.DisplayMember = "name";
            cmbBusinesses.DataSource = BusinessDAO.getBusinesses();
            
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "idBusiness";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getBusinesses();
            
            cmbBusiness2.DataSource = null;
            cmbBusiness2.ValueMember = "idBusiness";
            cmbBusiness2.DisplayMember = "name";
            cmbBusiness2.DataSource = BusinessDAO.getBusinesses();
        }
        private void AdminUser_Load(object sender, EventArgs e)
        {
            CmbProductUpdate();
            
            //LiveChart comentado debido a desconfiguración de la ventana
            /*
            PieChart pie = new PieChart();
            Controls.Add(pie);
            pie.Parent = tabAdmin.TabPages[5];
            pie.Top = 10;
            pie.Left = 10;
            pie.Width = pie.Parent.Width - 30;
            pie.Height = pie.Parent.Height - 30;
            pie.Series = null;
            SeriesCollection collection = new SeriesCollection();
            DataTable dataTable = BusinessDAO.GetColumns();
            foreach (DataRow row in dataTable.Rows)
            {
                collection.Add(new PieSeries
                {
                    Title = row[0].ToString(), Values = new ChartValues<int> {Convert.ToInt32(row[1].ToString())},
                    DataLabels = true
                });
            }

            pie.Series = collection;
            pie.LegendLocation = LegendLocation.Bottom;
            */
            }
    

        private void CmbProductUpdate()
        {
            Business bs = new Business();
            bs = (Business) cmbBusiness2.SelectedItem;
            
            cmbProduct.DataSource = null;
            cmbProduct.ValueMember = nameof(Product.idProduct);
            cmbProduct.DisplayMember = nameof(Product.name);
            cmbProduct.DataSource = ProductsDAO.getProducts(bs);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Length > 0 && txtFullName.Text.Length > 0)
                {
                    AppUser user = new AppUser();
                    user.username = txtUsername.Text;
                    user.password = txtUsername.Text;
                    user.fullName = txtFullName.Text;
                    user.userType = chkAdmin.Checked;
                    AppUserDAO.ExistentUsername(txtUsername.Text);
                    AppUserDAO.CreateAppUser(user);
                    MessageBox.Show("Usuario creado exitosamente.", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Refresh();
                }
            }
            catch (ExistentUsernameException ex)
            {
                MessageBox.Show("El nombre de usuario ya existe.");
            }
            catch (Exception ex)
            {
                 MessageBox.Show("No se pudo crear el usuario.", "Error",
                                MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Refresh(){
            dgvViewUsers.DataSource = AppUserDAO.ViewAppUsers();
            dgvOrders.DataSource = AppOrderDAO.ViewOrders();
            
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "idUser";
            cmbUsers.DisplayMember = "username";
            cmbUsers.DataSource = AppUserDAO.getAppUsers();
            
            cmbBusinesses.DataSource = null;
            cmbBusinesses.ValueMember = "idBusiness";
            cmbBusinesses.DisplayMember = "name";
            cmbBusinesses.DataSource = BusinessDAO.getBusinesses();
            
            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "idBusiness";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getBusinesses();
            
            cmbBusiness2.DataSource = null;
            cmbBusiness2.ValueMember = "idBusiness";
            cmbBusiness2.DisplayMember = "name";
            cmbBusiness2.DataSource = BusinessDAO.getBusinesses();
            CmbProductUpdate();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            AppUser user = (AppUser) cmbUsers.SelectedItem;
            if (MessageBox.Show($"¿Seguro que desea eliminar al usuario {user.username}?",
                    "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                AppUserDAO.DeleteUser(user);
                MessageBox.Show("Usuario eliminado con éxito.", "Hugo App");
                Refresh();
            }
        }

        private void btnAddAdress_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Length > 0 && txtDescription.Text.Length > 0)
                {
                    Business newBusiness = new Business();
                    newBusiness.name = txtName.Text;
                    newBusiness.description = txtDescription.Text;
                    BusinessDAO.InsertBusiness(newBusiness);
                    MessageBox.Show("Negocio agregado exitosamente.", "Hugo App",
                        MessageBoxButtons.OK);
                    Refresh();
                    
                }
                else
                {
                    MessageBox.Show("No se pueden dejar campos vacíos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el negocio.", "Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Business bs = (Business) cmbBusinesses.SelectedItem;
            if (MessageBox.Show($"¿Seguro que desea eliminar el negocio {bs.name}?",
                    "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                BusinessDAO.DeleteBusiness(bs);
                MessageBox.Show("Negocio eliminado con éxito.", "Hugo App");
                Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int cantBusiness = cmbBusiness.Items.Count;
            if (txtProductName.Text.Length > 0 || cantBusiness != 0)
            {
                Business bs = new Business();
                bs = (Business) cmbBusiness.SelectedItem;
                ProductsDAO.InsertProduct(bs, txtProductName.Text);
                MessageBox.Show("Producto agregado exitosamente.", "Hugo App",
                    MessageBoxButtons.OK);
                Refresh();
            }
        }

        private void cmbBusiness2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductUpdate();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            int cantProducts = cmbProduct.Items.Count;
            int cantBusiness = cmbBusiness2.Items.Count;
            if (cantBusiness != 0 && cantProducts !=0)
            {
                Product product = new Product();
                product.idProduct = (int) cmbProduct.SelectedValue;
                product.idBusiness = (int) cmbBusiness2.SelectedValue;
                product.name = cmbProduct.SelectedItem.ToString();
                
                ProductsDAO.DeleteProduct(product);
                MessageBox.Show("Producto eliminado exitosamente.", "Hugo App",
                    MessageBoxButtons.OK);
                Refresh();
            }
        }
        
        
        private void AdminUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

  
    }
}