namespace CodigoMejorado
{
    partial class RegistrarDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClientes = new DataGridView();
            dgvCuentas = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            btnLimpiarCampos = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            btnVerTransferencias = new Button();
            btnDesactivarCuenta = new Button();
            btnTransferir = new Button();
            btnAgregarCuenta = new Button();
            btnAgregarCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(648, 39);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.Size = new Size(467, 225);
            dgvClientes.TabIndex = 1;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(643, 286);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 62;
            dgvCuentas.Size = new Size(472, 225);
            dgvCuentas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 23);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 3;
            label1.Text = "Entidad Financiera";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnLimpiarCampos);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnVerTransferencias);
            groupBox1.Controls.Add(btnDesactivarCuenta);
            groupBox1.Controls.Add(btnTransferir);
            groupBox1.Controls.Add(btnAgregarCuenta);
            groupBox1.Controls.Add(btnAgregarCliente);
            groupBox1.Location = new Point(54, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 406);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "AgregarDatos";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(275, 154);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += Buscar;
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(275, 293);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(112, 34);
            btnLimpiarCampos.TabIndex = 8;
            btnLimpiarCampos.Text = "Limpiar Campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += LimpiarCampos;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(243, 97);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(205, 31);
            txtBuscar.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 58);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 6;
            label2.Text = "Buscar:";
            // 
            // btnVerTransferencias
            // 
            btnVerTransferencias.Location = new Point(27, 347);
            btnVerTransferencias.Name = "btnVerTransferencias";
            btnVerTransferencias.Size = new Size(178, 34);
            btnVerTransferencias.TabIndex = 5;
            btnVerTransferencias.Text = "Ver Transferencias";
            btnVerTransferencias.UseVisualStyleBackColor = true;
            btnVerTransferencias.Click += VerTransferencias;
            // 
            // btnDesactivarCuenta
            // 
            btnDesactivarCuenta.Location = new Point(29, 281);
            btnDesactivarCuenta.Name = "btnDesactivarCuenta";
            btnDesactivarCuenta.Size = new Size(176, 34);
            btnDesactivarCuenta.TabIndex = 4;
            btnDesactivarCuenta.Text = "Desactivar Cuenta";
            btnDesactivarCuenta.UseVisualStyleBackColor = true;
            btnDesactivarCuenta.Click += DesactivarCuenta;
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(29, 213);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(176, 34);
            btnTransferir.TabIndex = 3;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            btnTransferir.Click += Trasnferir;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Location = new Point(29, 131);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(176, 34);
            btnAgregarCuenta.TabIndex = 2;
            btnAgregarCuenta.Text = "Agregar Cuenta";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += AgregarCuenta;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(29, 51);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(176, 34);
            btnAgregarCliente.TabIndex = 0;
            btnAgregarCliente.Text = "Agregar Cliente";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += AgregarCliente;
            // 
            // RegistrarDatos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1181, 534);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dgvCuentas);
            Controls.Add(dgvClientes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegistrarDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegistrarDatos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvClientes;
        private DataGridView dgvCuentas;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnDesactivarCuenta;
        private Button btnTransferir;
        private Button btnAgregarCuenta;
        private Button btnAgregarCliente;
        private Button btnVerTransferencias;
        private Button btnLimpiarCampos;
        private TextBox txtBuscar;
        private Label label2;
        private Button btnBuscar;
    }
}
