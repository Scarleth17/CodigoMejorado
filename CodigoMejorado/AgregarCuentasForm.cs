using CodigoMejorado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoMejorado
{
    //Formulario para agregar una nueva cuenta asociada a un cliente.
    public partial class AgregarCuentasForm : Form
    {
        // Proveedor de errores para validación visual en el formulario
        private readonly ErrorProvider _errorProvider = new ErrorProvider();

        // ID del cliente al cual se le asociará la cuenta
        private readonly int _clienteId;

        // Propiedad pública que contendrá la cuenta creada si se valida correctamente
        public Cuenta NuevaCuenta { get; private set; }

        // Constructor del formulario, recibe el ID del cliente como parámetro
        public AgregarCuentasForm(int clienteId)
        {
            InitializeComponent(); // Inicializa los controles del formulario

            _clienteId = clienteId; // Asigna el ID del cliente
            _errorProvider.ContainerControl = this; // Configura el ErrorProvider para este formulario

        
        }

        // Valida los campos requeridos del formulario.
        private bool ValidarCampos()
        {
            bool esValido = true;
            _errorProvider.Clear();

            var numero = txtNumCuenta.Text?.Trim();
            if (string.IsNullOrEmpty(numero))
            {
                _errorProvider.SetError(txtNumCuenta, "El número de cuenta es obligatorio.");
                esValido = false;
            }

            return esValido;
        }

        // Crea una instancia de cuenta con los valores del formulario.
        private void CrearCuenta()
        {
            NuevaCuenta = new Cuenta
            {
                NumeroCuenta = txtNumCuenta.Text.Trim(),
                Saldo = numSaldoInicial.Value,
                ClienteId = _clienteId,
                Activa = true
            };
        }

        // Evento clic en Aceptar: valida y crea la cuenta.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            CrearCuenta();

            DialogResult = DialogResult.OK;
            Close();
        }


        //Cancela la operación.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
