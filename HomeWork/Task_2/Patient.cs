namespace HomeWork
{
    public class Patient
    {
        public string name;
        public TreatmentPlan treatmentPlan;

        public Patient(string name, TreatmentPlan treatmentPlan)
        {
            this.name = name;
            this.treatmentPlan = treatmentPlan;
        }

        public void TreatPatient()
        {
            Doctor resultDoc = treatmentPlan.AppointDoctor();
            resultDoc.Treat();

        }
    }
}
