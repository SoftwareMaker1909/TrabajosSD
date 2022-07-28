using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Clientes;
using Iniciar.Modelos;

namespace Iniciar

{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

        }

        private void backCbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                int id = int.Parse(dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString());
                var cliente = db.Clientes.Where(x => x.no_cliente == id).FirstOrDefault();
                cliente.nombre = tbnombre.Text;
                cliente.apellido = tbapellido.Text;
                cliente.direccion = tbdirrecion.Text;
                cliente.telefono = decimal.Parse(tbtelefono.Text);
                cliente.sexo = cbgenero.SelectedItem.ToString();
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            consultarDatos();
            Actualizarbtn.Enabled = false;
            eliminarbtn.Enabled = false;
            Agregarbtn.Enabled = true;
            limpiar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {

            using (BancoAppEntities db = new BancoAppEntities()) {
                var cliente = new Modelos.Clientes();
                cliente.nombre = tbnombre.Text;
                cliente.apellido = tbapellido.Text;
                cliente.direccion = tbdirrecion.Text;
                cliente.telefono =  decimal.Parse(tbtelefono.Text);
                cliente.sexo = cbgenero.SelectedItem.ToString();
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
            limpiar();
            consultarDatos();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void limpiar()
        {
            tbnombre.Text = "";
            tbapellido.Text = "";
            tbdirrecion.Text = "";
            tbtelefono.Text = "";
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            consultarDatos();

        }

        private void consultarDatos()
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                dgvDatos.DataSource = null;
                //this.dgvDatos.Rows.Clear();
                this.dgvDatos.DataSource = db.Clientes.ToList();
            }
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            using (BancoAppEntities db = new BancoAppEntities())
            {
                int id = int.Parse(dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString());
                var cliente = db.Clientes.Where(x => x.no_cliente == id).FirstOrDefault();
                db.Clientes.Remove(cliente);
                db.SaveChanges();
            }
            consultarDatos();
            Actualizarbtn.Enabled = false;
            eliminarbtn.Enabled = false;
            Agregarbtn.Enabled = true;
            limpiar();
        }

        private void dgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvDatos_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Actualizarbtn.Enabled = true;
            eliminarbtn.Enabled = true;
            Agregarbtn.Enabled = false;
            tbnocliente.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString();
            tbnombre.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[1].Value.ToString();
            tbapellido.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[2].Value.ToString();
            tbdirrecion.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[3].Value.ToString();
            tbtelefono.Text = dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[4].Value.ToString();
            if (dgvDatos.Rows[dgvDatos.CurrentRow.Index].Cells[0].Value.ToString() == "M")
            {
                cbgenero.SelectedIndex = 2;
            }
            else
            {
                cbgenero.SelectedIndex = 1;
            }
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if(tbsearch.Text != "")
            {
                using (BancoAppEntities db = new BancoAppEntities()) 
                {
                    dgvDatos.DataSource = null;
                    //this.dgvDatos.Rows.Clear();
                    this.dgvDatos.DataSource = db.Clientes.Where(x => x.nombre == tbsearch.Text || x.apellido == tbsearch.Text).ToList();
                }
            } 
        }
    }
}
