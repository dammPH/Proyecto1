using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using ModeloDominio;

namespace ModeloDatos
{
    public class EstiloData
    {
        public List<Estilo> Listar()
        {
            List<Estilo> Lista = new List<Estilo>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.Consultar("select Id, Descripcion from ESTILOS");
                Datos.Leer();
                while (Datos.PropLector.Read())
                {
                    Estilo Aux = new Estilo();
                    Aux.Id = (int)Datos.PropLector["Id"];
                    Aux.Descripcion = (string)Datos.PropLector["Descripcion"];
                    Lista.Add(Aux);
                }
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { Datos.Cerrar(); }
            
        }
    }
}
