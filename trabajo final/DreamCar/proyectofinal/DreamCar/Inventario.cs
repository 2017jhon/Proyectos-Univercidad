using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamCar
{
    public class Inventario
    {
        public int id { get; set; }
        public int idproducto { get; set; }
        public double costoUnitario { get; set; }
        public int cantidad { get; set; }
    }
}