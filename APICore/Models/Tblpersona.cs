using System;
using System.Collections.Generic;

#nullable disable

namespace APICore.Models
{
    public partial class Tblpersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdCiudad { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }
        public bool Activo { get; set; }

        public virtual Tblciudad IdCiudadNavigation { get; set; }
    }
}
