using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PresupuestoHospitalario
{
    class CalculoDePorcetaje
    {
        public int Ginecologia (int prespusto)
        {
            return (prespusto * 40) / 100;
        }

        public int Traumatologia (int prespuesto)
        {
            return (prespuesto * 30) / 100;
        }

        public int Pediatria (int presupuesto)
        {
            return (presupuesto * 30) / 100;
        }
    }
}
