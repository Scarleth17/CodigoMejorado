namespace CodigoMejorado
{
    partial class AgregarCuentasForm
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
            label1 = new Label();
            label2 = new Label();
            txtNumCuenta = new TextBox();
            numSaldoInicial = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label1.Location = new Point(87, 67);
            label1.Name = "label1";
            label1.Size = new Size(207, 24);
            label1.TabIndex = 0;
            label1.Text = "Numero De Cuenta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label2.Location = new Point(99, 156);
            label2.Name = "label2";
            label2.Size = new Size(73, 24);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // txtNumCuenta
            // 
            txtNumCuenta.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            txtNumCuenta.Location = new Point(321, 67);
            txtNumCuenta.Name = "txtNumCuenta";
            txtNumCuenta.Size = new Size(180, 32);
            txtNumCuenta.TabIndex = 2;
            // 
            // numSaldoInicial
            // 
            numSaldoInicial.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            numSaldoInicial.Location = new Point(321, 150);
            numSaldoInicial.Name = "numSaldoInicial";
            numSaldoInicial.Size = new Size(180, 32);
            numSaldoInicial.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(147, 268);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(364, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AgregarCuentasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(numSaldoInicial);
            Controls.Add(txtNumCuenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarCuentasForm";
            Text = "AgregarCuentasForm";
           
            ((System.ComponentModel.ISupportInitialize)numSaldoInicial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumCuenta;
        private NumericUpDown numSaldoInicial;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}