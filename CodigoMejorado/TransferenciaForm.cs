using CodigoMejorado.Service;
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
    //Formulario para solicitar el monto de una transaccion entre dos cuentas
    public partial class TransferenciaForm : Form
    {
        //
        private readonly ErrorProvider _errProvider = new ErrorProvider();
        private readonly ServiceCuenta _SC;
        private readonly int _CuentaOrigenId;
        private readonly int _CuentaDestinoId;

        // Monto ingresado por el usuario para la transferencia
        public decimal Monto { get; private set; }
        public TransferenciaForm( ServiceCuenta serviceCuenta , int cuentaOrigenId,int cuentaDestinoId)
        {
            InitializeComponent();
            _SC = serviceCuenta ?? throw new ArgumentNullException(nameof(serviceCuenta));
            _CuentaOrigenId = cuentaOrigenId;
            _CuentaDestinoId = cuentaDestinoId;

            _errProvider.ContainerControl = this;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var origen = _SC.ObtenerCuentaPorId(_CuentaOrigenId);
            var destino = _SC.ObtenerCuentaPorId(_CuentaDestinoId);

            lblCuentaOrigen.Text = $"Origen: {origen.Cliente.Nombre} - {origen.NumeroCuenta}";
            lblCuentaDestino.Text = $"Destino: {destino.Cliente.Nombre} - {destino.NumeroCuenta}";
            lblMonto.Text = $"Saldo Disponible: {origen.Saldo:C}";
        }

        // Valida el monto ingresado y marca error si no es válido.
        private bool ValidarMonto()
        {
            _errProvider.Clear();
            if (numMonto.Value <= 0)
            {
                _errProvider.SetError(numMonto, "Debe ingresar un monto mayor que cero.");
                return false;
            }
            return true;
        }
        // Evento clic en “Aceptar”: valida el monto y cierra el formulario con OK.
        private void Aceptar(object sender, EventArgs e)
        {
            if (!ValidarMonto())
                return;

            Monto = numMonto.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        // Evento clic en “Cancelar”: cierra el formulario sin acción.

        private void Cancelar(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
