using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BD
{
    public class AccesoDatos
    {
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=BRENDA-PC; database=DISCOS_DB; integrated security=true");
            comando = new SqlCommand();
        }
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader PropLector
        {
            get { return lector; }
        }
        public void Consultar(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void Leer()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Ejecutar(){
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Cerrar()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
