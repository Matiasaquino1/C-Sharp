
namespace WinFormsApp1
{
    partial class FormAgregarModificar
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDni = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSalario = new TextBox();
            txtEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chkCasado = new CheckBox();
            chkCasadoNo = new CheckBox();
            txtDNI = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(255, 313);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(93, 313);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(89, 36);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(40, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(127, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(176, 23);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtChangedNombre;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDni.Location = new Point(127, 145);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(40, 19);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 218);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 5;
            label3.Text = "Casado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 252);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 6;
            label4.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(177, 252);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(172, 23);
            txtSalario.TabIndex = 8;
            txtSalario.TextChanged += txtchangeSalario;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(173, 178);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(176, 23);
            txtEdad.TabIndex = 9;
            txtEdad.TextChanged += txtchangedEdad;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 192);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.MinimumSize = new Size(20, 0);
            label1.Name = "label1";
            label1.Size = new Size(256, 43);
            label1.TabIndex = 11;
            label1.Text = "Agregar Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 182);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 12;
            label2.Text = "Edad:";
            // 
            // chkCasado
            // 
            chkCasado.AutoSize = true;
            chkCasado.Location = new Point(173, 219);
            chkCasado.Name = "chkCasado";
            chkCasado.Size = new Size(35, 19);
            chkCasado.TabIndex = 14;
            chkCasado.Text = "SI";
            chkCasado.UseVisualStyleBackColor = true;
            chkCasado.CheckedChanged += chkhangeSi;
            // 
            // chkCasadoNo
            // 
            chkCasadoNo.AutoSize = true;
            chkCasadoNo.Location = new Point(214, 218);
            chkCasadoNo.Name = "chkCasadoNo";
            chkCasadoNo.Size = new Size(42, 19);
            chkCasadoNo.TabIndex = 15;
            chkCasadoNo.Text = "No";
            chkCasadoNo.UseVisualStyleBackColor = true;
            chkCasadoNo.CheckedChanged += chkchangeNo;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(173, 145);
            txtDNI.MaxLength = 20;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(176, 23);
            txtDNI.TabIndex = 13;
            txtDNI.TextChanged += txtchangedDNI;
            // 
            // FormAgregarModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 450);
            Controls.Add(chkCasadoNo);
            Controls.Add(chkCasado);
            Controls.Add(txtDNI);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(txtSalario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblDni);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "FormAgregarModificar";
            Text = "AgregarModificar";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDni;
        private Label label3;
        private Label label4;
        private TextBox txtSalario;
        private TextBox txtEdad;
        private Label label1;
        private Label label2;
        private CheckBox chkCasado;
        private CheckBox chkCasadoNo;
        private TextBox txtDNI;
    }
}