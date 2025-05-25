namespace CodigoMejorado
{
    partial class AgregarClienteForm
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
            txtNombre = new TextBox();
            txtIdentificacion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            label2.Location = new Point(59, 108);
            label2.Name = "label2";
            label2.Size = new Size(158, 24);
            label2.TabIndex = 1;
            label2.Text = "Identificacion:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            txtNombre.Location = new Point(240, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 32);
            txtNombre.TabIndex = 2;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            txtIdentificacion.Location = new Point(240, 100);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(215, 32);
            txtIdentificacion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnAceptar.Location = new Point(78, 192);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(278, 192);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // AgregarClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarClienteForm";
            Text = "AgregarClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtIdentificacion;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}