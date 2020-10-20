namespace TiendaDeVideojuegos.Presentacion
{
    partial class FrmBoleta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoleta));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRUCProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbProveedor = new System.Windows.Forms.GroupBox();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNuevoProveedor = new System.Windows.Forms.Button();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GbEmpleado = new System.Windows.Forms.GroupBox();
            this.TxtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.GbProducto = new System.Windows.Forms.GroupBox();
            this.BtnSUBTOTAL = new System.Windows.Forms.Button();
            this.TxtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtImporteCompra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCantidadCompra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCantidadProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnNuevoProducto = new System.Windows.Forms.Button();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtIGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtnLimpiarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GbProveedor.SuspendLayout();
            this.GbEmpleado.SuspendLayout();
            this.GbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleBoleta)).BeginInit();
            this.GbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.White;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnVolver.Location = new System.Drawing.Point(983, 12);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(114, 44);
            this.BtnVolver.TabIndex = 56;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(176, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 86);
            this.label1.TabIndex = 50;
            this.label1.Text = "BOLETA";
            // 
            // TxtRUCProveedor
            // 
            this.TxtRUCProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRUCProveedor.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRUCProveedor.Location = new System.Drawing.Point(114, 38);
            this.TxtRUCProveedor.MaxLength = 10;
            this.TxtRUCProveedor.Name = "TxtRUCProveedor";
            this.TxtRUCProveedor.Size = new System.Drawing.Size(308, 29);
            this.TxtRUCProveedor.TabIndex = 49;
            this.TxtRUCProveedor.TextChanged += new System.EventHandler(this.TxtRUCProveedor_TextChanged);
            this.TxtRUCProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUCProveedor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(48, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "RUC:";
            // 
            // GbProveedor
            // 
            this.GbProveedor.Controls.Add(this.TxtNombreProveedor);
            this.GbProveedor.Controls.Add(this.label3);
            this.GbProveedor.Controls.Add(this.BtnNuevoProveedor);
            this.GbProveedor.Controls.Add(this.TxtRUCProveedor);
            this.GbProveedor.Controls.Add(this.label2);
            this.GbProveedor.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbProveedor.Location = new System.Drawing.Point(46, 144);
            this.GbProveedor.Name = "GbProveedor";
            this.GbProveedor.Size = new System.Drawing.Size(1027, 97);
            this.GbProveedor.TabIndex = 62;
            this.GbProveedor.TabStop = false;
            this.GbProveedor.Text = "PROVEEDOR";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.Location = new System.Drawing.Point(676, 37);
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(301, 29);
            this.TxtNombreProveedor.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(561, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 66;
            this.label3.Text = "NOMBRE:";
            // 
            // BtnNuevoProveedor
            // 
            this.BtnNuevoProveedor.BackColor = System.Drawing.Color.Silver;
            this.BtnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoProveedor.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProveedor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoProveedor.Location = new System.Drawing.Point(442, 38);
            this.BtnNuevoProveedor.Name = "BtnNuevoProveedor";
            this.BtnNuevoProveedor.Size = new System.Drawing.Size(36, 29);
            this.BtnNuevoProveedor.TabIndex = 63;
            this.BtnNuevoProveedor.UseVisualStyleBackColor = false;
            this.BtnNuevoProveedor.Click += new System.EventHandler(this.BtnNuevoProveedor_Click);
            // 
            // TxtNumero
            // 
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumero.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(722, 91);
            this.TxtNumero.MaxLength = 5;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(233, 29);
            this.TxtNumero.TabIndex = 69;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(605, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 68;
            this.label4.Text = "NUMERO:";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSerie.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerie.Location = new System.Drawing.Point(720, 44);
            this.TxtSerie.MaxLength = 10;
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(235, 29);
            this.TxtSerie.TabIndex = 65;
            this.TxtSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSerie_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(641, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 30);
            this.label6.TabIndex = 64;
            this.label6.Text = "SERIE:";
            // 
            // GbEmpleado
            // 
            this.GbEmpleado.Controls.Add(this.TxtCodigoEmpleado);
            this.GbEmpleado.Controls.Add(this.label18);
            this.GbEmpleado.Controls.Add(this.TxtNombreEmpleado);
            this.GbEmpleado.Controls.Add(this.label9);
            this.GbEmpleado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbEmpleado.Location = new System.Drawing.Point(47, 240);
            this.GbEmpleado.Name = "GbEmpleado";
            this.GbEmpleado.Size = new System.Drawing.Size(636, 108);
            this.GbEmpleado.TabIndex = 70;
            this.GbEmpleado.TabStop = false;
            this.GbEmpleado.Text = "EMPLEADO";
            // 
            // TxtCodigoEmpleado
            // 
            this.TxtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoEmpleado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoEmpleado.Location = new System.Drawing.Point(90, 42);
            this.TxtCodigoEmpleado.MaxLength = 8;
            this.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado";
            this.TxtCodigoEmpleado.Size = new System.Drawing.Size(156, 29);
            this.TxtCodigoEmpleado.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(26, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 30);
            this.label18.TabIndex = 50;
            this.label18.Text = "DNI:";
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreEmpleado.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(396, 42);
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(213, 29);
            this.TxtNombreEmpleado.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(281, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 30);
            this.label9.TabIndex = 48;
            this.label9.Text = "NOMBRE:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DtpFecha.Location = new System.Drawing.Point(192, 114);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(304, 29);
            this.DtpFecha.TabIndex = 71;
            // 
            // GbProducto
            // 
            this.GbProducto.Controls.Add(this.BtnSUBTOTAL);
            this.GbProducto.Controls.Add(this.TxtPrecioProducto);
            this.GbProducto.Controls.Add(this.label12);
            this.GbProducto.Controls.Add(this.TxtImporteCompra);
            this.GbProducto.Controls.Add(this.label11);
            this.GbProducto.Controls.Add(this.TxtCantidadCompra);
            this.GbProducto.Controls.Add(this.label10);
            this.GbProducto.Controls.Add(this.TxtCantidadProducto);
            this.GbProducto.Controls.Add(this.TxtNombreProducto);
            this.GbProducto.Controls.Add(this.label8);
            this.GbProducto.Controls.Add(this.label7);
            this.GbProducto.Controls.Add(this.BtnNuevoProducto);
            this.GbProducto.Controls.Add(this.TxtCodigoProducto);
            this.GbProducto.Controls.Add(this.label5);
            this.GbProducto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbProducto.Location = new System.Drawing.Point(47, 348);
            this.GbProducto.Name = "GbProducto";
            this.GbProducto.Size = new System.Drawing.Size(1026, 140);
            this.GbProducto.TabIndex = 71;
            this.GbProducto.TabStop = false;
            this.GbProducto.Text = "PRODUCTO";
            // 
            // BtnSUBTOTAL
            // 
            this.BtnSUBTOTAL.BackColor = System.Drawing.Color.Silver;
            this.BtnSUBTOTAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSUBTOTAL.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSUBTOTAL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSUBTOTAL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSUBTOTAL.Location = new System.Drawing.Point(716, 88);
            this.BtnSUBTOTAL.Name = "BtnSUBTOTAL";
            this.BtnSUBTOTAL.Size = new System.Drawing.Size(36, 29);
            this.BtnSUBTOTAL.TabIndex = 76;
            this.BtnSUBTOTAL.UseVisualStyleBackColor = false;
            this.BtnSUBTOTAL.Click += new System.EventHandler(this.BtnSUBTOTAL_Click);
            // 
            // TxtPrecioProducto
            // 
            this.TxtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecioProducto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioProducto.Location = new System.Drawing.Point(902, 41);
            this.TxtPrecioProducto.Name = "TxtPrecioProducto";
            this.TxtPrecioProducto.Size = new System.Drawing.Size(90, 29);
            this.TxtPrecioProducto.TabIndex = 75;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(699, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 30);
            this.label12.TabIndex = 74;
            this.label12.Text = "PRECIO UNITARIO:";
            // 
            // TxtImporteCompra
            // 
            this.TxtImporteCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImporteCompra.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporteCompra.Location = new System.Drawing.Point(904, 88);
            this.TxtImporteCompra.Name = "TxtImporteCompra";
            this.TxtImporteCompra.Size = new System.Drawing.Size(90, 29);
            this.TxtImporteCompra.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(792, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 30);
            this.label11.TabIndex = 72;
            this.label11.Text = "IMPORTE:";
            // 
            // TxtCantidadCompra
            // 
            this.TxtCantidadCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidadCompra.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadCompra.Location = new System.Drawing.Point(656, 88);
            this.TxtCantidadCompra.MaxLength = 3;
            this.TxtCantidadCompra.Name = "TxtCantidadCompra";
            this.TxtCantidadCompra.Size = new System.Drawing.Size(54, 29);
            this.TxtCantidadCompra.TabIndex = 71;
            this.TxtCantidadCompra.TextChanged += new System.EventHandler(this.TxtCantidadCompra_TextChanged);
            this.TxtCantidadCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadCompra_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(423, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 30);
            this.label10.TabIndex = 70;
            this.label10.Text = "CANTIDAD COMPRA:";
            // 
            // TxtCantidadProducto
            // 
            this.TxtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantidadProducto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadProducto.Location = new System.Drawing.Point(585, 42);
            this.TxtCantidadProducto.Name = "TxtCantidadProducto";
            this.TxtCantidadProducto.Size = new System.Drawing.Size(71, 29);
            this.TxtCantidadProducto.TabIndex = 69;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreProducto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProducto.Location = new System.Drawing.Point(144, 88);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(214, 29);
            this.TxtNombreProducto.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(454, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 30);
            this.label8.TabIndex = 68;
            this.label8.Text = "CANTIDAD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(31, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "NOMBRE:";
            // 
            // BtnNuevoProducto
            // 
            this.BtnNuevoProducto.BackColor = System.Drawing.Color.Silver;
            this.BtnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevoProducto.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoProducto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNuevoProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevoProducto.Location = new System.Drawing.Point(370, 43);
            this.BtnNuevoProducto.Name = "BtnNuevoProducto";
            this.BtnNuevoProducto.Size = new System.Drawing.Size(36, 29);
            this.BtnNuevoProducto.TabIndex = 65;
            this.BtnNuevoProducto.UseVisualStyleBackColor = false;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(141, 43);
            this.TxtCodigoProducto.MaxLength = 10;
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(217, 29);
            this.TxtCodigoProducto.TabIndex = 64;
            this.TxtCodigoProducto.TextChanged += new System.EventHandler(this.TxtCodigoProducto_TextChanged);
            this.TxtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoProducto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(34, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "CODIGO:";
            // 
            // DgvDetalleBoleta
            // 
            this.DgvDetalleBoleta.AllowUserToAddRows = false;
            this.DgvDetalleBoleta.AllowUserToDeleteRows = false;
            this.DgvDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleBoleta.Location = new System.Drawing.Point(47, 502);
            this.DgvDetalleBoleta.Name = "DgvDetalleBoleta";
            this.DgvDetalleBoleta.ReadOnly = true;
            this.DgvDetalleBoleta.Size = new System.Drawing.Size(656, 206);
            this.DgvDetalleBoleta.TabIndex = 72;
            this.DgvDetalleBoleta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleBoleta_CellDoubleClick);
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(922, 572);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(120, 29);
            this.TxtTotalPagar.TabIndex = 81;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Brown;
            this.label15.Location = new System.Drawing.Point(725, 572);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 30);
            this.label15.TabIndex = 80;
            this.label15.Text = "TOTAL A PAGAR:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnAgregar.Location = new System.Drawing.Point(793, 616);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(117, 40);
            this.BtnAgregar.TabIndex = 82;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNuevo.Location = new System.Drawing.Point(916, 616);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(117, 40);
            this.BtnNuevo.TabIndex = 83;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGuardar.Location = new System.Drawing.Point(793, 662);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(117, 40);
            this.BtnGuardar.TabIndex = 84;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.White;
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnQuitar.Location = new System.Drawing.Point(916, 662);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(117, 40);
            this.BtnQuitar.TabIndex = 87;
            this.BtnQuitar.Text = "Quitar";
            this.BtnQuitar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(191, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(233, 30);
            this.label16.TabIndex = 50;
            this.label16.Text = "ANTHONY BELIZARIO";
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TxtNombreCliente);
            this.GbCliente.Controls.Add(this.label13);
            this.GbCliente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbCliente.Location = new System.Drawing.Point(703, 240);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(370, 108);
            this.GbCliente.TabIndex = 71;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "CLIENTE";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(143, 41);
            this.TxtNombreCliente.MaxLength = 20;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(195, 29);
            this.TxtNombreCliente.TabIndex = 49;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreCliente_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(28, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 30);
            this.label13.TabIndex = 48;
            this.label13.Text = "NOMBRE:";
            // 
            // TxtIGV
            // 
            this.TxtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtIGV.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIGV.Location = new System.Drawing.Point(922, 537);
            this.TxtIGV.Name = "TxtIGV";
            this.TxtIGV.Size = new System.Drawing.Size(120, 29);
            this.TxtIGV.TabIndex = 89;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Brown;
            this.label14.Location = new System.Drawing.Point(856, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 30);
            this.label14.TabIndex = 88;
            this.label14.Text = "IGV:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSubTotal.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTotal.Location = new System.Drawing.Point(922, 502);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(120, 29);
            this.TxtSubTotal.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Brown;
            this.label17.Location = new System.Drawing.Point(779, 500);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 30);
            this.label17.TabIndex = 90;
            this.label17.Text = "SUB TOTAL:";
            // 
            // BtnLimpiarCompra
            // 
            this.BtnLimpiarCompra.BackColor = System.Drawing.Color.Silver;
            this.BtnLimpiarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCompra.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarCompra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnLimpiarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLimpiarCompra.Location = new System.Drawing.Point(1048, 502);
            this.BtnLimpiarCompra.Name = "BtnLimpiarCompra";
            this.BtnLimpiarCompra.Size = new System.Drawing.Size(25, 100);
            this.BtnLimpiarCompra.TabIndex = 77;
            this.BtnLimpiarCompra.UseVisualStyleBackColor = false;
            this.BtnLimpiarCompra.Click += new System.EventHandler(this.BtnLimpiarCompra_Click);
            // 
            // FrmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1113, 726);
            this.Controls.Add(this.BtnLimpiarCompra);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtIGV);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GbCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.TxtSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DgvDetalleBoleta);
            this.Controls.Add(this.GbProducto);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.GbEmpleado);
            this.Controls.Add(this.GbProveedor);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBoleta";
            this.Text = "FrmVentaBoleta";
            this.Load += new System.EventHandler(this.FrmBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GbProveedor.ResumeLayout(false);
            this.GbProveedor.PerformLayout();
            this.GbEmpleado.ResumeLayout(false);
            this.GbEmpleado.PerformLayout();
            this.GbProducto.ResumeLayout(false);
            this.GbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleBoleta)).EndInit();
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRUCProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbProveedor;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GbEmpleado;
        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.GroupBox GbProducto;
        private System.Windows.Forms.TextBox TxtPrecioProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtImporteCompra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCantidadCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCantidadProducto;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnNuevoProducto;
        private System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvDetalleBoleta;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnNuevoProveedor;
        private System.Windows.Forms.TextBox TxtIGV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtCodigoEmpleado;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnSUBTOTAL;
        private System.Windows.Forms.Button BtnLimpiarCompra;
    }
}