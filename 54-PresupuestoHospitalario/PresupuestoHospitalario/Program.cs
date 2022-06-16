using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En un hospital existen tres áreas: Ginecología, Pediatría, Traumatologia, el presupuesto anual del hospital se reparte conforme a la sig. tabla:
             *Área            Porcentaje del presupuesto
             *Ginecología           40%
             *Traumatologia         30%
             *Pediatría             30%
             *Obtener la cantidad de dinero que recibirá cada área, para cualquier monto presupuestal.*/
            CalculoDePorcetaje PrespuestoDeSector = new CalculoDePorcetaje();

            Console.WriteLine("Ingrese el monto presupuestario total del hospital:");
            int presupuesto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El monto que recibira Ginecologia es de: " + PrespuestoDeSector.Ginecologia(presupuesto));

            Console.WriteLine("El monto que recibira el sector de Traumatologia es de: " + PrespuestoDeSector.Traumatologia(presupuesto));

            Console.WriteLine("El monto que recibira el sector de Pediatria es de: " + PrespuestoDeSector.Pediatria(presupuesto));


            Console.ReadKey();

        }
    }
}
