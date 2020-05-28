using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Segundo_Parcial_POO
{
    public partial class NormalUser : Form
    {
        private AppUser user;

        public NormalUser(AppUser user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {

            dgvAdresses.DataSource = AddressDAO.AddressesFromUser(user);
            dgvOrders.DataSource = AppOrderDAO.ViewUserOrders(user);

            cmbAdresses.DataSource = null;
            cmbAdresses.ValueMember = nameof(Adress.idAdress);
            cmbAdresses.DisplayMember = nameof(Adress.adress);
            cmbAdresses.DataSource = AddressDAO.getAdresses();

            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "idBusiness";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getBusinesses();
            
            cmbAdress.DataSource = null;
            cmbAdress.ValueMember = nameof(Adress.idAdress);
            cmbAdress.DisplayMember = nameof(Adress.adress);
            cmbAdress.DataSource = AddressDAO.getAdresses();
            
            CmbProductUpdate();
        }

        private void Refresh()
        {
            cmbAdresses.DataSource = null;
            cmbAdresses.ValueMember = nameof(Adress.idAdress);
            cmbAdresses.DisplayMember = nameof(Adress.adress);
            cmbAdresses.DataSource = AddressDAO.getAdresses();

            cmbBusiness.DataSource = null;
            cmbBusiness.ValueMember = "idBusiness";
            cmbBusiness.DisplayMember = "name";
            cmbBusiness.DataSource = BusinessDAO.getBusinesses();
            
            cmbAdress.DataSource = null;
            cmbAdress.ValueMember = nameof(Adress.idAdress);
            cmbAdress.DisplayMember = nameof(Adress.adress);
            cmbAdress.DataSource = AddressDAO.getAdresses();

            dgvAdresses.DataSource = AddressDAO.AddressesFromUser(user);
            dgvOrders.DataSource = AppOrderDAO.ViewUserOrders(user);
            
            CmbProductUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewAdress.Text.Length > 0)
            {
                AddressDAO.InsertAdress(user, txtNewAdress.Text);
                MessageBox.Show("Dirección agregada exitosamente.", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresh();
            }
            else
            {
                MessageBox.Show("No se pueden dejar campos vacíos");
            }
        }
    
        private void CmbProductUpdate()
        {
            Business bs = new Business();
            bs = (Business) cmbBusiness.SelectedItem;
            
            cmbProducts.DataSource = null;
            cmbProducts.ValueMember = nameof(Product.idProduct);
            cmbProducts.DisplayMember = nameof(Product.name);
            cmbProducts.DataSource = ProductsDAO.getProducts(bs);

        }

    private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModifyAd.Text.Length > 0)
                {
                    Adress ad = (Adress) cmbAdresses.SelectedItem;
                    if (MessageBox.Show($"¿Seguro que desea modificar la dirección {ad.adress}?",
                            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {

                        AddressDAO.UpdateAdress(ad, txtModifyAd.Text);
                        MessageBox.Show("Dirección modificada exitosamente.", "Hugo App",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden dejar campos vacíos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar la dirección", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cmbAdresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adress ad = (Adress) cmbAdresses.SelectedItem;
            txtModifyAd.Text = ad.adress;
        }

        private void btnDeleteAdress_Click(object sender, EventArgs e)
        {
            try
            {
                Adress ad = (Adress) cmbAdresses.SelectedItem;
                if (MessageBox.Show($"¿Seguro que desea eliminar la dirección {ad.adress}?",
                        "Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    AddressDAO.DeleteAddress(ad);
                    MessageBox.Show("Dirección eliminada exitosamente.", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la dirección", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Adress ad = (Adress) cmbAdress.SelectedItem;
                Product pro = (Product) cmbProducts.SelectedItem;
                AppOrderDAO.InsertOrder(ad, pro);
                MessageBox.Show("Orden agregada exitosamente.", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("La orden no pudo ser agregada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbProductUpdate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                List<AppOrder> list = AppOrderDAO.getAppOrders();
                byte cont = 0;
                foreach(var order in list)
                {
                    if ((int) nudidOrder.Value == order.idOrder)
                        cont++;
                }

                if (cont > 0)
                {
                    AppOrderDAO.DeleteOrder((int) nudidOrder.Value);
                    MessageBox.Show("Orden eliminada exitosamente.", "Hugo App",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("El ID de orden ingresado no existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la orden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NormalUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}