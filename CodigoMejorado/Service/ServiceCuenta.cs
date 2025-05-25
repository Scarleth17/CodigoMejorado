using CodigoMejorado.Data;
using CodigoMejorado.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoMejorado.Service
{
    public class ServiceCuenta
    {
        private readonly BancoSimpleContext _context;

        public ServiceCuenta(BancoSimpleContext context)
        {
            _context = context;
        }

        public Cuenta ObtenerCuentaPorId(int cuentaId)
        {
            return _context.Cuentas
                .Include(c => c.Cliente)
                .FirstOrDefault(c => c.CuentaId == cuentaId)
                ?? throw new InvalidOperationException($"Cuenta con ID {cuentaId} no encontrada.");
        }

        public List<Cliente> ObtenerClientesConCuentas()
        {
            return _context.Clientes.Include(c => c.Cuentas).ToList();
        }

        public List<object> ObtenerCuentasActivas()
        {
            return _context.Cuentas
                .Include(c => c.Cliente)
                .Where(c => c.Activa)
                .Select(c => new
                {
                    c.CuentaId,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activa,
                    c.ClienteId,
                    ClienteNombre = c.Cliente.Nombre
                }).ToList<object>();
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            _context.Clientes.Add(nuevoCliente);
            _context.SaveChanges();
        }

        public void AgregarCuenta(Cuenta nuevaCuenta)
        {
            _context.Cuentas.Add(nuevaCuenta);
            _context.SaveChanges();
        }

        public void DesactivarCuenta(int cuentaId)
        {
            var cuenta = _context.Cuentas.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Activa = false;
                _context.SaveChanges();
            }
        }

        public void RealizarTransferencia(int cuentaOrigenId, int cuentaDestinoId, decimal monto)
        {
            using var transaccion = _context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);

            try
            {
                var cuentaOrigen = _context.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaOrigenId);
                var cuentaDestino = _context.Cuentas.FirstOrDefault(c => c.CuentaId == cuentaDestinoId);

                if (cuentaOrigen == null || cuentaDestino == null)
                    throw new Exception("Una de las cuentas no existe.");

                if (monto <= 0)
                    throw new Exception("El monto debe ser mayor que cero.");

                if (cuentaOrigen.Saldo < monto)
                    throw new Exception("Saldo insuficiente.");

                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;

                _context.Transacciones.Add(new Transaccion
                {
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Descripcion = "Transferencia",
                    CuentaOrigenId = cuentaOrigenId,
                    CuentaDestinoId = cuentaDestinoId
                });

                _context.SaveChanges();
                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }
    }

}
