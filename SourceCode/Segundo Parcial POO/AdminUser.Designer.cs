using System;
using System.ComponentModel;

namespace Segundo_Parcial_POO
{
    partial class AdminUser
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
                new System.ComponentModel.ComponentResourceManager(typeof(AdminUser));
            this.tlpAdminUser = new System.Windows.Forms.TableLayoutPanel();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tpModifyUsers = new System.Windows.Forms.TabPage();
            this.tlpModifyUsers = new System.Windows.Forms.TableLayoutPanel();
            this.grpDeleteUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpCreateUser = new System.Windows.Forms.GroupBox();
            this.tlpCreateUser = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.tbViewUsers = new System.Windows.Forms.TabPage();
            this.tlpViewUsers = new System.Windows.Forms.TableLayoutPanel();
            this.dgvViewUsers = new System.Windows.Forms.DataGridView();
            this.tpBusiness = new System.Windows.Forms.TabPage();
            this.tlpBusiness = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAddBusiness = new System.Windows.Forms.Label();
            this.lblDeleteBusiness = new System.Windows.Forms.Label();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.cmbBusinesses = new System.Windows.Forms.ComboBox();
            this.btnDeleteBusiness = new System.Windows.Forms.Button();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.tlpProducts = new System.Windows.Forms.TableLayoutPanel();
            this.lblDeleteP = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblBusinesses = new System.Windows.Forms.Label();
            this.cmbBusiness = new System.Windows.Forms.ComboBox();
            this.lblAddP = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cmbBusiness2 = new System.Windows.Forms.ComboBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.tpViewOrders = new System.Windows.Forms.TabPage();
            this.tlpViewOrders = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tpLiveChart = new System.Windows.Forms.TabPage();
            this.tlpAdminUser.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tpModifyUsers.SuspendLayout();
            this.tlpModifyUsers.SuspendLayout();
            this.grpDeleteUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCreateUser.SuspendLayout();
            this.tlpCreateUser.SuspendLayout();
            this.tbViewUsers.SuspendLayout();
            this.tlpViewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvViewUsers)).BeginInit();
            this.tpBusiness.SuspendLayout();
            this.tlpBusiness.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.tlpProducts.SuspendLayout();
            this.tpViewOrders.SuspendLayout();
            this.tlpViewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAdminUser
            // 
            this.tlpAdminUser.BackColor = System.Drawing.Color.Transparent;
            this.tlpAdminUser.ColumnCount = 3;
            this.tlpAdminUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.280156F));
            this.tlpAdminUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.14786F));
            this.tlpAdminUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.669261F));
            this.tlpAdminUser.Controls.Add(this.tabAdmin, 1, 1);
            this.tlpAdminUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdminUser.Location = new System.Drawing.Point(0, 0);
            this.tlpAdminUser.Name = "tlpAdminUser";
            this.tlpAdminUser.RowCount = 3;
            this.tlpAdminUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.534005F));
            this.tlpAdminUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.92443F));
            this.tlpAdminUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.415617F));
            this.tlpAdminUser.Size = new System.Drawing.Size(1028, 794);
            this.tlpAdminUser.TabIndex = 1;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tpModifyUsers);
            this.tabAdmin.Controls.Add(this.tbViewUsers);
            this.tabAdmin.Controls.Add(this.tpBusiness);
            this.tabAdmin.Controls.Add(this.tpProducts);
            this.tabAdmin.Controls.Add(this.tpViewOrders);
            this.tabAdmin.Controls.Add(this.tpLiveChart);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAdmin.Location = new System.Drawing.Point(46, 39);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(930, 708);
            this.tabAdmin.TabIndex = 0;
            // 
            // tpModifyUsers
            // 
            this.tpModifyUsers.BackColor = System.Drawing.Color.White;
            this.tpModifyUsers.Controls.Add(this.tlpModifyUsers);
            this.tpModifyUsers.Location = new System.Drawing.Point(4, 37);
            this.tpModifyUsers.Name = "tpModifyUsers";
            this.tpModifyUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpModifyUsers.Size = new System.Drawing.Size(922, 667);
            this.tpModifyUsers.TabIndex = 0;
            this.tpModifyUsers.Text = "Modificar usuarios";
            // 
            // tlpModifyUsers
            // 
            this.tlpModifyUsers.BackColor = System.Drawing.Color.White;
            this.tlpModifyUsers.ColumnCount = 1;
            this.tlpModifyUsers.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpModifyUsers.Controls.Add(this.grpDeleteUser, 0, 1);
            this.tlpModifyUsers.Controls.Add(this.grpCreateUser, 0, 0);
            this.tlpModifyUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModifyUsers.Location = new System.Drawing.Point(3, 3);
            this.tlpModifyUsers.Name = "tlpModifyUsers";
            this.tlpModifyUsers.RowCount = 3;
            this.tlpModifyUsers.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.90625F));
            this.tlpModifyUsers.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.09375F));
            this.tlpModifyUsers.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpModifyUsers.Size = new System.Drawing.Size(916, 661);
            this.tlpModifyUsers.TabIndex = 1;
            // 
            // grpDeleteUser
            // 
            this.grpDeleteUser.Controls.Add(this.tableLayoutPanel1);
            this.grpDeleteUser.Location = new System.Drawing.Point(3, 387);
            this.grpDeleteUser.Name = "grpDeleteUser";
            this.grpDeleteUser.Size = new System.Drawing.Size(910, 262);
            this.grpDeleteUser.TabIndex = 1;
            this.grpDeleteUser.TabStop = false;
            this.grpDeleteUser.Text = "Eliminar usuario";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbUsers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.30357F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.69643F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbUsers
            // 
            this.cmbUsers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(280, 68);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(344, 36);
            this.cmbUsers.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Lavender;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(367, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(169, 52);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpCreateUser
            // 
            this.grpCreateUser.Controls.Add(this.tlpCreateUser);
            this.grpCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCreateUser.Location = new System.Drawing.Point(3, 3);
            this.grpCreateUser.Name = "grpCreateUser";
            this.grpCreateUser.Size = new System.Drawing.Size(910, 378);
            this.grpCreateUser.TabIndex = 0;
            this.grpCreateUser.TabStop = false;
            this.grpCreateUser.Text = "Crear usuario";
            // 
            // tlpCreateUser
            // 
            this.tlpCreateUser.BackColor = System.Drawing.Color.Transparent;
            this.tlpCreateUser.ColumnCount = 3;
            this.tlpCreateUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.40708F));
            this.tlpCreateUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.88496F));
            this.tlpCreateUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.48673F));
            this.tlpCreateUser.Controls.Add(this.btnCreate, 2, 3);
            this.tlpCreateUser.Controls.Add(this.lblPass, 2, 2);
            this.tlpCreateUser.Controls.Add(this.lblPassword, 1, 2);
            this.tlpCreateUser.Controls.Add(this.lblUsername, 1, 1);
            this.tlpCreateUser.Controls.Add(this.lblFullName, 1, 0);
            this.tlpCreateUser.Controls.Add(this.txtUsername, 2, 1);
            this.tlpCreateUser.Controls.Add(this.txtFullName, 2, 0);
            this.tlpCreateUser.Controls.Add(this.chkAdmin, 2, 3);
            this.tlpCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCreateUser.Location = new System.Drawing.Point(3, 30);
            this.tlpCreateUser.Name = "tlpCreateUser";
            this.tlpCreateUser.RowCount = 5;
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.14815F));
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.59259F));
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.7037F));
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.55556F));
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpCreateUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCreateUser.Size = new System.Drawing.Size(904, 345);
            this.tlpCreateUser.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.Lavender;
            this.tlpCreateUser.SetColumnSpan(this.btnCreate, 3);
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(367, 281);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(169, 52);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPass
            // 
            this.lblPass.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.lblPass.BackColor = System.Drawing.Color.White;
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPass.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPass.ForeColor = System.Drawing.Color.Gray;
            this.lblPass.Location = new System.Drawing.Point(313, 167);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(412, 34);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Generada por defecto";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPassword.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassword.Location = new System.Drawing.Point(120, 162);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(146, 39);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUsername.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsername.Location = new System.Drawing.Point(138, 94);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 43);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Usuario:";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFullName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFullName.Location = new System.Drawing.Point(79, 33);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(228, 43);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Nombre completo:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsername.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.Location = new System.Drawing.Point(313, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(412, 37);
            this.txtUsername.TabIndex = 7;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.txtFullName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFullName.Location = new System.Drawing.Point(313, 36);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(412, 37);
            this.txtFullName.TabIndex = 8;
            // 
            // chkAdmin
            // 
            this.chkAdmin.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkAdmin.Location = new System.Drawing.Point(313, 204);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(174, 51);
            this.chkAdmin.TabIndex = 9;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // tbViewUsers
            // 
            this.tbViewUsers.Controls.Add(this.tlpViewUsers);
            this.tbViewUsers.Location = new System.Drawing.Point(4, 37);
            this.tbViewUsers.Name = "tbViewUsers";
            this.tbViewUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewUsers.Size = new System.Drawing.Size(922, 667);
            this.tbViewUsers.TabIndex = 1;
            this.tbViewUsers.Text = "Ver usuarios";
            this.tbViewUsers.UseVisualStyleBackColor = true;
            // 
            // tlpViewUsers
            // 
            this.tlpViewUsers.BackColor = System.Drawing.Color.White;
            this.tlpViewUsers.ColumnCount = 2;
            this.tlpViewUsers.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewUsers.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewUsers.Controls.Add(this.dgvViewUsers, 0, 0);
            this.tlpViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewUsers.Location = new System.Drawing.Point(3, 3);
            this.tlpViewUsers.Name = "tlpViewUsers";
            this.tlpViewUsers.RowCount = 1;
            this.tlpViewUsers.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewUsers.Size = new System.Drawing.Size(916, 661);
            this.tlpViewUsers.TabIndex = 1;
            // 
            // dgvViewUsers
            // 
            this.dgvViewUsers.AllowUserToAddRows = false;
            this.dgvViewUsers.AllowUserToDeleteRows = false;
            this.dgvViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViewUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpViewUsers.SetColumnSpan(this.dgvViewUsers, 2);
            this.dgvViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvViewUsers.Name = "dgvViewUsers";
            this.dgvViewUsers.ReadOnly = true;
            this.dgvViewUsers.RowTemplate.Height = 28;
            this.dgvViewUsers.Size = new System.Drawing.Size(910, 655);
            this.dgvViewUsers.TabIndex = 0;
            // 
            // tpBusiness
            // 
            this.tpBusiness.Controls.Add(this.tlpBusiness);
            this.tpBusiness.Location = new System.Drawing.Point(4, 37);
            this.tpBusiness.Name = "tpBusiness";
            this.tpBusiness.Size = new System.Drawing.Size(922, 667);
            this.tpBusiness.TabIndex = 2;
            this.tpBusiness.Text = "Negocios";
            this.tpBusiness.UseVisualStyleBackColor = true;
            // 
            // tlpBusiness
            // 
            this.tlpBusiness.BackColor = System.Drawing.Color.White;
            this.tlpBusiness.ColumnCount = 4;
            this.tlpBusiness.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.89086F));
            this.tlpBusiness.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97649F));
            this.tlpBusiness.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.76338F));
            this.tlpBusiness.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.36926F));
            this.tlpBusiness.Controls.Add(this.lblName, 1, 2);
            this.tlpBusiness.Controls.Add(this.lblDescription, 1, 3);
            this.tlpBusiness.Controls.Add(this.txtName, 2, 2);
            this.tlpBusiness.Controls.Add(this.txtDescription, 2, 3);
            this.tlpBusiness.Controls.Add(this.lblAddBusiness, 0, 1);
            this.tlpBusiness.Controls.Add(this.lblDeleteBusiness, 0, 5);
            this.tlpBusiness.Controls.Add(this.btnAddBusiness, 0, 4);
            this.tlpBusiness.Controls.Add(this.cmbBusinesses, 0, 6);
            this.tlpBusiness.Controls.Add(this.btnDeleteBusiness, 2, 8);
            this.tlpBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBusiness.Location = new System.Drawing.Point(0, 0);
            this.tlpBusiness.Name = "tlpBusiness";
            this.tlpBusiness.RowCount = 9;
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.998501F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.3943F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.745128F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.7946F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.14393F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.49026F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.797601F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.997002F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.1994F));
            this.tlpBusiness.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.28936F));
            this.tlpBusiness.Size = new System.Drawing.Size(922, 667);
            this.tlpBusiness.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.Location = new System.Drawing.Point(53, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(167, 65);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescription.Location = new System.Drawing.Point(53, 162);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(167, 70);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripción:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtName.Location = new System.Drawing.Point(273, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(573, 37);
            this.txtName.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDescription.Location = new System.Drawing.Point(273, 178);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(573, 37);
            this.txtDescription.TabIndex = 5;
            // 
            // lblAddBusiness
            // 
            this.lblAddBusiness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpBusiness.SetColumnSpan(this.lblAddBusiness, 4);
            this.lblAddBusiness.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddBusiness.Location = new System.Drawing.Point(307, 23);
            this.lblAddBusiness.Name = "lblAddBusiness";
            this.lblAddBusiness.Size = new System.Drawing.Size(308, 70);
            this.lblAddBusiness.TabIndex = 0;
            this.lblAddBusiness.Text = "Agregar un negocio";
            this.lblAddBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeleteBusiness
            // 
            this.lblDeleteBusiness.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlpBusiness.SetColumnSpan(this.lblDeleteBusiness, 4);
            this.lblDeleteBusiness.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDeleteBusiness.Location = new System.Drawing.Point(286, 339);
            this.lblDeleteBusiness.Name = "lblDeleteBusiness";
            this.lblDeleteBusiness.Size = new System.Drawing.Size(350, 105);
            this.lblDeleteBusiness.TabIndex = 1;
            this.lblDeleteBusiness.Text = "Eliminar negocio";
            this.lblDeleteBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddBusiness.BackColor = System.Drawing.Color.Lavender;
            this.tlpBusiness.SetColumnSpan(this.btnAddBusiness, 4);
            this.btnAddBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBusiness.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddBusiness.Location = new System.Drawing.Point(386, 243);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(150, 61);
            this.btnAddBusiness.TabIndex = 6;
            this.btnAddBusiness.Text = "Agregar";
            this.btnAddBusiness.UseVisualStyleBackColor = false;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddAdress_Click);
            // 
            // cmbBusinesses
            // 
            this.cmbBusinesses.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlpBusiness.SetColumnSpan(this.cmbBusinesses, 4);
            this.cmbBusinesses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusinesses.FormattingEnabled = true;
            this.cmbBusinesses.Location = new System.Drawing.Point(237, 447);
            this.cmbBusinesses.Name = "cmbBusinesses";
            this.cmbBusinesses.Size = new System.Drawing.Size(447, 36);
            this.cmbBusinesses.TabIndex = 7;
            // 
            // btnDeleteBusiness
            // 
            this.btnDeleteBusiness.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteBusiness.BackColor = System.Drawing.Color.Lavender;
            this.tlpBusiness.SetColumnSpan(this.btnDeleteBusiness, 4);
            this.btnDeleteBusiness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBusiness.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteBusiness.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteBusiness.Location = new System.Drawing.Point(386, 527);
            this.btnDeleteBusiness.Name = "btnDeleteBusiness";
            this.btnDeleteBusiness.Size = new System.Drawing.Size(150, 61);
            this.btnDeleteBusiness.TabIndex = 8;
            this.btnDeleteBusiness.Text = "Eliminar";
            this.btnDeleteBusiness.UseVisualStyleBackColor = false;
            this.btnDeleteBusiness.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.tlpProducts);
            this.tpProducts.Location = new System.Drawing.Point(4, 37);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Size = new System.Drawing.Size(922, 667);
            this.tpProducts.TabIndex = 3;
            this.tpProducts.Text = "Productos";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // tlpProducts
            // 
            this.tlpProducts.BackColor = System.Drawing.Color.White;
            this.tlpProducts.ColumnCount = 3;
            this.tlpProducts.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.161138F));
            this.tlpProducts.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.83886F));
            this.tlpProducts.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 446F));
            this.tlpProducts.Controls.Add(this.lblDeleteP, 0, 4);
            this.tlpProducts.Controls.Add(this.lblProductName, 1, 2);
            this.tlpProducts.Controls.Add(this.lblBusinesses, 1, 1);
            this.tlpProducts.Controls.Add(this.cmbBusiness, 2, 1);
            this.tlpProducts.Controls.Add(this.lblAddP, 0, 0);
            this.tlpProducts.Controls.Add(this.txtProductName, 2, 2);
            this.tlpProducts.Controls.Add(this.cmbBusiness2, 2, 5);
            this.tlpProducts.Controls.Add(this.lblProducts, 1, 5);
            this.tlpProducts.Controls.Add(this.btnAdd, 0, 3);
            this.tlpProducts.Controls.Add(this.btnDeleteP, 2, 6);
            this.tlpProducts.Controls.Add(this.label1, 1, 6);
            this.tlpProducts.Controls.Add(this.cmbProduct, 2, 6);
            this.tlpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProducts.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tlpProducts.Location = new System.Drawing.Point(0, 0);
            this.tlpProducts.Name = "tlpProducts";
            this.tlpProducts.RowCount = 9;
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46577F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60307F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5937F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.04498F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84258F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.44378F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29385F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.745128F));
            this.tlpProducts.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.778545F));
            this.tlpProducts.Size = new System.Drawing.Size(922, 667);
            this.tlpProducts.TabIndex = 1;
            // 
            // lblDeleteP
            // 
            this.lblDeleteP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tlpProducts.SetColumnSpan(this.lblDeleteP, 3);
            this.lblDeleteP.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDeleteP.Location = new System.Drawing.Point(338, 350);
            this.lblDeleteP.Name = "lblDeleteP";
            this.lblDeleteP.Size = new System.Drawing.Size(245, 53);
            this.lblDeleteP.TabIndex = 8;
            this.lblDeleteP.Text = "Eliminar producto";
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.Location = new System.Drawing.Point(90, 179);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(324, 31);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Nombre del producto:";
            // 
            // lblBusinesses
            // 
            this.lblBusinesses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusinesses.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblBusinesses.Location = new System.Drawing.Point(96, 101);
            this.lblBusinesses.Name = "lblBusinesses";
            this.lblBusinesses.Size = new System.Drawing.Size(312, 34);
            this.lblBusinesses.TabIndex = 1;
            this.lblBusinesses.Text = "Seleccione el negocio: ";
            // 
            // cmbBusiness
            // 
            this.cmbBusiness.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusiness.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbBusiness.FormattingEnabled = true;
            this.cmbBusiness.Location = new System.Drawing.Point(478, 99);
            this.cmbBusiness.Name = "cmbBusiness";
            this.cmbBusiness.Size = new System.Drawing.Size(354, 38);
            this.cmbBusiness.TabIndex = 0;
            // 
            // lblAddP
            // 
            this.lblAddP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpProducts.SetColumnSpan(this.lblAddP, 3);
            this.lblAddP.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAddP.Location = new System.Drawing.Point(317, 15);
            this.lblAddP.Name = "lblAddP";
            this.lblAddP.Size = new System.Drawing.Size(288, 53);
            this.lblAddP.TabIndex = 5;
            this.lblAddP.Text = "Agregar un producto";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductName.Location = new System.Drawing.Point(478, 176);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(354, 37);
            this.txtProductName.TabIndex = 6;
            // 
            // cmbBusiness2
            // 
            this.cmbBusiness2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBusiness2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusiness2.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbBusiness2.FormattingEnabled = true;
            this.cmbBusiness2.Location = new System.Drawing.Point(478, 425);
            this.cmbBusiness2.Name = "cmbBusiness2";
            this.cmbBusiness2.Size = new System.Drawing.Size(354, 38);
            this.cmbBusiness2.TabIndex = 2;
            this.cmbBusiness2.SelectedIndexChanged += new System.EventHandler(this.cmbBusiness2_SelectedIndexChanged);
            // 
            // lblProducts
            // 
            this.lblProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProducts.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProducts.Location = new System.Drawing.Point(87, 427);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(329, 34);
            this.lblProducts.TabIndex = 3;
            this.lblProducts.Text = "Seleccione el negocio: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.Lavender;
            this.tlpProducts.SetColumnSpan(this.btnAdd, 3);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(394, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 52);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteP.BackColor = System.Drawing.Color.Lavender;
            this.tlpProducts.SetColumnSpan(this.btnDeleteP, 3);
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteP.Location = new System.Drawing.Point(394, 576);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(134, 49);
            this.btnDeleteP.TabIndex = 9;
            this.btnDeleteP.Text = "Eliminar";
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(90, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del producto:";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(478, 508);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(354, 38);
            this.cmbProduct.TabIndex = 11;
            // 
            // tpViewOrders
            // 
            this.tpViewOrders.Controls.Add(this.tlpViewOrders);
            this.tpViewOrders.Location = new System.Drawing.Point(4, 37);
            this.tpViewOrders.Name = "tpViewOrders";
            this.tpViewOrders.Size = new System.Drawing.Size(922, 667);
            this.tpViewOrders.TabIndex = 4;
            this.tpViewOrders.Text = "Ver órdenes";
            this.tpViewOrders.UseVisualStyleBackColor = true;
            // 
            // tlpViewOrders
            // 
            this.tlpViewOrders.BackColor = System.Drawing.Color.White;
            this.tlpViewOrders.ColumnCount = 2;
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewOrders.Controls.Add(this.dgvOrders, 0, 0);
            this.tlpViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewOrders.Location = new System.Drawing.Point(0, 0);
            this.tlpViewOrders.Name = "tlpViewOrders";
            this.tlpViewOrders.RowCount = 1;
            this.tlpViewOrders.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpViewOrders.Size = new System.Drawing.Size(922, 667);
            this.tlpViewOrders.TabIndex = 0;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpViewOrders.SetColumnSpan(this.dgvOrders, 2);
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(916, 661);
            this.dgvOrders.TabIndex = 0;
            // 
            // tpLiveChart
            // 
            this.tpLiveChart.Location = new System.Drawing.Point(4, 37);
            this.tpLiveChart.Name = "tpLiveChart";
            this.tpLiveChart.Size = new System.Drawing.Size(922, 667);
            this.tpLiveChart.TabIndex = 5;
            this.tpLiveChart.Text = "Gráfico";
            this.tpLiveChart.UseVisualStyleBackColor = true;
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Segundo_Parcial_POO.Properties.Resources.GeneralBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 794);
            this.Controls.Add(this.tlpAdminUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo - Usuario administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminUser_FormClosed);
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.tlpAdminUser.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tpModifyUsers.ResumeLayout(false);
            this.tlpModifyUsers.ResumeLayout(false);
            this.grpDeleteUser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCreateUser.ResumeLayout(false);
            this.tlpCreateUser.ResumeLayout(false);
            this.tlpCreateUser.PerformLayout();
            this.tbViewUsers.ResumeLayout(false);
            this.tlpViewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvViewUsers)).EndInit();
            this.tpBusiness.ResumeLayout(false);
            this.tlpBusiness.ResumeLayout(false);
            this.tlpBusiness.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tlpProducts.ResumeLayout(false);
            this.tlpProducts.PerformLayout();
            this.tpViewOrders.ResumeLayout(false);
            this.tlpViewOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAdminUser;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tpViewOrders;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.TabPage tpBusiness;
        private System.Windows.Forms.TabPage tpModifyUsers;
        private System.Windows.Forms.TabPage tbViewUsers;
        private System.Windows.Forms.TableLayoutPanel tlpViewOrders;
        private System.Windows.Forms.TableLayoutPanel tlpProducts;
        private System.Windows.Forms.TableLayoutPanel tlpBusiness;
        private System.Windows.Forms.TableLayoutPanel tlpViewUsers;
        private System.Windows.Forms.TableLayoutPanel tlpModifyUsers;
        private System.Windows.Forms.DataGridView dgvViewUsers;
        private System.Windows.Forms.GroupBox grpCreateUser;
        private System.Windows.Forms.TableLayoutPanel tlpCreateUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox grpDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblAddBusiness;
        private System.Windows.Forms.Label lblDeleteBusiness;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbBusinesses;
        private System.Windows.Forms.Button btnDeleteBusiness;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Label lblBusinesses;
        private System.Windows.Forms.ComboBox cmbBusiness;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblAddP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDeleteP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBusiness2;
        private System.Windows.Forms.TabPage tpLiveChart;
    }
}