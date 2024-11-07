namespace U6_WindowsForms
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ListaTab = new System.Windows.Forms.TabPage();
            this.IngresoTab = new System.Windows.Forms.TabPage();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.NombreLibro = new System.Windows.Forms.Label();
            this.AutorLibro = new System.Windows.Forms.Label();
            this.PaginasLibro = new System.Windows.Forms.Label();
            this.PrecioLibro = new System.Windows.Forms.Label();
            this.ImportadoLibro = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.MenuGenero = new System.Windows.Forms.ComboBox();
            this.CheckImportado = new System.Windows.Forms.CheckBox();
            this.GeneroLibro = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtPaginas = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.ListaTab.SuspendLayout();
            this.IngresoTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ListaTab
            // 
            this.ListaTab.Controls.Add(this.listBoxLibros);
            this.ListaTab.Location = new System.Drawing.Point(4, 22);
            this.ListaTab.Name = "ListaTab";
            this.ListaTab.Padding = new System.Windows.Forms.Padding(3);
            this.ListaTab.Size = new System.Drawing.Size(492, 395);
            this.ListaTab.TabIndex = 1;
            this.ListaTab.Text = "Listado";
            this.ListaTab.UseVisualStyleBackColor = true;
            // 
            // IngresoTab
            // 
            this.IngresoTab.AccessibleName = "Ingreso";
            this.IngresoTab.Controls.Add(this.TxtAutor);
            this.IngresoTab.Controls.Add(this.TxtPaginas);
            this.IngresoTab.Controls.Add(this.TxtPrecio);
            this.IngresoTab.Controls.Add(this.TxtNombre);
            this.IngresoTab.Controls.Add(this.GeneroLibro);
            this.IngresoTab.Controls.Add(this.CheckImportado);
            this.IngresoTab.Controls.Add(this.MenuGenero);
            this.IngresoTab.Controls.Add(this.ImportadoLibro);
            this.IngresoTab.Controls.Add(this.PrecioLibro);
            this.IngresoTab.Controls.Add(this.PaginasLibro);
            this.IngresoTab.Controls.Add(this.AutorLibro);
            this.IngresoTab.Controls.Add(this.NombreLibro);
            this.IngresoTab.Controls.Add(this.BtnIngresar);
            this.IngresoTab.Controls.Add(this.BtnCancelar);
            this.IngresoTab.Location = new System.Drawing.Point(4, 22);
            this.IngresoTab.Name = "IngresoTab";
            this.IngresoTab.Padding = new System.Windows.Forms.Padding(3);
            this.IngresoTab.Size = new System.Drawing.Size(492, 395);
            this.IngresoTab.TabIndex = 0;
            this.IngresoTab.Text = "Ingreso";
            this.IngresoTab.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelar.Location = new System.Drawing.Point(75, 276);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 39);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(257, 276);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(91, 39);
            this.BtnIngresar.TabIndex = 2;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // NombreLibro
            // 
            this.NombreLibro.AutoSize = true;
            this.NombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.NombreLibro.Location = new System.Drawing.Point(36, 67);
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.Size = new System.Drawing.Size(56, 16);
            this.NombreLibro.TabIndex = 4;
            this.NombreLibro.Text = "Nombre";
            this.NombreLibro.Click += new System.EventHandler(this.label2_Click);
            // 
            // AutorLibro
            // 
            this.AutorLibro.AutoSize = true;
            this.AutorLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorLibro.Location = new System.Drawing.Point(40, 97);
            this.AutorLibro.Name = "AutorLibro";
            this.AutorLibro.Size = new System.Drawing.Size(38, 16);
            this.AutorLibro.TabIndex = 5;
            this.AutorLibro.Text = "Autor";
            this.AutorLibro.Click += new System.EventHandler(this.label3_Click);
            // 
            // PaginasLibro
            // 
            this.PaginasLibro.AutoSize = true;
            this.PaginasLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaginasLibro.Location = new System.Drawing.Point(40, 162);
            this.PaginasLibro.Name = "PaginasLibro";
            this.PaginasLibro.Size = new System.Drawing.Size(57, 16);
            this.PaginasLibro.TabIndex = 7;
            this.PaginasLibro.Text = "Páginas";
            this.PaginasLibro.Click += new System.EventHandler(this.label5_Click);
            // 
            // PrecioLibro
            // 
            this.PrecioLibro.AutoSize = true;
            this.PrecioLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLibro.Location = new System.Drawing.Point(40, 230);
            this.PrecioLibro.Name = "PrecioLibro";
            this.PrecioLibro.Size = new System.Drawing.Size(46, 16);
            this.PrecioLibro.TabIndex = 9;
            this.PrecioLibro.Text = "Precio";
            // 
            // ImportadoLibro
            // 
            this.ImportadoLibro.AutoSize = true;
            this.ImportadoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportadoLibro.Location = new System.Drawing.Point(38, 195);
            this.ImportadoLibro.Name = "ImportadoLibro";
            this.ImportadoLibro.Size = new System.Drawing.Size(68, 16);
            this.ImportadoLibro.TabIndex = 19;
            this.ImportadoLibro.Text = "Importado";
            this.ImportadoLibro.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(116, 63);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(143, 20);
            this.TxtNombre.TabIndex = 20;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // MenuGenero
            // 
            this.MenuGenero.FormattingEnabled = true;
            this.MenuGenero.Items.AddRange(new object[] {
            "Romántica.",
            "Ciencia ficción.",
            "Distopía.",
            "Aventuras.",
            "Fantasía."});
            this.MenuGenero.Location = new System.Drawing.Point(116, 124);
            this.MenuGenero.Name = "MenuGenero";
            this.MenuGenero.Size = new System.Drawing.Size(143, 21);
            this.MenuGenero.TabIndex = 21;
            this.MenuGenero.SelectedIndexChanged += new System.EventHandler(this.MenuGenero_SelectedIndexChanged);
            // 
            // CheckImportado
            // 
            this.CheckImportado.AutoSize = true;
            this.CheckImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckImportado.Location = new System.Drawing.Point(120, 192);
            this.CheckImportado.Name = "CheckImportado";
            this.CheckImportado.Size = new System.Drawing.Size(37, 19);
            this.CheckImportado.TabIndex = 22;
            this.CheckImportado.Text = "Si";
            this.CheckImportado.UseVisualStyleBackColor = true;
            this.CheckImportado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // GeneroLibro
            // 
            this.GeneroLibro.AutoSize = true;
            this.GeneroLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroLibro.Location = new System.Drawing.Point(40, 129);
            this.GeneroLibro.Name = "GeneroLibro";
            this.GeneroLibro.Size = new System.Drawing.Size(52, 16);
            this.GeneroLibro.TabIndex = 18;
            this.GeneroLibro.Text = "Genero";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(116, 226);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(41, 20);
            this.TxtPrecio.TabIndex = 23;
            // 
            // TxtPaginas
            // 
            this.TxtPaginas.Location = new System.Drawing.Point(120, 158);
            this.TxtPaginas.Name = "TxtPaginas";
            this.TxtPaginas.Size = new System.Drawing.Size(41, 20);
            this.TxtPaginas.TabIndex = 24;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(116, 93);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(143, 20);
            this.TxtAutor.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IngresoTab);
            this.tabControl1.Controls.Add(this.ListaTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 421);
            this.tabControl1.TabIndex = 17;
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.AccessibleName = "listBoxLibros";
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.Location = new System.Drawing.Point(0, 0);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(471, 368);
            this.listBoxLibros.TabIndex = 0;
            this.listBoxLibros.Tag = "listBoxLibros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 417);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ListaTab.ResumeLayout(false);
            this.IngresoTab.ResumeLayout(false);
            this.IngresoTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage ListaTab;
        private System.Windows.Forms.TabPage IngresoTab;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtPaginas;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label GeneroLibro;
        private System.Windows.Forms.CheckBox CheckImportado;
        private System.Windows.Forms.ComboBox MenuGenero;
        private System.Windows.Forms.Label ImportadoLibro;
        private System.Windows.Forms.Label PrecioLibro;
        private System.Windows.Forms.Label PaginasLibro;
        private System.Windows.Forms.Label AutorLibro;
        private System.Windows.Forms.Label NombreLibro;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox listBoxLibros;
    }
}

