namespace CodigoMejorado
{
    partial class TransferenciaForm
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
            lblCuentaOrigen = new Label();
            lblMonto = new Label();
            lblCuentaDestino = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            numMonto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numMonto).BeginInit();
            SuspendLayout();
            // 
            // lblCuentaOrigen
            // 
            lblCuentaOrigen.AutoSize = true;
            lblCuentaOrigen.Location = new Point(45, 73);
            lblCuentaOrigen.Name = "lblCuentaOrigen";
            lblCuentaOrigen.Size = new Size(130, 25);
            lblCuentaOrigen.TabIndex = 0;
            lblCuentaOrigen.Text = "Cuenta Origen:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(48, 158);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(70, 25);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto:";
            // 
            // lblCuentaDestino
            // 
            lblCuentaDestino.AutoSize = true;
            lblCuentaDestino.Location = new Point(50, 235);
            lblCuentaDestino.Name = "lblCuentaDestino";
            lblCuentaDestino.Size = new Size(137, 25);
            lblCuentaDestino.TabIndex = 2;
            lblCuentaDestino.Text = "Cuenta Destino:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(142, 295);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += Aceptar;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(371, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += Cancelar;
            // 
            // numMonto
            // 
            numMonto.Location = new Point(226, 169);
            numMonto.Name = "numMonto";
            numMonto.Size = new Size(180, 31);
            numMonto.TabIndex = 5;
            // 
            // TransferenciaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numMonto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblCuentaDestino);
            Controls.Add(lblMonto);
            Controls.Add(lblCuentaOrigen);
            Name = "TransferenciaForm";
            Text = "TransferenciaForm";
            ((System.ComponentModel.ISupportInitialize)numMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuentaOrigen;
        private Label lblMonto;
        private Label lblCuentaDestino;
        private Button btnAceptar;
        private Button btnCancelar;
        private NumericUpDown numMonto;
    }
}