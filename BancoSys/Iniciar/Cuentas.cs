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
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            tbnocuenta.Text = "";
            cbcliente.SelectedIndex = 0;
            cbtipocuenta.SelectedIndex = 0;
            textBox1.Text = "";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void consultarDatos()
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                dgvDatos.DataSource = null;
                this.dgvDatos.DataSource = db.Cuentas.ToList();
            }
        }   

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var cuenta = new Modelos.Cuentas();
                cuenta.tipo_cuenta = cbtipocuenta.SelectedItem.ToString();
                string str = cbcliente.Text;
                var id = int.Parse(str.Split(' ')[0]);
                cuenta.no_cliente = db.Clientes.Where(x => x.no_cliente == id).FirstOrDefault().no_cliente;
                cuenta.saldo = decimal.Parse(textBox1.Text);
                // validar que no exista una cuenta con ese cliente asociado
                if (db.Cuentas.Where(x => x.no_cliente == id).FirstOrDefault() == null)
                {
                    db.Cuentas.Add(cuenta);
                    db.SaveChanges();
                }
            }
            limpiar();
            consultarDatos();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var clientes = db.Clientes.ToList();
                foreach (var cliente in clientes)
                {
                    cbcliente.Items.Add(cliente.no_cliente + " " + cliente.nombre);
                }
                cbcliente.SelectedIndex = 0;
            }
            consultarDatos();
        }

        private void dgvDatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Actualizarbtn.Enabled = true;
            eliminarbtn.Enabled = true;
            Agregarbtn.Enabled = false;
            tbnocuenta.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString();
            textBox1.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[2].Value.ToString();

            using (BancoAppEntities db = new BancoAppEntities())
            {
                var no_cliente = int.Parse(dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[3].Value.ToString());
                var cliente = db.Clientes.Where(x => x.no_cliente == no_cliente).FirstOrDefault();
                for(int i = 0; i < cbcliente.Items.Count; i++)
                {
                    if(cbcliente.Items[i].ToString() == cliente.no_cliente + " " + cliente.nombre)
                    {
                        cbcliente.SelectedIndex = i;
                    }
                }
            }
            
            if (dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[1].Value.ToString() == "Ahorro")
            {
                cbtipocuenta.SelectedIndex = 0;
            }
            else
            {
                cbtipocuenta.SelectedIndex = 1;
            }
        }

        private void Actualizarbtn_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var id = int.Parse(tbnocuenta.Text);
                var cuenta = db.Cuentas.Find(id);
                cuenta.tipo_cuenta = cbtipocuenta.SelectedItem.ToString();
                string str = cbcliente.Text;
                cuenta.no_cliente = db.Clientes.Where(x => x.no_cliente == id).FirstOrDefault().no_cliente;
                cuenta.saldo = decimal.Parse(textBox1.Text);
                db.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            limpiar();
            consultarDatos();
            Actualizarbtn.Enabled = false;
            eliminarbtn.Enabled = false;
            Agregarbtn.Enabled = true;
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                var id = int.Parse(tbnocuenta.Text);
                var cuenta = db.Cuentas.Find(id);
                db.Cuentas.Remove(cuenta);
                db.SaveChanges();
            }
            limpiar();
            consultarDatos();
            Actualizarbtn.Enabled = false;
            eliminarbtn.Enabled = false;
            Agregarbtn.Enabled = true;
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if (tbsearch.Text != "")
            {
                using (BancoAppEntities db = new BancoAppEntities())
                {
                    dgvDatos.DataSource = null;
                    //this.dgvDatos.Rows.Clear();
                    var id = int.Parse(tbsearch.Text);
                    this.dgvDatos.DataSource = db.Cuentas.Where(x => x.no_cuenta == id).ToList();
                }
            }
        }
    }
}
