using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using ModeloDominio;

namespace ModeloDatos
{
    public class DiscoData
    {
        public List<Disco> Listar()
        {
            List<Disco> Lista = new List<Disco>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.Consultar("select Titulo, CantidadCanciones, UrlImagenTapa, E.Descripcion as Estilo from DISCOS, ESTILOS E where E.Id = IdEstilo");
                Datos.Leer();
                while (Datos.PropLector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)Datos.PropLector["Titulo"];
                    aux.CantCanciones = (int)Datos.PropLector["CantidadCanciones"];
                    aux.UrlImagen = (string)Datos.PropLector["UrlImagenTapa"];
                    aux.TipoEstilo = new Estilo();
                    aux.TipoEstilo.Descripcion = (string)Datos.PropLector["Estilo"];
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex; 
            }
            finally { Datos.Cerrar(); }
        }
        
        public void Agregar(Disco Nuevo)
        {

        }
    }
}
