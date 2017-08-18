using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamCar
{
    public class ClVehiculo
    {
        public int Id { get; set; }
        public string codigo { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int ano { get; set; }
        public string categoria { get; set; }
        public  decimal precio { get; set; }
        public string chasis { get; set; }
        public string transmicion { get; set; }
        public string kilometraje { get; set; }
        public int cantidad { get; set; }
    }
}