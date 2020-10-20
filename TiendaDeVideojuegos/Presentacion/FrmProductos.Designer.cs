namespace TiendaDeVideojuegos
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnGenero = new System.Windows.Forms.Button();
            this.BtnPlataforma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStock = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.White;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnVolver.Location = new System.Drawing.Point(443, 15);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(114, 44);
            this.BtnVolver.TabIndex = 37;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnGenero
            // 
            this.BtnGenero.BackColor = System.Drawing.Color.White;
            this.BtnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenero.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGenero.Location = new System.Drawing.Point(122, 253);
            this.BtnGenero.Name = "BtnGenero";
            this.BtnGenero.Size = new System.Drawing.Size(356, 64);
            this.BtnGenero.TabIndex = 36;
            this.BtnGenero.Text = "Agregar Genero";
            this.BtnGenero.UseVisualStyleBackColor = false;
            this.BtnGenero.Click += new System.EventHandler(this.BtnGenero_Click);
            // 
            // BtnPlataforma
            // 
            this.BtnPlataforma.BackColor = System.Drawing.Color.White;
            this.BtnPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlataforma.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlataforma.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnPlataforma.Location = new System.Drawing.Point(122, 170);
            this.BtnPlataforma.Name = "BtnPlataforma";
            this.BtnPlataforma.Size = new System.Drawing.Size(356, 64);
            this.BtnPlataforma.TabIndex = 35;
            this.BtnPlataforma.Text = "Agregar Plataforma";
            this.BtnPlataforma.UseVisualStyleBackColor = false;
            this.BtnPlataforma.Click += new System.EventHandler(this.BtnPlataforma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(167, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 65);
            this.label1.TabIndex = 33;
            this.label1.Text = "PRODUCTOS";
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.White;
            this.BtnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStock.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnStock.Location = new System.Drawing.Point(122, 419);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(356, 64);
            this.BtnStock.TabIndex = 39;
            this.BtnStock.Text = "Añadir Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.White;
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnProducto.Location = new System.Drawing.Point(122, 336);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(356, 64);
            this.BtnProducto.TabIndex = 38;
            this.BtnProducto.Text = "Registrar Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 542);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnGenero);
            this.Controls.Add(this.BtnPlataforma);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnGenero;
        private System.Windows.Forms.Button BtnPlataforma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStock;
        private System.Windows.Forms.Button BtnProducto;
    }
}