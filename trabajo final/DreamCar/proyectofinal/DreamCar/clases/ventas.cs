using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamCar
{
    public class ventas
    {
        public int Numero { get; set; }
        public int codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Vendedor { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Itbis { get; set; }
        public string Cliente { get; set; }

    } 
}