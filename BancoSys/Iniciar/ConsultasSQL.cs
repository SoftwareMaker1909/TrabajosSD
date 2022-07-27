using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clientes

{
    internal class ConsultasSQL
    {

        private SqlConnection conexion = new SqlConnection("Data Source = THEKILLERCODE\\SQL; Initial Catalog = Banco ; Integrated Security = True");
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Clientes_BanCO", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Clientes_BanCO");
            conexion.Close();
            return ds.Tables["Clientes_BanCO"];
        }

        public DataTable BuscarN(string nombre)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format ("select * from Clientes_BanCO where Nombre_Cliente like '%{0}%' ", nombre ), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Clientes_BanCO");
            conexion.Close();
            return ds.Tables["Clientes_BanCO"];
        }

        public DataTable BuscarA(string apellido)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("select * from Clientes_BanCO where Apellido_Cliente like '%{0}%' ", apellido), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "Clientes_BanCO");
            conexion.Close();
            return ds.Tables["Clientes_BanCO"];
        }
        public bool insertar(string id, string nombre, string apellido, string direccion, string telefono, string genero, string NoCuenta)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("insert into Clientes_Banco values {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' ", new string[] { id, nombre, apellido, direccion, telefono, genero, NoCuenta }, conexion));
            int fillasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (fillasafectadas > 0) return true;
            else return false;  
        }

        public bool Eliminar (string id)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("delete from Clientes_Banco where NoCliente = {0}", id)  , conexion);
            int fillasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (fillasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id, string nombre, string apellido, string direccion, string telefono, string genero, string NoCuenta)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("update Clientes_Banco set Nombre_Cliente = {0}, Apellido_Cliente = {1},  Direccion_Cliente = {2},Telefono = {3},Sexo = {4}, NoCuenta = {5} where NoCliente = {6}  ", new string[] { nombre, apellido, direccion, telefono, genero, NoCuenta,id }),conexion );
            int fillasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();

            if (fillasafectadas > 0) return true;
            else return false;
        }



    }


}
