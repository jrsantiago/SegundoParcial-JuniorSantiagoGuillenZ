using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public partial class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Cargo { get; set; }
        public Nullable<double> Sueldo { get; set; }
        public Nullable<double> Incentivo { get; set; }
    }
}
