namespace CodigoMejorado
{
    partial class Transacciones
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
            dgvTransacciones = new DataGridView();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).BeginInit();
            SuspendLayout();
            // 
            // dgvTransacciones
            // 
            dgvTransacciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacciones.Location = new Point(62, 54);
            dgvTransacciones.Name = "dgvTransacciones";
            dgvTransacciones.RowHeadersWidth = 62;
            dgvTransacciones.Size = new Size(486, 225);
            dgvTransacciones.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(634, 184);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Transacciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(dgvTransacciones);
            Name = "Transacciones";
            Text = "Transacciones";
            ((System.ComponentModel.ISupportInitialize)dgvTransacciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTransacciones;
        private Button btnEliminar;
    }
}