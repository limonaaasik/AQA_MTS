using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program1
    {
        static void Main2(string[] args)
        {

            Patient patient1 = new Patient("Ксюша", new TreatmentPlan(3));
            patient1.TreatPatient();

            Patient patient2 = new Patient("Лёша", new TreatmentPlan(2));
            patient2.TreatPatient();

            Patient patient3 = new Patient("Степа", new TreatmentPlan(1));
            patient3.TreatPatient();

            Patient patient4 = new Patient("Ирина", new TreatmentPlan(20));
            patient4.TreatPatient();
        }
    }
}
