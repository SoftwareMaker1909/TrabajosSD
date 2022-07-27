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

namespace Iniciar

{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();

        }

        ConsultasSQL sql = new ConsultasSQL();
        private void backCbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int NoCuentar = new Random().Next(100000000, 1999999999);

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            IDTXT.Text = dgv.Rows.Count.ToString();
            NoCuentaTXT.Text = NoCuentar.ToString();

            if (sql.insertar(IDTXT.Text, NAMETXT.Text, LNAMETXT.Text, ADDRESSTXT.Text, CELLTXT.Text, GENDERTXT.Text, NoCuentaTXT.Text))
            {

                MessageBox.Show("DATOS Agregados CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("NO SE HAN PODIDO Agregar LOS DATOS");
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgv.Rows[e.RowIndex];
            IDTXT.Text = Convert.ToString(fila.Cells[0].Value);
            NAMETXT.Text = Convert.ToString(fila.Cells[1].Value);
            LNAMETXT.Text = Convert.ToString(fila.Cells[2].Value);
            ADDRESSTXT.Text = Convert.ToString(fila.Cells[3].Value);
            CELLTXT.Text = Convert.ToString(fila.Cells[4].Value);
            GENDERTXT.Text = Convert.ToString(fila.Cells[5].Value);
            var NoCuentar = new Random().Next(100000, 199999);
           







        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgv.DataSource = sql.MostrarDatos();

        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {

            if (sql.Eliminar(IDTXT.Text))
            {

                MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE");
            }
            else
            {
                MessageBox.Show("NO SE HAN PODIDO ELIMINAR LOS DATOS");
            }
        }
    }
}
