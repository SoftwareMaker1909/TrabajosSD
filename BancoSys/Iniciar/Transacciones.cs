using Iniciar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iniciar
{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void btnrealizar_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var trasaccion = new Modelos.Transacciones();
                trasaccion.no_cuenta = int.Parse(cbcuenta.SelectedItem.ToString());
                trasaccion.monto_trasaccion = decimal.Parse(tbmonto.Text);
                if (cbtipotrasaccion.SelectedItem.ToString() == "Credito")
                {
                    // representa de credito
                    trasaccion.tipo_trasaccion = 1;
                } else
                {
                    // representa de debito
                    trasaccion.tipo_trasaccion = 0;
                    trasaccion.monto_trasaccion *= -1;
                }
                db.Transacciones.Add(trasaccion);
                var cuenta = db.Cuentas.Find(trasaccion.no_cuenta);
                db.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
                cuenta.saldo += trasaccion.monto_trasaccion;
                db.SaveChanges();
            }
            consultarDatos();
        }

        private void Transacciones_Load(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var cuentas = db.Cuentas.ToList();
                foreach (var cuenta in cuentas)
                {
                    cbcuenta.Items.Add(cuenta.no_cuenta);
                }
                // cbcuenta.SelectedIndex = 0;
            }
            consultarDatos();
        }

        private void consultarDatos()
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                dgvDatos.DataSource = null;
                this.dgvDatos.DataSource = db.Transacciones.ToList();
            }
        }
    }
}
