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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Transaccionesbtn_Click(object sender, EventArgs e)
        {
            Transacciones transaccionesForm = new Transacciones();  
            transaccionesForm.TopMost = true;
            transaccionesForm.TopLevel = false;
            this.pnforms.Controls.Add(transaccionesForm);
            transaccionesForm.Show();
        }

        private void Cuentasbtn_Click(object sender, EventArgs e)
        {
            Cuentas cuentasForm = new Cuentas();
            cuentasForm.TopMost = true;
            cuentasForm.TopLevel = false;
            this.pnforms.Controls.Add(cuentasForm);
            cuentasForm.Show();
        }

        private void Clientesbtn_Click(object sender, EventArgs e)
        {
            Clientes clientesForm = new Clientes();
            clientesForm.TopMost = true;
            clientesForm.TopLevel = false;
            this.pnforms.Controls.Add(clientesForm);
            clientesForm.Show();
        }
    }
}
