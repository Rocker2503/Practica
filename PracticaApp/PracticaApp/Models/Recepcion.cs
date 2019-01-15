using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaApp.Models
{
    public class Recepcion
    {
        public int Id { get; set; }
        [Display(Name = "Numero de Lote")]
        public int NumLote { get; set; }
        public string Proveedor { get; set; }
        [Display(Name = "Rut de Proveedor")]
        public string RutProveedor { get; set; }
        [Display(Name = "Peso en Kg")]
        public int PesoFruta { get; set; }

        public Recepcion(int Id, int NumLote, string Proveedor, string RutProveedor, int PesoFruta)
        {
            this.Id = Id;
            this.NumLote = NumLote;
            this.Proveedor = Proveedor;
            this.RutProveedor = RutProveedor;
            this.PesoFruta = PesoFruta;
        }

        public Recepcion()
        {

        }
    }

}
