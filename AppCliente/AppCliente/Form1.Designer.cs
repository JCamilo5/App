namespace AppCliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tpcCrudPedido = new System.Windows.Forms.TabControl();
            this.tpIngresar = new System.Windows.Forms.TabPage();
            this.pnlIngesarPed = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSucEmp = new System.Windows.Forms.Button();
            this.cbxClId = new System.Windows.Forms.ComboBox();
            this.lblCli = new System.Windows.Forms.Label();
            this.btnIngreProduct = new System.Windows.Forms.Button();
            this.txtCantiProduct = new System.Windows.Forms.TextBox();
            this.lblTCantiProduct = new System.Windows.Forms.Label();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.lblTProduct = new System.Windows.Forms.Label();
            this.cbxSucid = new System.Windows.Forms.ComboBox();
            this.pnlIngresarEmp = new System.Windows.Forms.Panel();
            this.cbxEmpId = new System.Windows.Forms.ComboBox();
            this.lblTEmpId = new System.Windows.Forms.Label();
            this.lblTIngrsarPed = new System.Windows.Forms.Label();
            this.lblSucId = new System.Windows.Forms.Label();
            this.tpActualizar = new System.Windows.Forms.TabPage();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.pnlActPro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActPed = new System.Windows.Forms.Button();
            this.txtCantiProAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProAct = new System.Windows.Forms.ComboBox();
            this.lblNotaAct = new System.Windows.Forms.Label();
            this.btnAgrProAct = new System.Windows.Forms.Button();
            this.pnlAgreProAct = new System.Windows.Forms.Panel();
            this.txtIdProductAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantiProActAdd = new System.Windows.Forms.TextBox();
            this.btnAgrePro = new System.Windows.Forms.Button();
            this.lblAgreNewProAct = new System.Windows.Forms.Label();
            this.btnSelectPedAct = new System.Windows.Forms.Button();
            this.cbxPedid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblActPed = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.cbxElimPed = new System.Windows.Forms.ComboBox();
            this.lblNotaEliminar = new System.Windows.Forms.Label();
            this.btnEliminarPed = new System.Windows.Forms.Button();
            this.lblElimPed = new System.Windows.Forms.Label();
            this.lblTEliminar = new System.Windows.Forms.Label();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.lblTConsulta = new System.Windows.Forms.Label();
            this.btnConsulPed = new System.Windows.Forms.Button();
            this.txtConsulPed = new System.Windows.Forms.TextBox();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.pnlConexion = new System.Windows.Forms.Panel();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.tpcCrudPedido.SuspendLayout();
            this.tpIngresar.SuspendLayout();
            this.pnlIngesarPed.SuspendLayout();
            this.pnlIngresarEmp.SuspendLayout();
            this.tpActualizar.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.pnlActPro.SuspendLayout();
            this.pnlAgreProAct.SuspendLayout();
            this.tpEliminar.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.tpConsultar.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.pnlConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpcCrudPedido
            // 
            this.tpcCrudPedido.Controls.Add(this.tpIngresar);
            this.tpcCrudPedido.Controls.Add(this.tpActualizar);
            this.tpcCrudPedido.Controls.Add(this.tpEliminar);
            this.tpcCrudPedido.Controls.Add(this.tpConsultar);
            this.tpcCrudPedido.Enabled = false;
            this.tpcCrudPedido.Location = new System.Drawing.Point(2, 53);
            this.tpcCrudPedido.Name = "tpcCrudPedido";
            this.tpcCrudPedido.SelectedIndex = 0;
            this.tpcCrudPedido.Size = new System.Drawing.Size(531, 460);
            this.tpcCrudPedido.TabIndex = 0;
            // 
            // tpIngresar
            // 
            this.tpIngresar.BackColor = System.Drawing.Color.Turquoise;
            this.tpIngresar.Controls.Add(this.pnlIngesarPed);
            this.tpIngresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpIngresar.Location = new System.Drawing.Point(4, 22);
            this.tpIngresar.Name = "tpIngresar";
            this.tpIngresar.Padding = new System.Windows.Forms.Padding(3);
            this.tpIngresar.Size = new System.Drawing.Size(523, 434);
            this.tpIngresar.TabIndex = 0;
            this.tpIngresar.Text = "Ingresar";
            // 
            // pnlIngesarPed
            // 
            this.pnlIngesarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.pnlIngesarPed.Controls.Add(this.btnAddProduct);
            this.pnlIngesarPed.Controls.Add(this.btnSucEmp);
            this.pnlIngesarPed.Controls.Add(this.cbxClId);
            this.pnlIngesarPed.Controls.Add(this.lblCli);
            this.pnlIngesarPed.Controls.Add(this.btnIngreProduct);
            this.pnlIngesarPed.Controls.Add(this.txtCantiProduct);
            this.pnlIngesarPed.Controls.Add(this.lblTCantiProduct);
            this.pnlIngesarPed.Controls.Add(this.cbxProduct);
            this.pnlIngesarPed.Controls.Add(this.lblTProduct);
            this.pnlIngesarPed.Controls.Add(this.cbxSucid);
            this.pnlIngesarPed.Controls.Add(this.pnlIngresarEmp);
            this.pnlIngesarPed.Controls.Add(this.lblTIngrsarPed);
            this.pnlIngesarPed.Controls.Add(this.lblSucId);
            this.pnlIngesarPed.Location = new System.Drawing.Point(6, 6);
            this.pnlIngesarPed.Name = "pnlIngesarPed";
            this.pnlIngesarPed.Size = new System.Drawing.Size(511, 422);
            this.pnlIngesarPed.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(391, 304);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(84, 23);
            this.btnAddProduct.TabIndex = 15;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSucEmp
            // 
            this.btnSucEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnSucEmp.FlatAppearance.BorderSize = 0;
            this.btnSucEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSucEmp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSucEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSucEmp.Location = new System.Drawing.Point(220, 161);
            this.btnSucEmp.Name = "btnSucEmp";
            this.btnSucEmp.Size = new System.Drawing.Size(130, 27);
            this.btnSucEmp.TabIndex = 14;
            this.btnSucEmp.Text = "Buscar Empleados";
            this.btnSucEmp.UseVisualStyleBackColor = false;
            this.btnSucEmp.Click += new System.EventHandler(this.btnSucEmp_Click);
            // 
            // cbxClId
            // 
            this.cbxClId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxClId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxClId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxClId.FormattingEnabled = true;
            this.cbxClId.Location = new System.Drawing.Point(220, 76);
            this.cbxClId.Name = "cbxClId";
            this.cbxClId.Size = new System.Drawing.Size(145, 25);
            this.cbxClId.TabIndex = 13;
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCli.Location = new System.Drawing.Point(22, 80);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(179, 17);
            this.lblCli.TabIndex = 12;
            this.lblCli.Text = "Seleccione el id del cliente";
            // 
            // btnIngreProduct
            // 
            this.btnIngreProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnIngreProduct.FlatAppearance.BorderSize = 0;
            this.btnIngreProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngreProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngreProduct.Location = new System.Drawing.Point(210, 375);
            this.btnIngreProduct.Name = "btnIngreProduct";
            this.btnIngreProduct.Size = new System.Drawing.Size(140, 33);
            this.btnIngreProduct.TabIndex = 11;
            this.btnIngreProduct.Text = "Guardar Pedido";
            this.btnIngreProduct.UseVisualStyleBackColor = false;
            this.btnIngreProduct.Click += new System.EventHandler(this.btnIngreProduct_Click);
            // 
            // txtCantiProduct
            // 
            this.txtCantiProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.txtCantiProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantiProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtCantiProduct.Location = new System.Drawing.Point(298, 304);
            this.txtCantiProduct.Name = "txtCantiProduct";
            this.txtCantiProduct.Size = new System.Drawing.Size(43, 23);
            this.txtCantiProduct.TabIndex = 10;
            // 
            // lblTCantiProduct
            // 
            this.lblTCantiProduct.AutoSize = true;
            this.lblTCantiProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCantiProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTCantiProduct.Location = new System.Drawing.Point(22, 307);
            this.lblTCantiProduct.Name = "lblTCantiProduct";
            this.lblTCantiProduct.Size = new System.Drawing.Size(222, 17);
            this.lblTCantiProduct.TabIndex = 9;
            this.lblTCantiProduct.Text = "Ingrese la cantidad del producto";
            // 
            // cbxProduct
            // 
            this.cbxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProduct.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(220, 259);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(145, 25);
            this.cbxProduct.TabIndex = 8;
            // 
            // lblTProduct
            // 
            this.lblTProduct.AutoSize = true;
            this.lblTProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTProduct.Location = new System.Drawing.Point(22, 259);
            this.lblTProduct.Name = "lblTProduct";
            this.lblTProduct.Size = new System.Drawing.Size(165, 17);
            this.lblTProduct.TabIndex = 7;
            this.lblTProduct.Text = "Seleccione el producto: ";
            // 
            // cbxSucid
            // 
            this.cbxSucid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxSucid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSucid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSucid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxSucid.FormattingEnabled = true;
            this.cbxSucid.Location = new System.Drawing.Point(220, 125);
            this.cbxSucid.Name = "cbxSucid";
            this.cbxSucid.Size = new System.Drawing.Size(145, 25);
            this.cbxSucid.TabIndex = 6;
            // 
            // pnlIngresarEmp
            // 
            this.pnlIngresarEmp.Controls.Add(this.cbxEmpId);
            this.pnlIngresarEmp.Controls.Add(this.lblTEmpId);
            this.pnlIngresarEmp.Location = new System.Drawing.Point(15, 204);
            this.pnlIngresarEmp.Name = "pnlIngresarEmp";
            this.pnlIngresarEmp.Size = new System.Drawing.Size(460, 38);
            this.pnlIngresarEmp.TabIndex = 5;
            this.pnlIngresarEmp.Visible = false;
            // 
            // cbxEmpId
            // 
            this.cbxEmpId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxEmpId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmpId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEmpId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxEmpId.FormattingEnabled = true;
            this.cbxEmpId.Location = new System.Drawing.Point(205, 7);
            this.cbxEmpId.Name = "cbxEmpId";
            this.cbxEmpId.Size = new System.Drawing.Size(234, 25);
            this.cbxEmpId.TabIndex = 3;
            // 
            // lblTEmpId
            // 
            this.lblTEmpId.AutoSize = true;
            this.lblTEmpId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEmpId.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTEmpId.Location = new System.Drawing.Point(7, 11);
            this.lblTEmpId.Name = "lblTEmpId";
            this.lblTEmpId.Size = new System.Drawing.Size(168, 17);
            this.lblTEmpId.TabIndex = 2;
            this.lblTEmpId.Text = "Seleccione el empleado:";
            // 
            // lblTIngrsarPed
            // 
            this.lblTIngrsarPed.AutoSize = true;
            this.lblTIngrsarPed.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIngrsarPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTIngrsarPed.Location = new System.Drawing.Point(110, 16);
            this.lblTIngrsarPed.Name = "lblTIngrsarPed";
            this.lblTIngrsarPed.Size = new System.Drawing.Size(275, 23);
            this.lblTIngrsarPed.TabIndex = 4;
            this.lblTIngrsarPed.Text = "Ingrese la Infromacion del pedido";
            // 
            // lblSucId
            // 
            this.lblSucId.AutoSize = true;
            this.lblSucId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSucId.Location = new System.Drawing.Point(22, 129);
            this.lblSucId.Name = "lblSucId";
            this.lblSucId.Size = new System.Drawing.Size(139, 17);
            this.lblSucId.TabIndex = 3;
            this.lblSucId.Text = "Sleccione la sucursal";
            // 
            // tpActualizar
            // 
            this.tpActualizar.Controls.Add(this.pnlActualizar);
            this.tpActualizar.Location = new System.Drawing.Point(4, 22);
            this.tpActualizar.Name = "tpActualizar";
            this.tpActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizar.Size = new System.Drawing.Size(523, 434);
            this.tpActualizar.TabIndex = 1;
            this.tpActualizar.Text = "Actualizar";
            this.tpActualizar.UseVisualStyleBackColor = true;
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.pnlActualizar.Controls.Add(this.pnlActPro);
            this.pnlActualizar.Controls.Add(this.lblNotaAct);
            this.pnlActualizar.Controls.Add(this.btnAgrProAct);
            this.pnlActualizar.Controls.Add(this.pnlAgreProAct);
            this.pnlActualizar.Controls.Add(this.btnSelectPedAct);
            this.pnlActualizar.Controls.Add(this.cbxPedid);
            this.pnlActualizar.Controls.Add(this.label2);
            this.pnlActualizar.Controls.Add(this.lblActPed);
            this.pnlActualizar.Location = new System.Drawing.Point(3, 3);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(517, 430);
            this.pnlActualizar.TabIndex = 0;
            // 
            // pnlActPro
            // 
            this.pnlActPro.Controls.Add(this.label3);
            this.pnlActPro.Controls.Add(this.btnActPed);
            this.pnlActPro.Controls.Add(this.txtCantiProAct);
            this.pnlActPro.Controls.Add(this.label1);
            this.pnlActPro.Controls.Add(this.cbxProAct);
            this.pnlActPro.Location = new System.Drawing.Point(3, 132);
            this.pnlActPro.Name = "pnlActPro";
            this.pnlActPro.Size = new System.Drawing.Size(492, 99);
            this.pnlActPro.TabIndex = 14;
            this.pnlActPro.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese la nueva cantidad";
            // 
            // btnActPed
            // 
            this.btnActPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnActPed.FlatAppearance.BorderSize = 0;
            this.btnActPed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActPed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActPed.Location = new System.Drawing.Point(291, 55);
            this.btnActPed.Name = "btnActPed";
            this.btnActPed.Size = new System.Drawing.Size(158, 23);
            this.btnActPed.TabIndex = 7;
            this.btnActPed.Text = "Actualizar Cantidad";
            this.btnActPed.UseVisualStyleBackColor = false;
            this.btnActPed.Click += new System.EventHandler(this.btnActPed_Click_1);
            // 
            // txtCantiProAct
            // 
            this.txtCantiProAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.txtCantiProAct.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantiProAct.Location = new System.Drawing.Point(198, 55);
            this.txtCantiProAct.Name = "txtCantiProAct";
            this.txtCantiProAct.Size = new System.Drawing.Size(43, 20);
            this.txtCantiProAct.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el producto";
            // 
            // cbxProAct
            // 
            this.cbxProAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxProAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxProAct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxProAct.FormattingEnabled = true;
            this.cbxProAct.Location = new System.Drawing.Point(201, 13);
            this.cbxProAct.Name = "cbxProAct";
            this.cbxProAct.Size = new System.Drawing.Size(145, 25);
            this.cbxProAct.TabIndex = 1;
            // 
            // lblNotaAct
            // 
            this.lblNotaAct.AutoSize = true;
            this.lblNotaAct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotaAct.Location = new System.Drawing.Point(12, 412);
            this.lblNotaAct.Name = "lblNotaAct";
            this.lblNotaAct.Size = new System.Drawing.Size(379, 17);
            this.lblNotaAct.TabIndex = 13;
            this.lblNotaAct.Text = "Nota: Los pedidos entregados no podran ser acualizados";
            // 
            // btnAgrProAct
            // 
            this.btnAgrProAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnAgrProAct.FlatAppearance.BorderSize = 0;
            this.btnAgrProAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgrProAct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrProAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgrProAct.Location = new System.Drawing.Point(37, 237);
            this.btnAgrProAct.Name = "btnAgrProAct";
            this.btnAgrProAct.Size = new System.Drawing.Size(180, 23);
            this.btnAgrProAct.TabIndex = 11;
            this.btnAgrProAct.Text = "¿Agregar Otros Prodcutos?";
            this.btnAgrProAct.UseVisualStyleBackColor = false;
            this.btnAgrProAct.Click += new System.EventHandler(this.btnAgrProAct_Click);
            // 
            // pnlAgreProAct
            // 
            this.pnlAgreProAct.Controls.Add(this.txtIdProductAdd);
            this.pnlAgreProAct.Controls.Add(this.label5);
            this.pnlAgreProAct.Controls.Add(this.txtCantiProActAdd);
            this.pnlAgreProAct.Controls.Add(this.btnAgrePro);
            this.pnlAgreProAct.Controls.Add(this.lblAgreNewProAct);
            this.pnlAgreProAct.Location = new System.Drawing.Point(15, 266);
            this.pnlAgreProAct.Name = "pnlAgreProAct";
            this.pnlAgreProAct.Size = new System.Drawing.Size(480, 127);
            this.pnlAgreProAct.TabIndex = 10;
            this.pnlAgreProAct.Visible = false;
            // 
            // txtIdProductAdd
            // 
            this.txtIdProductAdd.Location = new System.Drawing.Point(221, 17);
            this.txtIdProductAdd.Name = "txtIdProductAdd";
            this.txtIdProductAdd.Size = new System.Drawing.Size(100, 20);
            this.txtIdProductAdd.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seleccione la cantidad";
            // 
            // txtCantiProActAdd
            // 
            this.txtCantiProActAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.txtCantiProActAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCantiProActAdd.Location = new System.Drawing.Point(266, 54);
            this.txtCantiProActAdd.Name = "txtCantiProActAdd";
            this.txtCantiProActAdd.Size = new System.Drawing.Size(36, 20);
            this.txtCantiProActAdd.TabIndex = 3;
            // 
            // btnAgrePro
            // 
            this.btnAgrePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnAgrePro.FlatAppearance.BorderSize = 0;
            this.btnAgrePro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgrePro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrePro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgrePro.Location = new System.Drawing.Point(159, 93);
            this.btnAgrePro.Name = "btnAgrePro";
            this.btnAgrePro.Size = new System.Drawing.Size(175, 23);
            this.btnAgrePro.TabIndex = 2;
            this.btnAgrePro.Text = "Agregar Nuevo Producto";
            this.btnAgrePro.UseVisualStyleBackColor = false;
            this.btnAgrePro.Click += new System.EventHandler(this.btnAgrePro_Click);
            // 
            // lblAgreNewProAct
            // 
            this.lblAgreNewProAct.AutoSize = true;
            this.lblAgreNewProAct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreNewProAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAgreNewProAct.Location = new System.Drawing.Point(19, 17);
            this.lblAgreNewProAct.Name = "lblAgreNewProAct";
            this.lblAgreNewProAct.Size = new System.Drawing.Size(148, 17);
            this.lblAgreNewProAct.TabIndex = 0;
            this.lblAgreNewProAct.Text = "Seleccione el Producto";
            // 
            // btnSelectPedAct
            // 
            this.btnSelectPedAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnSelectPedAct.FlatAppearance.BorderSize = 0;
            this.btnSelectPedAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectPedAct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPedAct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectPedAct.Location = new System.Drawing.Point(237, 86);
            this.btnSelectPedAct.Name = "btnSelectPedAct";
            this.btnSelectPedAct.Size = new System.Drawing.Size(99, 23);
            this.btnSelectPedAct.TabIndex = 6;
            this.btnSelectPedAct.Text = "Seleccionar";
            this.btnSelectPedAct.UseVisualStyleBackColor = false;
            this.btnSelectPedAct.Click += new System.EventHandler(this.btnSelectPedAct_Click);
            // 
            // cbxPedid
            // 
            this.cbxPedid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxPedid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPedid.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPedid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cbxPedid.FormattingEnabled = true;
            this.cbxPedid.Location = new System.Drawing.Point(236, 55);
            this.cbxPedid.Name = "cbxPedid";
            this.cbxPedid.Size = new System.Drawing.Size(145, 25);
            this.cbxPedid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el pedido";
            // 
            // lblActPed
            // 
            this.lblActPed.AutoSize = true;
            this.lblActPed.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblActPed.Location = new System.Drawing.Point(170, 15);
            this.lblActPed.Name = "lblActPed";
            this.lblActPed.Size = new System.Drawing.Size(162, 23);
            this.lblActPed.TabIndex = 0;
            this.lblActPed.Text = "Actualize un Pedido";
            // 
            // tpEliminar
            // 
            this.tpEliminar.Controls.Add(this.pnlEliminar);
            this.tpEliminar.Location = new System.Drawing.Point(4, 22);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Size = new System.Drawing.Size(523, 434);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.pnlEliminar.Controls.Add(this.cbxElimPed);
            this.pnlEliminar.Controls.Add(this.lblNotaEliminar);
            this.pnlEliminar.Controls.Add(this.btnEliminarPed);
            this.pnlEliminar.Controls.Add(this.lblElimPed);
            this.pnlEliminar.Controls.Add(this.lblTEliminar);
            this.pnlEliminar.Location = new System.Drawing.Point(3, 3);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(517, 430);
            this.pnlEliminar.TabIndex = 1;
            // 
            // cbxElimPed
            // 
            this.cbxElimPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.cbxElimPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxElimPed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxElimPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbxElimPed.FormattingEnabled = true;
            this.cbxElimPed.Location = new System.Drawing.Point(285, 157);
            this.cbxElimPed.Name = "cbxElimPed";
            this.cbxElimPed.Size = new System.Drawing.Size(121, 25);
            this.cbxElimPed.TabIndex = 5;
            // 
            // lblNotaEliminar
            // 
            this.lblNotaEliminar.AutoSize = true;
            this.lblNotaEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNotaEliminar.Location = new System.Drawing.Point(12, 338);
            this.lblNotaEliminar.Name = "lblNotaEliminar";
            this.lblNotaEliminar.Size = new System.Drawing.Size(283, 32);
            this.lblNotaEliminar.TabIndex = 4;
            this.lblNotaEliminar.Text = "Nota: Los pedidos que ya fueron etregados no \r\napareceran ya que no pueden elimin" +
    "arse";
            // 
            // btnEliminarPed
            // 
            this.btnEliminarPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnEliminarPed.FlatAppearance.BorderSize = 0;
            this.btnEliminarPed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPed.Location = new System.Drawing.Point(191, 227);
            this.btnEliminarPed.Name = "btnEliminarPed";
            this.btnEliminarPed.Size = new System.Drawing.Size(125, 34);
            this.btnEliminarPed.TabIndex = 3;
            this.btnEliminarPed.Text = "Eliminar";
            this.btnEliminarPed.UseVisualStyleBackColor = false;
            this.btnEliminarPed.Click += new System.EventHandler(this.btnEliminarPed_Click);
            // 
            // lblElimPed
            // 
            this.lblElimPed.AutoSize = true;
            this.lblElimPed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElimPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblElimPed.Location = new System.Drawing.Point(32, 157);
            this.lblElimPed.Name = "lblElimPed";
            this.lblElimPed.Size = new System.Drawing.Size(183, 17);
            this.lblElimPed.TabIndex = 1;
            this.lblElimPed.Text = "Seleccione el id del pedido";
            // 
            // lblTEliminar
            // 
            this.lblTEliminar.AutoSize = true;
            this.lblTEliminar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTEliminar.Location = new System.Drawing.Point(177, 45);
            this.lblTEliminar.Name = "lblTEliminar";
            this.lblTEliminar.Size = new System.Drawing.Size(149, 23);
            this.lblTEliminar.TabIndex = 0;
            this.lblTEliminar.Text = "Elimine un Pedido";
            // 
            // tpConsultar
            // 
            this.tpConsultar.Controls.Add(this.pnlConsulta);
            this.tpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Size = new System.Drawing.Size(523, 434);
            this.tpConsultar.TabIndex = 3;
            this.tpConsultar.Text = "Consultar";
            this.tpConsultar.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.pnlConsulta.Controls.Add(this.lblTConsulta);
            this.pnlConsulta.Controls.Add(this.btnConsulPed);
            this.pnlConsulta.Controls.Add(this.txtConsulPed);
            this.pnlConsulta.Controls.Add(this.lblIdConsulta);
            this.pnlConsulta.Controls.Add(this.dgvPedido);
            this.pnlConsulta.Location = new System.Drawing.Point(6, 3);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(514, 426);
            this.pnlConsulta.TabIndex = 0;
            // 
            // lblTConsulta
            // 
            this.lblTConsulta.AutoSize = true;
            this.lblTConsulta.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTConsulta.Location = new System.Drawing.Point(179, 13);
            this.lblTConsulta.Name = "lblTConsulta";
            this.lblTConsulta.Size = new System.Drawing.Size(162, 23);
            this.lblTConsulta.TabIndex = 4;
            this.lblTConsulta.Text = "Consulte un Pedido";
            // 
            // btnConsulPed
            // 
            this.btnConsulPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            this.btnConsulPed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsulPed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulPed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulPed.Location = new System.Drawing.Point(361, 115);
            this.btnConsulPed.Name = "btnConsulPed";
            this.btnConsulPed.Size = new System.Drawing.Size(113, 23);
            this.btnConsulPed.TabIndex = 3;
            this.btnConsulPed.Text = "Buscar";
            this.btnConsulPed.UseVisualStyleBackColor = false;
            this.btnConsulPed.Click += new System.EventHandler(this.btnConsulPed_Click);
            // 
            // txtConsulPed
            // 
            this.txtConsulPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.txtConsulPed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulPed.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtConsulPed.Location = new System.Drawing.Point(225, 115);
            this.txtConsulPed.Name = "txtConsulPed";
            this.txtConsulPed.Size = new System.Drawing.Size(100, 22);
            this.txtConsulPed.TabIndex = 2;
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdConsulta.Location = new System.Drawing.Point(27, 115);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(163, 17);
            this.lblIdConsulta.TabIndex = 1;
            this.lblIdConsulta.Text = "lngrese el id del pedido ";
            // 
            // dgvPedido
            // 
            this.dgvPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            this.dgvPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(72)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedido.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dgvPedido.Location = new System.Drawing.Point(3, 187);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(151)))), ((int)(((byte)(158)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedido.RowHeadersVisible = false;
            this.dgvPedido.Size = new System.Drawing.Size(492, 71);
            this.dgvPedido.TabIndex = 0;
            // 
            // pnlConexion
            // 
            this.pnlConexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlConexion.Controls.Add(this.btnDesconectar);
            this.pnlConexion.Controls.Add(this.btnConectar);
            this.pnlConexion.Location = new System.Drawing.Point(6, 7);
            this.pnlConexion.Name = "pnlConexion";
            this.pnlConexion.Size = new System.Drawing.Size(522, 40);
            this.pnlConexion.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConectar.Image = ((System.Drawing.Image)(resources.GetObject("btnConectar.Image")));
            this.btnConectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConectar.Location = new System.Drawing.Point(21, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(119, 32);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.FlatAppearance.BorderSize = 0;
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDesconectar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesconectar.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconectar.Image")));
            this.btnDesconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesconectar.Location = new System.Drawing.Point(350, 5);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(148, 32);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 516);
            this.Controls.Add(this.pnlConexion);
            this.Controls.Add(this.tpcCrudPedido);
            this.Name = "Form1";
            this.Text = "Cliente Pizzeria";
            this.tpcCrudPedido.ResumeLayout(false);
            this.tpIngresar.ResumeLayout(false);
            this.pnlIngesarPed.ResumeLayout(false);
            this.pnlIngesarPed.PerformLayout();
            this.pnlIngresarEmp.ResumeLayout(false);
            this.pnlIngresarEmp.PerformLayout();
            this.tpActualizar.ResumeLayout(false);
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            this.pnlActPro.ResumeLayout(false);
            this.pnlActPro.PerformLayout();
            this.pnlAgreProAct.ResumeLayout(false);
            this.pnlAgreProAct.PerformLayout();
            this.tpEliminar.ResumeLayout(false);
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.tpConsultar.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.pnlConexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpcCrudPedido;
        private System.Windows.Forms.TabPage tpIngresar;
        private System.Windows.Forms.Panel pnlIngesarPed;
        private System.Windows.Forms.Panel pnlIngresarEmp;
        private System.Windows.Forms.Label lblTEmpId;
        private System.Windows.Forms.Label lblTIngrsarPed;
        private System.Windows.Forms.Label lblSucId;
        private System.Windows.Forms.TabPage tpActualizar;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.TextBox txtCantiProduct;
        private System.Windows.Forms.Label lblTCantiProduct;
        private System.Windows.Forms.ComboBox cbxProduct;
        private System.Windows.Forms.Label lblTProduct;
        private System.Windows.Forms.ComboBox cbxSucid;
        private System.Windows.Forms.ComboBox cbxEmpId;
        private System.Windows.Forms.Button btnIngreProduct;
        private System.Windows.Forms.ComboBox cbxClId;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Button btnSucEmp;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btnConsulPed;
        private System.Windows.Forms.TextBox txtConsulPed;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblTConsulta;
        private System.Windows.Forms.Panel pnlActualizar;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Label lblTEliminar;
        private System.Windows.Forms.Label lblActPed;
        private System.Windows.Forms.Button btnEliminarPed;
        private System.Windows.Forms.Label lblElimPed;
        private System.Windows.Forms.TextBox txtCantiProAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProAct;
        private System.Windows.Forms.Button btnActPed;
        private System.Windows.Forms.ComboBox cbxPedid;
        private System.Windows.Forms.Label lblNotaAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgrProAct;
        private System.Windows.Forms.Panel pnlAgreProAct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantiProActAdd;
        private System.Windows.Forms.Button btnAgrePro;
        private System.Windows.Forms.Label lblAgreNewProAct;
        private System.Windows.Forms.ComboBox cbxElimPed;
        private System.Windows.Forms.Label lblNotaEliminar;
        private System.Windows.Forms.Panel pnlActPro;
        private System.Windows.Forms.Button btnSelectPedAct;
        private System.Windows.Forms.TextBox txtIdProductAdd;
        private System.Windows.Forms.Panel pnlConexion;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
    }
}

