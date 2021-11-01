using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
   public class Agenda
    {
        public int idAgenda { get; set; }
        public string Recordatorio { get; set; }
        public int  idUsuario { get; set; }
        public int  UsuariosSistema { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaDelRegistro { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int Email { get; set; }
    }
}
