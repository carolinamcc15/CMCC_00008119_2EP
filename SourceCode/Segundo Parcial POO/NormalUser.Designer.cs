using System.ComponentModel;

namespace Segundo_Parcial_POO
{
    partial class NormalUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(NormalUser));
            this.tlpNormalUser = new System.Windows.Forms.TableLayoutPanel();
            this.tabNormalUser = new System.Windows.Forms.TabControl();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudidOrder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblAddOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lblAdressD = new System.Windows.Forms.Label();
            this.cmbAdress = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tpModifyAdress = new System.Windows.Forms.TabPage();
            this.tlpAdress = new System.Windows.Forms.TableLayoutPanel();
            this.grpModifyAdress = new System.Windows.Forms.GroupBox();
            this.tlpModifyAdress = new System.Windows.Forms.TableLayoutPanel();
            this.txtModifyAd = new System.Windows.Forms.TextBox();
            this.btnDeleteAdress = new System.Windows.Forms.Button();
            this.cmbAdresses = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.grpAddAdress = new System.Windows.Forms.GroupBox();
            this.tlpAddAdress = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewAdress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAdresses = new System.Windows.Forms.DataGridView();
            this.tlpNormalUser.SuspendLayout();
            this.tabNormalUser.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudidOrder)).BeginInit();
            this.grpOrders.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).BeginInit();
            this.tpModifyAdress.SuspendLayout();
            this.tlpAdress.SuspendLayout();
            this.grpModifyAdress.SuspendLayout();
            this.tlpModifyAdress.SuspendLayout();
            this.grpAddAdress.SuspendLayout();
            this.tlpAddAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdresses)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpNormalUser
            // 
            this.tlpNormalUser.BackColor = System.Drawing.Color.Transparent;
            this.tlpNormalUser.ColumnCount = 3;
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.280156F));
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.14786F));
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.669261F));
            this.tlpNormalUser.Controls.Add(this.tabNormalUser, 1, 1);
            this.tlpNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNormalUser.Location = new System.Drawing.Point(0, 0);
            this.tlpNormalUser.Name = "tlpNormalUser";
            this.tlpNormalUser.RowCount = 3;
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.534005F));
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.92443F));
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.415617F));
            this.tlpNormalUser.Size = new System.Drawing.Size(1028, 794);
            this.tlpNormalUser.TabIndex = 2;
            // 
            // tabNormalUser
            // 
            this.tabNormalUser.Controls.Add(this.tpOrders);
            this.tabNormalUser.Controls.Add(this.tpModifyAdress);
            this.tabNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNormalUser.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabNormalUser.Location = new System.Drawing.Point(46, 39);
            this.tabNormalUser.Name = "tabNormalUser";
            this.tabNormalUser.SelectedIndex = 0;
            this.tabNormalUser.Size = new System.Drawing.Size(930, 708);
            this.tabNormalUser.TabIndex = 0;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.tableLayoutPanel1);
            this.tpOrders.Location = new System.Drawing.Point(4, 37);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(922, 667);
            this.tpOrders.TabIndex = 0;
            this.tpOrders.Text = "Órdenes";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.24823F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.75177F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Controls.Add(this.nudidOrder, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.grpOrders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvOrders, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.81392F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.38578F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.95159F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nudidOrder
            // 
            this.nudidOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudidOrder.Location = new System.Drawing.Point(505, 604);
            this.nudidOrder.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudidOrder.Name = "nudidOrder";
            this.nudidOrder.Size = new System.Drawing.Size(149, 34);
            this.nudidOrder.TabIndex = 8;
            this.nudidOrder.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(279, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID de orden:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(728, 594);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 53);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpOrders
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grpOrders, 3);
            this.grpOrders.Controls.Add(this.tableLayoutPanel2);
            this.grpOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOrders.Location = new System.Drawing.Point(3, 3);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(910, 276);
            this.grpOrders.TabIndex = 0;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Añadir orden";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.13274F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.86726F));
            this.tableLayoutPanel2.Controls.Add(this.cmbBusiness, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbProducts, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAddOrder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAddOrder, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAdressD, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbAdress, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.1608F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.13568F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.1809F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(904, 243);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBusiness.FormattingEnabled = true;
            this.cmbBusiness.Location = new System.Drawing.Point(410, 15);
            this.cmbBusiness.Name = "cmbBusiness";
            this.cmbBusiness.Size = new System.Drawing.Size(393, 36);
            this.cmbBusiness.TabIndex = 4;
            this.cmbBusiness.SelectedIndexChanged += new System.EventHandler(this.cmbBusiness_SelectedIndexChanged);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(410, 68);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(393, 36);
            this.cmbProducts.TabIndex = 3;
            // 
            // lblAddOrder
            // 
            this.lblAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddOrder.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddOrder.Location = new System.Drawing.Point(69, 7);
            this.lblAddOrder.Name = "lblAddOrder";
            this.lblAddOrder.Size = new System.Drawing.Size(268, 44);
            this.lblAddOrder.TabIndex = 0;
            this.lblAddOrder.Text = "Seleccione negocio:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un producto:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrder.BackColor = System.Drawing.Color.Lavender;
            this.tableLayoutPanel2.SetColumnSpan(this.btnAddOrder, 2);
            this.btnAddOrder.Location = new System.Drawing.Point(372, 181);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(160, 53);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Agregar";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lblAdressD
            // 
            this.lblAdressD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdressD.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdressD.Location = new System.Drawing.Point(69, 117);
            this.lblAdressD.Name = "lblAdressD";
            this.lblAdressD.Size = new System.Drawing.Size(268, 44);
            this.lblAdressD.TabIndex = 6;
            this.lblAdressD.Text = "Seleccione la dirección:";
            // 
            // cmbAdress
            // 
            this.cmbAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAdress.FormattingEnabled = true;
            this.cmbAdress.Location = new System.Drawing.Point(410, 121);
            this.cmbAdress.Name = "cmbAdress";
            this.cmbAdress.Size = new System.Drawing.Size(393, 36);
            this.cmbAdress.TabIndex = 7;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvOrders, 3);
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 285);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(910, 293);
            this.dgvOrders.TabIndex = 1;
            // 
            // tpModifyAdress
            // 
            this.tpModifyAdress.Controls.Add(this.tlpAdress);
            this.tpModifyAdress.Location = new System.Drawing.Point(4, 37);
            this.tpModifyAdress.Name = "tpModifyAdress";
            this.tpModifyAdress.Padding = new System.Windows.Forms.Padding(3);
            this.tpModifyAdress.Size = new System.Drawing.Size(922, 667);
            this.tpModifyAdress.TabIndex = 1;
            this.tpModifyAdress.Text = "Modificar direcciones";
            this.tpModifyAdress.UseVisualStyleBackColor = true;
            // 
            // tlpAdress
            // 
            this.tlpAdress.ColumnCount = 1;
            this.tlpAdress.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.60262F));
            this.tlpAdress.Controls.Add(this.grpModifyAdress, 0, 1);
            this.tlpAdress.Controls.Add(this.grpAddAdress, 0, 0);
            this.tlpAdress.Controls.Add(this.dgvAdresses, 0, 2);
            this.tlpAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdress.Location = new System.Drawing.Point(3, 3);
            this.tlpAdress.Name = "tlpAdress";
            this.tlpAdress.RowCount = 5;
            this.tlpAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91074F));
            this.tlpAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.40847F));
            this.tlpAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.59002F));
            this.tlpAdress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAdress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAdress.Size = new System.Drawing.Size(916, 661);
            this.tlpAdress.TabIndex = 1;
            // 
            // grpModifyAdress
            // 
            this.grpModifyAdress.Controls.Add(this.tlpModifyAdress);
            this.grpModifyAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModifyAdress.Location = new System.Drawing.Point(3, 128);
            this.grpModifyAdress.Name = "grpModifyAdress";
            this.grpModifyAdress.Size = new System.Drawing.Size(910, 195);
            this.grpModifyAdress.TabIndex = 1;
            this.grpModifyAdress.TabStop = false;
            this.grpModifyAdress.Text = "Modificar dirección";
            // 
            // tlpModifyAdress
            // 
            this.tlpModifyAdress.ColumnCount = 2;
            this.tlpModifyAdress.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.46017F));
            this.tlpModifyAdress.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.53983F));
            this.tlpModifyAdress.Controls.Add(this.txtModifyAd, 0, 1);
            this.tlpModifyAdress.Controls.Add(this.btnDeleteAdress, 1, 0);
            this.tlpModifyAdress.Controls.Add(this.cmbAdresses, 0, 0);
            this.tlpModifyAdress.Controls.Add(this.btnModify, 1, 1);
            this.tlpModifyAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModifyAdress.Location = new System.Drawing.Point(3, 30);
            this.tlpModifyAdress.Name = "tlpModifyAdress";
            this.tlpModifyAdress.RowCount = 2;
            this.tlpModifyAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModifyAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModifyAdress.Size = new System.Drawing.Size(904, 162);
            this.tlpModifyAdress.TabIndex = 0;
            // 
            // txtModifyAd
            // 
            this.txtModifyAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModifyAd.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtModifyAd.Location = new System.Drawing.Point(7, 103);
            this.txtModifyAd.Name = "txtModifyAd";
            this.txtModifyAd.Size = new System.Drawing.Size(630, 37);
            this.txtModifyAd.TabIndex = 0;
            // 
            // btnDeleteAdress
            // 
            this.btnDeleteAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAdress.BackColor = System.Drawing.Color.Lavender;
            this.btnDeleteAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAdress.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteAdress.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteAdress.Location = new System.Drawing.Point(691, 16);
            this.btnDeleteAdress.Name = "btnDeleteAdress";
            this.btnDeleteAdress.Size = new System.Drawing.Size(167, 49);
            this.btnDeleteAdress.TabIndex = 2;
            this.btnDeleteAdress.Text = "Eliminar";
            this.btnDeleteAdress.UseVisualStyleBackColor = false;
            this.btnDeleteAdress.Click += new System.EventHandler(this.btnDeleteAdress_Click);
            // 
            // cmbAdresses
            // 
            this.cmbAdresses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAdresses.FormattingEnabled = true;
            this.cmbAdresses.Location = new System.Drawing.Point(63, 22);
            this.cmbAdresses.Name = "cmbAdresses";
            this.cmbAdresses.Size = new System.Drawing.Size(518, 36);
            this.cmbAdresses.TabIndex = 3;
            this.cmbAdresses.SelectedIndexChanged += new System.EventHandler(this.cmbAdresses_SelectedIndexChanged);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModify.BackColor = System.Drawing.Color.Lavender;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnModify.Location = new System.Drawing.Point(691, 97);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(167, 49);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modificar";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // grpAddAdress
            // 
            this.grpAddAdress.Controls.Add(this.tlpAddAdress);
            this.grpAddAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAddAdress.Location = new System.Drawing.Point(3, 3);
            this.grpAddAdress.Name = "grpAddAdress";
            this.grpAddAdress.Size = new System.Drawing.Size(910, 119);
            this.grpAddAdress.TabIndex = 0;
            this.grpAddAdress.TabStop = false;
            this.grpAddAdress.Text = "Agregar dirección";
            // 
            // tlpAddAdress
            // 
            this.tlpAddAdress.ColumnCount = 2;
            this.tlpAddAdress.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.46017F));
            this.tlpAddAdress.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.53982F));
            this.tlpAddAdress.Controls.Add(this.txtNewAdress, 0, 0);
            this.tlpAddAdress.Controls.Add(this.btnAdd, 1, 0);
            this.tlpAddAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddAdress.Location = new System.Drawing.Point(3, 30);
            this.tlpAddAdress.Name = "tlpAddAdress";
            this.tlpAddAdress.RowCount = 1;
            this.tlpAddAdress.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAddAdress.Size = new System.Drawing.Size(904, 86);
            this.tlpAddAdress.TabIndex = 0;
            // 
            // txtNewAdress
            // 
            this.txtNewAdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewAdress.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNewAdress.Location = new System.Drawing.Point(8, 24);
            this.txtNewAdress.Name = "txtNewAdress";
            this.txtNewAdress.Size = new System.Drawing.Size(630, 37);
            this.txtNewAdress.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdd.Location = new System.Drawing.Point(691, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 49);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAdresses
            // 
            this.dgvAdresses.AllowUserToAddRows = false;
            this.dgvAdresses.AllowUserToDeleteRows = false;
            this.dgvAdresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdresses.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdresses.Location = new System.Drawing.Point(3, 329);
            this.dgvAdresses.Name = "dgvAdresses";
            this.dgvAdresses.ReadOnly = true;
            this.tlpAdress.SetRowSpan(this.dgvAdresses, 3);
            this.dgvAdresses.RowTemplate.Height = 28;
            this.dgvAdresses.Size = new System.Drawing.Size(910, 329);
            this.dgvAdresses.TabIndex = 2;
            // 
            // NormalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Segundo_Parcial_POO.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 794);
            this.Controls.Add(this.tlpNormalUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NormalUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo - Bienvenido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NormalUser_FormClosed);
            this.Load += new System.EventHandler(this.NormalUser_Load);
            this.tlpNormalUser.ResumeLayout(false);
            this.tabNormalUser.ResumeLayout(false);
            this.tpOrders.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.nudidOrder)).EndInit();
            this.grpOrders.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).EndInit();
            this.tpModifyAdress.ResumeLayout(false);
            this.tlpAdress.ResumeLayout(false);
            this.grpModifyAdress.ResumeLayout(false);
            this.tlpModifyAdress.ResumeLayout(false);
            this.tlpModifyAdress.PerformLayout();
            this.grpAddAdress.ResumeLayout(false);
            this.tlpAddAdress.ResumeLayout(false);
            this.tlpAddAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdresses)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNormalUser;
        private System.Windows.Forms.TabControl tabNormalUser;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.TabPage tpModifyAdress;
        private System.Windows.Forms.TableLayoutPanel tlpAdress;
        private System.Windows.Forms.GroupBox grpAddAdress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewAdress;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TableLayoutPanel tlpModifyAdress;
        private System.Windows.Forms.GroupBox grpModifyAdress;
        private System.Windows.Forms.TableLayoutPanel tlpAddAdress;
        private System.Windows.Forms.Button btnDeleteAdress;
        private System.Windows.Forms.ComboBox cmbAdresses;
        private System.Windows.Forms.DataGridView dgvAdresses;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudidOrder;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.TextBox txtModifyAd;
        private System.Windows.Forms.Label lblAdressD;
        private System.Windows.Forms.ComboBox cmbAdress;
    }
}