using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EJERCICIO3.Models
{
   public class Empleados
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        [MaxLength(100)]
        public String nombres { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }

        public Int32 edad { get; set; }

        [MaxLength(100)]
        public String correo { get; set; }

        [MaxLength(100)]
        public String direccion { get; set; }
    }
}
