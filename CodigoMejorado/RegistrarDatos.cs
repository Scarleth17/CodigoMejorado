using CodigoMejorado.Data;
using CodigoMejorado.Models;
using CodigoMejorado.Service;
using System.Windows.Forms;

namespace CodigoMejorado
{
    public partial class RegistrarDatos : Form
    {
        private BancoSimpleContext _db = new BancoSimpleContext();
        private ServiceCuenta Sc;

        public RegistrarDatos()
        {
            InitializeComponent();
            Sc = new ServiceCuenta(_db);
            CargarDatos();


        }

        private void CargarDatos()
        {
            dgvClientes.DataSource = Sc.ObtenerClientesConCuentas();
            dgvCuentas.DataSource = Sc.ObtenerCuentasActivas();
        }



        private void AgregarCliente(object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Sc.AgregarCliente(form.NuevoCliente);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar cliente: {ex.Message}");
                }
            }
        }

        private void AgregarCuenta(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero.");
                return;
            }

            int clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new AgregarCuentasForm(clienteId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Sc.AgregarCuenta(form.NuevaCuenta);
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar cuenta: {ex.Message}");
                }
            }

        }

        private void DesactivarCuenta(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta para desactivar.");
                return;
            }

            int cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;

            try
            {
                Sc.DesactivarCuenta(cuentaId);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desactivar cuenta: {ex.Message}");
            }

        }

        private void Trasnferir(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas.");
                return;
            }

            int cuentaOrigenId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            int cuentaDestinoId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;

            var form = new TransferenciaForm(Sc, cuentaOrigenId, cuentaDestinoId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Sc.RealizarTransferencia(cuentaOrigenId, cuentaDestinoId, form.Monto);
                    MessageBox.Show("Transferencia realizada con éxito.");
                    CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en la transferencia: {ex.Message}");

                }
            }
        }



        private void VerTransferencias(object sender, EventArgs e)
        {
            var form = new Transacciones();
            form.ShowDialog();
        }

        private void RegistrarDatos_Load(object sender, EventArgs e)
        {

        }

        private void Buscar(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscar.Text.Trim();

            using (var context = new BancoSimpleContext())
            {
                var resultados = context.Clientes
                                        .Where(p => p.Nombre.Contains(nombreBuscado))
                .ToList();

                dgvClientes.DataSource = resultados;

            } 
            
            
            
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            dgvCuentas.DataSource = null;
            dgvCuentas.Rows.Clear();
        }
    }

}

