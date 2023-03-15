using Aplicacion.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Feautres.Libros.Consultas.ObtenerTodosLibros
{
    public class ObtenerTodosLibrosParametros: RespuestaParametros
    {

        public String? TituloLibro { get; set; }
    }
}
