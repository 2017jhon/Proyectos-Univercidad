using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamCar
{
    public class VariablesGlobales
    {
        public static int IdClientes = 0;

        public static int IdVehiculo = 0;

        public static int Numero = 0;

        public static int Idinventario = 0;

        public static List<ClVehiculo> listaVehiculos = new List<ClVehiculo>();
        public static List<CIClientes> listaClientes = new List<CIClientes>();
        public static List<ventas> listaVentas = new List<ventas>();
public static List<Inventario> listaInvestario = new List<Inventario>();



        public static void CrearVentas(ventas objvt)
        {
            VariablesGlobales.listaVentas.Add(objvt);

        }
        public static void CrearInventario(Inventario objinv)
        {
            VariablesGlobales.listaInvestario.Add(objinv);

        }

        public static void crearVehiculo(ClVehiculo objVehiculo)
        {
            VariablesGlobales.listaVehiculos.Add(objVehiculo);

        }

        public static void crearClientes(CIClientes objClientes)
        {
            VariablesGlobales.listaClientes.Add(objClientes);
        }

    }
}