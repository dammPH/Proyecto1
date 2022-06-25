using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDominio
{
    public class Disco
    {
        public string Titulo { get; set; }
        public int CantCanciones { get; set; }
        public string UrlImagen { get; set; }
        public Estilo TipoEstilo { get; set; }
    }
}
