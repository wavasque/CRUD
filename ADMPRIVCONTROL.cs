
namespace MBproject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ADMPRIVCONTROL
    {
        public int IdControlAcceso { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string CodigoControl { get; set; }
        public Nullable<int> Acceso { get; set; }
    }
}
