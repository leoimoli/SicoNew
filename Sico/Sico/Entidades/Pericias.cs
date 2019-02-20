using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sico.Entidades
{
    public class Pericias
    {
        public int idPericia { get; set; }
        public string Tribunal { get; set; }
        public DateTime Fecha { get; set; }
        public string NroCausa { get; set; }
        public string Causa { get; set; }
        public string Estado { get; set; }
        public string Archivo1 { get; set; }
        public string Archivo2 { get; set; }
        public string Archivo3 { get; set; }
        public int Compartido { get; set; }
        public string Email { get; set; }

    }
}
