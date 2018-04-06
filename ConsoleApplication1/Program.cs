using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Common;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataClasses1DataContext cr = new ve_vehiculo();
            ve_vehiculo v = new ve_vehiculo();
            v.ve_vehiculo_modelo_id = 1;
            v.ve_vehiculo_color_id = 1;
            v.anio_fabricacion = 2000;
            v.anio_compra = 2001;
            v.cilindraje = "1200";
            v.codigo = "vl-001";
            v.PaisCodigo = "ECU";
            v.placa = "LBL123";
            
            
           






        }
    }
}
